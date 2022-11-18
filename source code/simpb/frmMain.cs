using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data.OleDb;

namespace SimPB
{
    public partial class frmMain : Form
    {
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
        Timer timerLayout;
        Timer timerLoadData;
        Timer timerFirstTimeSetting;
        DataTable dt;
        Encoding utf8WithoutBOM;
        BackgroundWorker bwSearch;

        Dictionary<int, string> dicImportFieldMatch;
        Dictionary<int, string> dicImportFieldNames;
        string searchText = "";

        #region Initialization and UI Related, Miscellaneous

        public frmMain()
        {
            InitializeComponent();

            if (config.IsNewDatabase)
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }

            utf8WithoutBOM = new UTF8Encoding(false);

            toolsToolStripMenuItem.Visible = false;

            dataGridView1.VirtualMode = true;
            dataGridView1.CellValueNeeded += new DataGridViewCellValueEventHandler(dataGridView1_CellValueNeeded);
            dataGridView1.CellValuePushed += new DataGridViewCellValueEventHandler(dataGridView1_CellValuePushed);
            timerLayout = new Timer();
            timerLayout.Interval = 200;
            timerLayout.Tick += new EventHandler(timerLayout_Tick);
            timerLoadData = new Timer();
            timerLoadData.Interval = 100;
            timerLoadData.Tick += new EventHandler(timerLoadData_Tick);
            this.Icon = config.AppIcon;

            GetPreviousLayout();
            RefreshAppliedContactDetails();

            if (config.IsNewDatabase)
            {
                timerFirstTimeSetting = new Timer();
                timerFirstTimeSetting.Interval = 500;
                timerFirstTimeSetting.Tick += new EventHandler(timerFirstTimeSetting_Tick);
            }

            bwSearch = new BackgroundWorker();
            bwSearch.DoWork += new DoWorkEventHandler(bwSearch_DoWork);
            bwSearch.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwSearch_RunWorkerCompleted);
        }

        void timerFirstTimeSetting_Tick(object sender, EventArgs e)
        {
            config.IsNewDatabase = false;
            timerFirstTimeSetting.Stop();
            ConfigureOptions();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnWidthChanged += RecordFormLayout;
            this.SizeChanged += RecordFormLayout;
            this.LocationChanged += RecordFormLayout;
            Search();

            if (config.IsNewDatabase)
            {
                timerFirstTimeSetting.Start();
            }
        }

        void GetPreviousLayout()
        {
            this.SuspendLayout();

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    dt = SQLHelper.Select(cmd, "select * from formlayout where id = 1;");

                    conn.Close();
                }
            }

            if (dt.Rows.Count == 0)
                return;

            int LocationX = DataParse.IntParse(dt.Rows[0]["locationx"]);
            int LocationY = DataParse.IntParse(dt.Rows[0]["locationy"]);

            if (LocationY < 0)
                LocationY = 0;
            if (LocationX < 0)
                LocationX = 0;

            this.Height = DataParse.IntParse(dt.Rows[0]["formheight"]);
            this.Width = DataParse.IntParse(dt.Rows[0]["formwidth"]);

            if (LocationX + this.Width > Screen.PrimaryScreen.WorkingArea.Width)
            {
                LocationX = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                if (LocationX < 0)
                {
                    LocationX = 0;
                    this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                }
            }

            if (LocationY + this.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                LocationY = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
                if (LocationY < 0)
                {
                    LocationY = 0;
                    this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                }
            }

            this.Location = new Point(LocationX, LocationY);

            colnName.Width = DataParse.IntParse(dt.Rows[0]["colnname"]);
            colnTel.Width = DataParse.IntParse(dt.Rows[0]["colntel"]);
            colnMobileTel.Width = DataParse.IntParse(dt.Rows[0]["colnmobiletel"]);
            colnWorkTel.Width = DataParse.IntParse(dt.Rows[0]["colnworktel"]);
            colnEmail.Width = DataParse.IntParse(dt.Rows[0]["colnemail"]);
            colnFax.Width = DataParse.IntParse(dt.Rows[0]["colnfax"]);
            colnAddress.Width = DataParse.IntParse(dt.Rows[0]["colnaddress"]);
            colnRemarks.Width = DataParse.IntParse(dt.Rows[0]["colnremarks"]);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        void RecordFormLayout(object sender, EventArgs e)
        {
            RecordFormLayout();
        }

        void RecordFormLayout()
        {
            timerLayout.Stop();
            timerLayout.Start();
        }

        void timerLayout_Tick(object sender, EventArgs e)
        {
            timerLayout.Stop();

            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic["locationx"] = this.Location.X;
            dic["locationy"] = this.Location.Y;
            dic["formwidth"] = this.Width;
            dic["formheight"] = this.Height;
            dic["colnname"] = colnName.Width;
            dic["colntel"] = colnTel.Width;
            dic["colnhomeTel"] = colnHomeTel.Width;
            dic["colnmobiletel"] = colnMobileTel.Width;
            dic["colnworktel"] = colnWorkTel.Width;
            dic["colnemail"] = colnEmail.Width;
            dic["colnfax"] = colnFax.Width;
            dic["colnaddress"] = colnAddress.Width;
            dic["colnremarks"] = colnRemarks.Width;

            using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = SQLHelper.BuildUpdateSql(cmd, "formlayout", dic, "id", "1");
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }

        void RefreshAppliedContactDetails()
        {
            this.SuspendLayout();

            colnTel.Visible = config.ContactFields.Tel;
            colnHomeTel.Visible = config.ContactFields.HomeTel;
            colnMobileTel.Visible = config.ContactFields.MobileTel;
            colnWorkTel.Visible = config.ContactFields.WorkTel;
            colnEmail.Visible = config.ContactFields.Email;
            colnFax.Visible = config.ContactFields.Fax;
            colnAddress.Visible = config.ContactFields.Address;
            colnRemarks.Visible = config.ContactFields.Remarks;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        void ConfigureOptions()
        {
            frmOptions f = new frmOptions();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RefreshAppliedContactDetails();
            }
        }

        private void tsSelectAll_Click(object sender, EventArgs e)
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

        private void tsSelectNone_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigureOptions();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }

        private void queryBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if DEBUG
            frmQueryBrowser f = new frmQueryBrowser();
            f.Show();
#endif
        }

        #endregion

        #region SearchRecords

        void Search()
        {
            timerLoadData.Stop();
            timerLoadData.Start();
        }

        void timerLoadData_Tick(object sender, EventArgs e)
        {
            if (bwSearch.IsBusy)
            {
                return;
            }

            timerLoadData.Stop();

            searchText = txtSearch.Text.Trim();

            bwSearch.RunWorkerAsync();
        }

        void bwSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbTotal.Text = dt.Rows.Count.ToString();

            dataGridView1.SuspendLayout();

            dataGridView1.Rows.Clear();

            if (dt.Rows.Count > 0)
                dataGridView1.Rows.Add(dt.Rows.Count);

            dataGridView1.EndEdit();
            dataGridView1.ClearSelection();

            dataGridView1.ResumeLayout(false);
            dataGridView1.PerformLayout();

            this.Refresh();
        }

        void dataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0 || dt.Columns.Count == 0 || e.RowIndex > dt.Rows.Count - 1 || e.ColumnIndex > dt.Columns.Count - 1)
            {
                return;
            }

            if (e.ColumnIndex == colnSelect.Index)
                dt.Rows[e.RowIndex][dt.Columns.Count - 1] = DataParse.BoolParse(e.Value);
            else
            { }
        }

        void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0 || dt.Columns.Count == 0 || e.RowIndex > dt.Rows.Count - 1 || e.ColumnIndex > dt.Columns.Count - 1)
            {
                return;
            }

            if (e.ColumnIndex == colnSelect.Index)
                e.Value = DataParse.BoolParse(dt.Rows[e.RowIndex][dt.Columns.Count - 1]);
            else if (e.ColumnIndex == colnName.Index)
                e.Value = dt.Rows[e.RowIndex]["name"] + "";
            else if (e.ColumnIndex == colnTel.Index)
                e.Value = dt.Rows[e.RowIndex]["tel"] + "";
            else if (e.ColumnIndex == colnHomeTel.Index)
                e.Value = dt.Rows[e.RowIndex]["hometel"] + "";
            else if (e.ColumnIndex == colnMobileTel.Index)
                e.Value = dt.Rows[e.RowIndex]["mobiletel"] + "";
            else if (e.ColumnIndex == colnWorkTel.Index)
                e.Value = dt.Rows[e.RowIndex]["worktel"] + "";
            else if (e.ColumnIndex == colnAddress.Index)
                e.Value = dt.Rows[e.RowIndex]["address"] + "";
            else if (e.ColumnIndex == colnEmail.Index)
                e.Value = dt.Rows[e.RowIndex]["email"] + "";
            else if (e.ColumnIndex == colnFax.Index)
                e.Value = dt.Rows[e.RowIndex]["fax"] + "";
            else if (e.ColumnIndex == colnRemarks.Index)
                e.Value = dt.Rows[e.RowIndex]["remarks"] + "";
            else
                e.Value = "";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            Search();
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        void bwSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                List<string> lst = new List<string>();

                if (searchText.Length > 0)
                {
                    searchText = SQLHelper.GetLikeString(searchText);

                    if (config.SearchFields.Name)
                        lst.Add("name");
                    if (config.SearchFields.Tel)
                        lst.Add("tel");
                    if (config.SearchFields.HomeTel)
                        lst.Add("hometel");
                    if (config.SearchFields.MobileTel)
                        lst.Add("mobiletel");
                    if (config.SearchFields.WorkTel)
                        lst.Add("worktel");
                    if (config.SearchFields.Email)
                        lst.Add("email");
                    if (config.SearchFields.Address)
                        lst.Add("address");
                    if (config.SearchFields.Fax)
                        lst.Add("fax");
                    if (config.SearchFields.Remarks)
                        lst.Add("remarks");
                }

                using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        if (searchText.Length == 0)
                        {
                            dt = SQLHelper.Select(cmd, "select * from phonebook order by lower(name);");
                        }
                        else
                        {
                            StringBuilder sb = new StringBuilder();

                            for (int i = 0; i < lst.Count; i++)
                            {
                                if (sb.Length == 0)
                                {
                                    sb.AppendFormat("select * from phonebook where ");
                                    sb.AppendFormat(lst[i]);
                                    sb.AppendFormat(" like ");
                                    sb.AppendFormat(searchText);
                                    continue;
                                }
                                if (sb.Length > 0)
                                    sb.AppendFormat(" or ");
                                sb.AppendFormat(lst[i]);
                                sb.AppendFormat(" like ");
                                sb.AppendFormat(searchText);
                            }
                            sb.AppendFormat(" order by lower(name);");
                            dt = SQLHelper.Select(cmd, sb.ToString());
                        }

                        conn.Close();
                    }
                }

                dt.Columns.Add("select", typeof(bool));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region NewContact
        void NewContact()
        {
            frmContact f = new frmContact();
            f.ShowDialog();
            Search();
        }

        private void newContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewContact();
        }

        private void tsNewContact_Click(object sender, EventArgs e)
        {
            NewContact();
        }
        #endregion

        #region EditContact
        void Edit()
        {
            if (dataGridView1.SelectedCells.Count == 0)
                return;

            int rowIdx = dataGridView1.SelectedCells[0].RowIndex;

            if (rowIdx < 0)
                return;

            int id = DataParse.IntParse(dt.Rows[rowIdx][0]);
            frmContact f = new frmContact(id);
            f.ShowDialog();
            Search();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == colnSelect.Index && e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !DataParse.BoolParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dataGridView1.EndEdit();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != colnSelect.Index && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                Edit();
            }
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void tsEditContact_Click(object sender, EventArgs e)
        {
            Edit();
        }

        #endregion

        #region DeleteContact
        void Delete()
        {
            if (MessageBox.Show("Are you sure to delete selected contact(s)?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            int lastCol = dt.Columns.Count - 1;
            List<int> lstDel = new List<int>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (DataParse.BoolParse(dt.Rows[i][lastCol]))
                {
                    lstDel.Add(DataParse.IntParse(dt.Rows[i][0]));
                }
            }

            if (lstDel.Count == 0)
            {
                toolTip.Show("Nothing to delete.", this, 80, 80, 1000);
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = "begin transaction;";
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < lstDel.Count; i++)
                    {
                        cmd.CommandText = "delete from phonebook where id = " + lstDel[i];
                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = "commit;";
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            Search();
        }

        private void tsDeleteContact_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }
        #endregion

        #region Importing

        private void importFromSimplePhoneBookV13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = false;
            bool sameVersion = false;
            string file = "";

            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Simple Phone Book (*.simpb)|*.simpb";
            of.Multiselect = false;
            of.Title = "Import from Simple Phone Book (*.simpb)";
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = of.FileName;
            }
            else
                return;

            string dataSource = "data source=" + file;

            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(dataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    string appver = SQLHelper.ExecuteScalarString(cmd, "select `value` from `config` where `key` = 'appversion';");

                    if (appver == config.AppVersion)
                    {
                        sameVersion = true;
                        dt = SQLHelper.Select(cmd, "select * from phonebook");
                        dt.Columns.Remove("id");
                        dicImportFieldMatch = new Dictionary<int, string>();
                        dicImportFieldNames = new Dictionary<int, string>();
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            dicImportFieldMatch[i] = dt.Columns[i].ColumnName;
                            dicImportFieldNames[i] = config.dicDisplayColNames[dt.Columns[i].ColumnName.ToLower()];
                        }
                        ok = true;
                    }
                    else
                    {
                        sameVersion = false;
                        dt = SQLHelper.Select(cmd, "select * from phonebook");
                        dt.Columns.Remove("id");
                        dicImportFieldMatch = new Dictionary<int, string>();
                        dicImportFieldNames = new Dictionary<int, string>();

                        List<string> lstFN = new List<string>();
                        foreach (DataColumn dc in dt.Columns)
                            lstFN.Add(dc.ColumnName);

                        frmMatchField f = new frmMatchField(lstFN.ToArray());
                        if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            dicImportFieldMatch = f.dicDataBind;
                        }
                        else
                        {
                            return;
                        }

                        foreach (KeyValuePair<int, string> kv in dicImportFieldMatch)
                        {
                            dicImportFieldNames.Add(kv.Key, config.dicDisplayColNames[kv.Value]);
                        }
                    }

                    conn.Close();
                }
            }

            frmImport fi = new frmImport(dt, dicImportFieldMatch, dicImportFieldNames);
            fi.ShowDialog();

            Search();
        }

        private void importFromMicrosoftExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string file = "";

                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Microsoft Excel (*.xls, *.xlsx)|*.xls;*.xlsx";
                of.Multiselect = false;
                if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    file = of.FileName;
                }
                else
                    return;

                Dictionary<string, string> props = new Dictionary<string, string>();
                if (file.EndsWith(".xlsx"))
                {
                    props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
                    props["Extended Properties"] = "Excel 12.0 XML";
                }
                else if (file.EndsWith(".xls"))
                {
                    props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
                    props["Extended Properties"] = "Excel 8.0";
                }
                else
                    return;
                props["Data Source"] = file;

                StringBuilder sb = new StringBuilder();

                foreach (KeyValuePair<string, string> prop in props)
                {
                    sb.Append(prop.Key);
                    sb.Append('=');
                    sb.Append(prop.Value);
                    sb.Append(';');
                }

                string oleDBconstr = sb.ToString();

                List<string> lst = new List<string>();

                #region Get Column Name
                bool stopRead = false;
                using (OleDbConnection conn = new OleDbConnection(oleDBconstr))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;

                    DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    foreach (DataRow dr in dtSheet.Rows)
                    {
                        string sheetName = dr["TABLE_NAME"].ToString();

                        cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                        OleDbDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            if (rd.FieldCount > 1)
                            {
                                for (int i = 0; i < rd.FieldCount; i++)
                                {
                                    lst.Add(rd.GetName(i));
                                }
                                stopRead = true;
                                break;
                            }
                            if (stopRead)
                                break;
                        }
                        rd.Close();

                        if (stopRead)
                        {
                            break;
                        }
                    }

                    cmd = null;
                    conn.Close();
                }
                #endregion

                frmMatchField fm = new frmMatchField(lst.ToArray());
                if (fm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }

                dicImportFieldNames = new Dictionary<int, string>();
                dicImportFieldMatch = fm.dicDataBind;
                foreach (KeyValuePair<int, string> kv in dicImportFieldMatch)
                {
                    dicImportFieldNames.Add(kv.Key, config.dicDisplayColNames[kv.Value]);
                }

                DataTable dt = new DataTable();
                for (int i = 0; i < lst.Count; i++)
                {
                    dt.Columns.Add(new DataColumn("col" + i));
                }

                #region Get Rows

                using (OleDbConnection conn = new OleDbConnection(oleDBconstr))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;

                    DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    foreach (DataRow dr in dtSheet.Rows)
                    {
                        string sheetName = dr["TABLE_NAME"].ToString();

                        cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                        OleDbDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            if (rd.FieldCount > 1)
                            {
                                bool isEmpty = true;
                                List<string> lstA = new List<string>();
                                if (rd.FieldCount > dt.Columns.Count)
                                {
                                    for (int g = 0; g < dt.Columns.Count; g++)
                                    {
                                        if ((rd[g] + "").Trim() != "")
                                        {
                                            isEmpty = false;
                                        }
                                        lstA.Add(rd[g] + "");
                                    }
                                }
                                else
                                {
                                    for (int g = 0; g < rd.FieldCount; g++)
                                    {
                                        if ((rd[g] + "").Trim() != "")
                                        {
                                            isEmpty = false;
                                        }
                                        lstA.Add(rd[g] + "");
                                    }
                                }
                                if (!isEmpty)
                                    dt.Rows.Add(lstA.ToArray());
                            }
                        }
                        rd.Close();
                    }

                    cmd = null;
                    conn.Close();
                }

                #endregion

                frmImport fi = new frmImport(dt, dicImportFieldMatch, dicImportFieldNames);
                fi.ShowDialog();

                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importFromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string file = "";
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "*.csv|*.csv|All Files(*.*)|*.*";
                of.Multiselect = false;
                if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    file = of.FileName;
                    string[] sa = File.ReadAllLines(file);

                    DataTable dt = new DataTable();
                    string[] sb = sa[0].Split(',');

                    frmMatchField fm = new frmMatchField(sb);
                    if (fm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    {
                        return;
                    }

                    Dictionary<int, string> dicColDisplayNames = new Dictionary<int, string>();

                    foreach (KeyValuePair<int, string> kv in fm.dicDataBind)
                    {
                        dicColDisplayNames[kv.Key] = config.dicDisplayColNames[kv.Value];
                    }

                    for (int i = 0; i < sb.Length; i++)
                    {
                        dt.Columns.Add("col" + i);
                    }

                    for (int i = 1; i < sa.Length; i++)
                    {
                        #region Get Data Row

                        List<string> lstData = new List<string>();
                        StringBuilder sbb = new StringBuilder();
                        bool isNewBlock = true;
                        bool isEncapsulatedBlock = false;
                        bool captureNextDoubleQuote = false;

                        //foreach (char c in sa[i])
                        for (int k = 0; k < sa[i].Length; k++)
                        {
                            char c = sa[i][k];

                            if (k == sa[i].Length - 1)
                            {
                                if (k == ',')
                                {
                                    lstData.Add(sbb.ToString());
                                    lstData.Add("");
                                    continue;
                                }
                                else if (isEncapsulatedBlock && c == '"')
                                {
                                    lstData.Add(sbb.ToString());
                                    continue;
                                }
                                else
                                {
                                    sbb.Append(c);
                                    lstData.Add(sbb.ToString());
                                    continue;
                                }
                            }



                            if (isNewBlock)
                            {
                                isNewBlock = false;

                                if (c == '"')
                                {
                                    isEncapsulatedBlock = true;
                                    continue;
                                }
                                else
                                {
                                    isEncapsulatedBlock = false;

                                    if (c == ',')
                                    {
                                        lstData.Add("");
                                        sbb = new StringBuilder();
                                        isNewBlock = true;
                                        continue;
                                    }

                                    sbb.Append(c);
                                    continue;
                                }
                            }
                            else
                            {
                                if (isEncapsulatedBlock)
                                {
                                    if (c == '"')
                                    {
                                        if (captureNextDoubleQuote)
                                        {
                                            captureNextDoubleQuote = false;
                                            sbb.Append(c);
                                            continue;
                                        }
                                        else
                                        {
                                            captureNextDoubleQuote = true;
                                            continue;
                                        }
                                    }
                                    else if (c == ',')
                                    {
                                        if (captureNextDoubleQuote)
                                        {
                                            captureNextDoubleQuote = false;
                                            isNewBlock = true;
                                            lstData.Add(sbb.ToString());
                                            sbb = new StringBuilder();
                                            continue;
                                        }
                                    }

                                    sbb.Append(c);
                                    continue;
                                }

                                if (c == ',')
                                {
                                    lstData.Add(sbb.ToString());
                                    sbb = new StringBuilder();
                                    isNewBlock = true;
                                    continue;
                                }
                                else
                                {
                                    sbb.Append(c);
                                    continue;
                                }
                            }
                        }

                        #endregion

                        #region Add Row to DataTable

                        string[] sc = lstData.ToArray();
                        if (sc.Length == dt.Columns.Count)
                            dt.Rows.Add(sc);
                        else if (sc.Length < dt.Columns.Count)
                        {
                            string[] sd = new string[dt.Columns.Count];
                            for (int ii = 0; ii < sc.Length; ii++)
                            {
                                sd[ii] = sc[ii];
                            }
                            dt.Rows.Add(sd);
                        }
                        else if (sc.Length > dt.Columns.Count)
                        {
                            string[] sd = new string[dt.Columns.Count];
                            for (int jj = 0; jj < dt.Columns.Count; jj++)
                            {
                                sd[jj] = sc[jj];
                            }
                            dt.Rows.Add(sd);
                        }

                        #endregion
                    }

                    frmImport fi = new frmImport(dt, fm.dicDataBind, dicColDisplayNames);
                    fi.ShowDialog();


                    Search();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Exporting

        private void exportToMicrosoftExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string file = "";
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Microsoft Excel (*.xls)|*.xls";
                sf.FileName = "Backup_" + DateTime.Now.ToString("yyyyMMdd") + ".xls";
                if (sf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                file = sf.FileName;

                DataTable dt = new DataTable();

                using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        dt = SQLHelper.Select(cmd, "select * from phonebook;");

                        conn.Close();
                    }
                }

                dt.Columns.RemoveAt(0);

                Dictionary<string, string> props = new Dictionary<string, string>();
                if (file.EndsWith(".xlsx"))
                {
                    props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
                    props["Extended Properties"] = "Excel 12.0 XML";
                }
                else if (file.EndsWith(".xls"))
                {
                    props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
                    props["Extended Properties"] = "Excel 8.0";
                }
                else
                    return;
                props["Data Source"] = file;

                StringBuilder sb = new StringBuilder();

                foreach (KeyValuePair<string, string> prop in props)
                {
                    sb.Append(prop.Key);
                    sb.Append('=');
                    sb.Append(prop.Value);
                    sb.Append(';');
                }

                string oleDBconstr = sb.ToString();

                using (OleDbConnection conn = new OleDbConnection(oleDBconstr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;

                        DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                        foreach (DataRow dr in dtSheet.Rows)
                        {
                            if (dr["TABLE_NAME"].ToString() == "phonebook")
                            {
                                cmd.CommandText = "drop table phonebook;";
                                cmd.ExecuteNonQuery();
                            }
                        }

                        cmd.CommandText = @"CREATE TABLE phonebook
                            (
                            name TEXT,
                            tel TEXT,
                            hometel TEXT,
                            mobiletel TEXT,
                            worktel TEXT,
                            email TEXT,
                            fax TEXT,
                            address TEXT,
                            remarks TEXT
                            );";
                        cmd.ExecuteNonQuery();

                        StringBuilder sb2;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            sb = new StringBuilder();
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                if (sb.Length > 0)
                                    sb.Append(',');
                                sb.Append('\'');
                                sb.Append(dt.Rows[i][j]);
                                sb.Append('\'');
                            }
                            sb2 = new StringBuilder();
                            sb2.AppendFormat("insert into phonebook values(");
                            sb2.AppendFormat(sb.ToString());
                            sb2.AppendFormat(");");

                            cmd.CommandText = sb2.ToString();
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }
                }
                MessageBox.Show("Export successfully. File saved at:\n" + file, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "";
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Comma Separated Value (*.csv)|*.csv";
                sf.Title = "Export Phone Book to CSV (Comma Separated Value)";
                sf.FileName = "Backup_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
                if (sf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                file = sf.FileName;

                DataTable dt = new DataTable();
                using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        dt = SQLHelper.Select(cmd, "select * from phonebook;");

                        conn.Close();
                    }
                }

                dt.Columns.RemoveAt(0);

                using (TextWriter tw = new StreamWriter(file, false, utf8WithoutBOM))
                {
                    bool first = true;
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (first)
                            first = false;
                        else
                            tw.Write(",");

                        tw.Write(dc.ColumnName);
                    }
                    tw.WriteLine();
                    tw.Flush();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if (j != 0)
                            {
                                tw.Write(",");
                            }

                            bool needEscape = false;

                            string d = dt.Rows[i][j] + "";

                            if (d.Contains(",") || d.Contains("\""))
                            {
                                d = d.Replace("\"", "\"\"");
                                needEscape = true;
                            }

                            if (needEscape)
                                tw.Write("\"");

                            tw.Write(d);

                            if (needEscape)
                                tw.Write("\"");
                        }
                        tw.WriteLine();
                        tw.Flush();
                    }
                    tw.Close();
                }

                MessageBox.Show("Data exported successfully at:\n" + file, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportAsSimplePhoneBookFormatsimpbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Simple Phone Book Data File (*.simpb)|*.simpb";
                sf.Title = "Export Phone Book";
                sf.FileName = "Backup_" + DateTime.Now.ToString("yyyyMMdd") + ".simpb";
                if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.Copy(Environment.CurrentDirectory + "\\data.simpb", sf.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}