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
    public partial class frmQueryBrowser : Form
    {
        Button _b;

        Button lastButton
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
                lbLastAction.Text = value.Text;
            }
        }

        ToolTip _t = new ToolTip();
        ToolTip toolTip
        {
            get
            {
                _t = new ToolTip();
                _t.IsBalloon = true;
                _t.UseAnimation = true;
                _t.UseFading = true;
                return _t;
            }
            set
            {
                _t = value;
            }
        }

        public frmQueryBrowser()
        {
            InitializeComponent();
            this.Icon = config.AppIcon;
            lastButton = btSelect;
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            lastButton = btSelect;
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        dt = SQLHelper.Select(cmd, txtSql.Text);

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                dt = new DataTable();
                dt.Columns.Add("Error");
                dt.Rows.Add(ex.Message);
            }
            dataGridView1.SuspendLayout();
            dataGridView1.DataSource = dt;
            dataGridView1.ResumeLayout(false);
            dataGridView1.PerformLayout();
        }

        private void btExecuteNonQuery_Click(object sender, EventArgs e)
        {
            lastButton = btExecuteNonQuery;
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        cmd.CommandText = txtSql.Text;
                        int a = cmd.ExecuteNonQuery();

                        dt.Columns.Add("Result");
                        dt.Rows.Add(a + " row(s) affected by the last command. No resultset return.");

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                dt = new DataTable();
                dt.Columns.Add("Error");
                dt.Rows.Add(ex.Message);
            }
            dataGridView1.SuspendLayout();
            dataGridView1.DataSource = dt;
            dataGridView1.ResumeLayout(false);
            dataGridView1.PerformLayout();
        }

        private void txtSql_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lastButton.PerformClick();
                e.Handled = true;
            }
        }
    }
}
