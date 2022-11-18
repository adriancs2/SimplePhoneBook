using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SimPB
{
    public partial class frmImport : Form
    {
        DataTable dt;
        Dictionary<int, string> dicMatchField;
        Dictionary<int, string> dicColNames;
        Timer timerLoad;

        public frmImport(DataTable data, Dictionary<int, string> _dicMatchField, Dictionary<int, string> dicFieldNames)
        {
            InitializeComponent();

            if (data.Rows.Count == 0)
            {
                timerShutDown.Start();
                return;
            }

            timerLoad = new Timer();
            timerLoad.Interval = 500;
            timerLoad.Tick += new EventHandler(timerLoad_Tick);

            this.Icon = config.AppIcon;

            dt = data;
            dt.Columns.Add(new DataColumn("select", typeof(bool)));

            int lastCol = dt.Columns.Count -1;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][lastCol] = true;
            }

            dicMatchField = _dicMatchField;
            dicColNames = dicFieldNames;
            colnSample.Visible = false;

            dataGridView1.SuspendLayout();

            for (int i = 0; i < data.Columns.Count; i++)
            {
                DataGridViewColumn dc = new DataGridViewColumn();
                dc.HeaderText = data.Columns[i].ColumnName;
                dc.CellTemplate = colnSample.CellTemplate;

                if (dicMatchField.ContainsKey(i))
                {
                    dc.HeaderText = dicFieldNames[i];
                }
                else
                {
                    dc.Visible = false;
                }

                dataGridView1.Columns.Add(dc);
            }

            dataGridView1.Rows.Add(dt.Rows.Count);

            dataGridView1.ResumeLayout(false);
            dataGridView1.PerformLayout();

            timerLoad.Start();
        }

        void timerLoad_Tick(object sender, EventArgs e)
        {
            this.SuspendLayout();

            int width = 0;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].Visible)
                {
                    width = width + dataGridView1.Columns[i].Width;
                }
            }

            width = width + 50;

            if (width > Screen.PrimaryScreen.WorkingArea.Width)
                width = Screen.PrimaryScreen.WorkingArea.Width;

            this.Width = width;

            int x = 0;
            int y = 0;

            x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            x = x / 2;
            y = y / 2;

            this.Location = new Point(x, y);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex != colnSelect.Index && e.ColumnIndex != colnSample.Index)
            {
                e.Value = dt.Rows[e.RowIndex][e.ColumnIndex - 2];
            }
            else if (e.ColumnIndex == colnSelect.Index)
            {
                e.Value = DataParse.BoolParse(dt.Rows[e.RowIndex][dt.Columns.Count - 1]);
            }
        }

        private void dataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == colnSelect.Index)
            {
                dt.Rows[0][dt.Columns.Count - 1] = DataParse.BoolParse(e.Value);
            }
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            int lastCol = dt.Columns.Count - 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][lastCol] = true;
            }
            dataGridView1.EndEdit();
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();
        }

        private void btSelectNone_Click(object sender, EventArgs e)
        {
            int lastCol = dt.Columns.Count - 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][lastCol] = false;
            }
            dataGridView1.EndEdit();
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            int lastCol = dt.Columns.Count-1;
            bool hasDataSelected = false;
            foreach (DataRow dr in dt.Rows)
            {
                if (DataParse.BoolParse(dr[lastCol]))
                {
                    hasDataSelected = true;
                    break;
                }
            }

            if (!hasDataSelected)
                return;

            if (MessageBox.Show("Are you sure to import?", "Import", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        cmd.CommandText = "begin transaction;";
                        cmd.ExecuteNonQuery();

                        int c = dt.Columns.Count - 1;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            StringBuilder sb1 = new StringBuilder();
                            StringBuilder sb2 = new StringBuilder();
                            for (int j = 0; j < c; j++)
                            {
                                if (!dicMatchField.ContainsKey(j))
                                    continue;

                                if (sb1.Length > 0)
                                    sb1.AppendFormat(",");
                                if (sb2.Length > 0)
                                    sb2.AppendFormat(",");

                                sb1.AppendFormat("`");
                                sb1.AppendFormat(dicMatchField[j]);
                                sb1.AppendFormat("`");

                                sb2.AppendFormat("'");
                                sb2.Append(dt.Rows[i][j]);
                                sb2.AppendFormat("'");
                            }
                            StringBuilder sb3 = new StringBuilder();
                            sb3.AppendFormat("insert into phonebook(");
                            sb3.AppendFormat(sb1.ToString());
                            sb3.AppendFormat(")values(");
                            sb3.AppendFormat(sb2.ToString());
                            sb3.AppendFormat(");");

                            cmd.CommandText = sb3.ToString();
                            cmd.ExecuteNonQuery();
                        }

                        cmd.CommandText = "commit;";
                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }
                }

                MessageBox.Show("Import Successful.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bool b = DataParse.BoolParse(dt.Rows[e.RowIndex][dt.Columns.Count - 1]);
                dt.Rows[e.RowIndex][dt.Columns.Count - 1] = !b;
                dataGridView1.EndEdit();
                dataGridView1.ClearSelection();
                dataGridView1.Refresh();
            }
        }

        private void timerShutDown_Tick(object sender, EventArgs e)
        {
            timerShutDown.Stop();
            MessageBox.Show("No rows of data detected. The source data is empty.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
