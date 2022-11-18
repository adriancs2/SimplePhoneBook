namespace SimPB
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phoneBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.importContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromSimplePhoneBookV13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromMicrosoftExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsSimplePhoneBookFormatsimpbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToMicrosoftExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNewContact = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteContact = new System.Windows.Forms.ToolStripButton();
            this.tsEditContact = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSelectAll = new System.Windows.Forms.ToolStripButton();
            this.tsSelectNone = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lbTotal = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnHomeTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnMobileTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnWorkTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phoneBookToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phoneBookToolStripMenuItem
            // 
            this.phoneBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.deleteContactToolStripMenuItem,
            this.toolStripSeparator3,
            this.importContactsToolStripMenuItem,
            this.exportContactsToolStripMenuItem,
            this.toolStripSeparator5,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.phoneBookToolStripMenuItem.Image = global::SimPB.Properties.Resources.AddressBook;
            this.phoneBookToolStripMenuItem.Name = "phoneBookToolStripMenuItem";
            this.phoneBookToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.phoneBookToolStripMenuItem.Text = "Phone Book";
            // 
            // newContactToolStripMenuItem
            // 
            this.newContactToolStripMenuItem.Image = global::SimPB.Properties.Resources.action_add_sharp_thin;
            this.newContactToolStripMenuItem.Name = "newContactToolStripMenuItem";
            this.newContactToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.newContactToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.newContactToolStripMenuItem.Text = "New Contact";
            this.newContactToolStripMenuItem.Click += new System.EventHandler(this.newContactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Image = global::SimPB.Properties.Resources.reply_sharp_thick;
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Image = global::SimPB.Properties.Resources.action_remove_sharp_thin;
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deleteContactToolStripMenuItem.Text = "Delete Contact";
            this.deleteContactToolStripMenuItem.Click += new System.EventHandler(this.deleteContactToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // importContactsToolStripMenuItem
            // 
            this.importContactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromSimplePhoneBookV13ToolStripMenuItem,
            this.importFromMicrosoftExcelToolStripMenuItem,
            this.importFromCSVToolStripMenuItem});
            this.importContactsToolStripMenuItem.Name = "importContactsToolStripMenuItem";
            this.importContactsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.importContactsToolStripMenuItem.Text = "Import Contacts";
            // 
            // importFromSimplePhoneBookV13ToolStripMenuItem
            // 
            this.importFromSimplePhoneBookV13ToolStripMenuItem.Name = "importFromSimplePhoneBookV13ToolStripMenuItem";
            this.importFromSimplePhoneBookV13ToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.importFromSimplePhoneBookV13ToolStripMenuItem.Text = "Import from Simple Phone Book (*.simpb)";
            this.importFromSimplePhoneBookV13ToolStripMenuItem.Click += new System.EventHandler(this.importFromSimplePhoneBookV13ToolStripMenuItem_Click);
            // 
            // importFromMicrosoftExcelToolStripMenuItem
            // 
            this.importFromMicrosoftExcelToolStripMenuItem.Name = "importFromMicrosoftExcelToolStripMenuItem";
            this.importFromMicrosoftExcelToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.importFromMicrosoftExcelToolStripMenuItem.Text = "Import from Microsoft Excel";
            this.importFromMicrosoftExcelToolStripMenuItem.Click += new System.EventHandler(this.importFromMicrosoftExcelToolStripMenuItem_Click);
            // 
            // importFromCSVToolStripMenuItem
            // 
            this.importFromCSVToolStripMenuItem.Name = "importFromCSVToolStripMenuItem";
            this.importFromCSVToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.importFromCSVToolStripMenuItem.Text = "Import from CSV";
            this.importFromCSVToolStripMenuItem.Click += new System.EventHandler(this.importFromCSVToolStripMenuItem_Click);
            // 
            // exportContactsToolStripMenuItem
            // 
            this.exportContactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsSimplePhoneBookFormatsimpbToolStripMenuItem,
            this.exportToMicrosoftExcelToolStripMenuItem,
            this.exportToCSVToolStripMenuItem});
            this.exportContactsToolStripMenuItem.Name = "exportContactsToolStripMenuItem";
            this.exportContactsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exportContactsToolStripMenuItem.Text = "Export Contacts";
            // 
            // exportAsSimplePhoneBookFormatsimpbToolStripMenuItem
            // 
            this.exportAsSimplePhoneBookFormatsimpbToolStripMenuItem.Name = "exportAsSimplePhoneBookFormatsimpbToolStripMenuItem";
            this.exportAsSimplePhoneBookFormatsimpbToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.exportAsSimplePhoneBookFormatsimpbToolStripMenuItem.Text = "Export as Simple Phone Book Format (*.simpb)";
            this.exportAsSimplePhoneBookFormatsimpbToolStripMenuItem.Click += new System.EventHandler(this.exportAsSimplePhoneBookFormatsimpbToolStripMenuItem_Click);
            // 
            // exportToMicrosoftExcelToolStripMenuItem
            // 
            this.exportToMicrosoftExcelToolStripMenuItem.Name = "exportToMicrosoftExcelToolStripMenuItem";
            this.exportToMicrosoftExcelToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.exportToMicrosoftExcelToolStripMenuItem.Text = "Export to Microsoft Excel";
            this.exportToMicrosoftExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToMicrosoftExcelToolStripMenuItem_Click);
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.exportToCSVToolStripMenuItem.Text = "Export to CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(168, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::SimPB.Properties.Resources.application_sharp_thin;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(168, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SimPB.Properties.Resources.exit2;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryBrowserToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // queryBrowserToolStripMenuItem
            // 
            this.queryBrowserToolStripMenuItem.Name = "queryBrowserToolStripMenuItem";
            this.queryBrowserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.queryBrowserToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.queryBrowserToolStripMenuItem.Text = "Query Browser";
            this.queryBrowserToolStripMenuItem.Click += new System.EventHandler(this.queryBrowserToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(952, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(54, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(895, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 48);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Double click the contact to edit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewContact,
            this.tsDeleteContact,
            this.tsEditContact,
            this.toolStripSeparator1,
            this.tsSelectAll,
            this.tsSelectNone,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.lbTotal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsNewContact
            // 
            this.tsNewContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNewContact.Image = global::SimPB.Properties.Resources.action_add_sharp_thin;
            this.tsNewContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNewContact.Name = "tsNewContact";
            this.tsNewContact.Size = new System.Drawing.Size(23, 22);
            this.tsNewContact.Text = "Add Contact";
            this.tsNewContact.ToolTipText = "Add New Contact";
            this.tsNewContact.Click += new System.EventHandler(this.tsNewContact_Click);
            // 
            // tsDeleteContact
            // 
            this.tsDeleteContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteContact.Image = global::SimPB.Properties.Resources.action_remove_sharp_thin;
            this.tsDeleteContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteContact.Name = "tsDeleteContact";
            this.tsDeleteContact.Size = new System.Drawing.Size(23, 22);
            this.tsDeleteContact.Text = "Delete Contact";
            this.tsDeleteContact.ToolTipText = "Delete Contact";
            this.tsDeleteContact.Click += new System.EventHandler(this.tsDeleteContact_Click);
            // 
            // tsEditContact
            // 
            this.tsEditContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEditContact.Image = global::SimPB.Properties.Resources.reply_sharp_thick;
            this.tsEditContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditContact.Name = "tsEditContact";
            this.tsEditContact.Size = new System.Drawing.Size(23, 22);
            this.tsEditContact.Text = "Edit Contact";
            this.tsEditContact.ToolTipText = "Edit Contact";
            this.tsEditContact.Click += new System.EventHandler(this.tsEditContact_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSelectAll
            // 
            this.tsSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSelectAll.Image = global::SimPB.Properties.Resources.action_check_sharp_thin;
            this.tsSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSelectAll.Name = "tsSelectAll";
            this.tsSelectAll.Size = new System.Drawing.Size(23, 22);
            this.tsSelectAll.Text = "Select All";
            this.tsSelectAll.ToolTipText = "Select All";
            this.tsSelectAll.Click += new System.EventHandler(this.tsSelectAll_Click);
            // 
            // tsSelectNone
            // 
            this.tsSelectNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSelectNone.Image = global::SimPB.Properties.Resources.action_delete_sharp_thin;
            this.tsSelectNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSelectNone.Name = "tsSelectNone";
            this.tsSelectNone.Size = new System.Drawing.Size(23, 22);
            this.tsSelectNone.Text = "Select None";
            this.tsSelectNone.ToolTipText = "Select None";
            this.tsSelectNone.Click += new System.EventHandler(this.tsSelectNone_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel1.Text = "Total Contacts:";
            // 
            // lbTotal
            // 
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(13, 22);
            this.lbTotal.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnSelect,
            this.colnName,
            this.colnTel,
            this.colnHomeTel,
            this.colnMobileTel,
            this.colnWorkTel,
            this.colnEmail,
            this.colnFax,
            this.colnAddress,
            this.colnRemarks});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(952, 449);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // colnSelect
            // 
            this.colnSelect.Frozen = true;
            this.colnSelect.HeaderText = "";
            this.colnSelect.MinimumWidth = 25;
            this.colnSelect.Name = "colnSelect";
            this.colnSelect.Width = 25;
            // 
            // colnName
            // 
            this.colnName.Frozen = true;
            this.colnName.HeaderText = "Name";
            this.colnName.MinimumWidth = 100;
            this.colnName.Name = "colnName";
            this.colnName.ReadOnly = true;
            this.colnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colnTel
            // 
            this.colnTel.HeaderText = "Tel";
            this.colnTel.Name = "colnTel";
            this.colnTel.ReadOnly = true;
            this.colnTel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colnTel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colnHomeTel
            // 
            this.colnHomeTel.HeaderText = "Home Tel";
            this.colnHomeTel.Name = "colnHomeTel";
            this.colnHomeTel.ReadOnly = true;
            this.colnHomeTel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colnHomeTel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colnMobileTel
            // 
            this.colnMobileTel.HeaderText = "Mobile Tel";
            this.colnMobileTel.Name = "colnMobileTel";
            this.colnMobileTel.ReadOnly = true;
            this.colnMobileTel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colnMobileTel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colnWorkTel
            // 
            this.colnWorkTel.HeaderText = "Work Tel";
            this.colnWorkTel.Name = "colnWorkTel";
            this.colnWorkTel.ReadOnly = true;
            this.colnWorkTel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colnWorkTel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colnEmail
            // 
            this.colnEmail.HeaderText = "Email";
            this.colnEmail.Name = "colnEmail";
            this.colnEmail.ReadOnly = true;
            this.colnEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colnEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colnFax
            // 
            this.colnFax.HeaderText = "Fax";
            this.colnFax.Name = "colnFax";
            this.colnFax.ReadOnly = true;
            this.colnFax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colnFax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colnAddress
            // 
            this.colnAddress.HeaderText = "Address";
            this.colnAddress.Name = "colnAddress";
            this.colnAddress.ReadOnly = true;
            this.colnAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colnAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colnRemarks
            // 
            this.colnRemarks.HeaderText = "Remarks";
            this.colnRemarks.Name = "colnRemarks";
            this.colnRemarks.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(952, 546);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(270, 400);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Phone Book";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phoneBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNewContact;
        private System.Windows.Forms.ToolStripButton tsDeleteContact;
        private System.Windows.Forms.ToolStripButton tsSelectAll;
        private System.Windows.Forms.ToolStripButton tsSelectNone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsEditContact;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lbTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromSimplePhoneBookV13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromMicrosoftExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToMicrosoftExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnHomeTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnMobileTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnWorkTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnRemarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsSimplePhoneBookFormatsimpbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryBrowserToolStripMenuItem;
    }
}