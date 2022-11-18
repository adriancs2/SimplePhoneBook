namespace SimPB
{
    partial class frmContact
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btNew = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btSaveNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtWorkTel = new System.Windows.Forms.TextBox();
            this.txtMobileTel = new System.Windows.Forms.TextBox();
            this.txtHomeTel = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbHomeTel = new System.Windows.Forms.Label();
            this.lbMobileTel = new System.Windows.Forms.Label();
            this.lbWorkTel = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbFax = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbRemarks = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savenewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btNew);
            this.flowLayoutPanel1.Controls.Add(this.btSave);
            this.flowLayoutPanel1.Controls.Add(this.btSaveNew);
            this.flowLayoutPanel1.Controls.Add(this.btDelete);
            this.flowLayoutPanel1.Controls.Add(this.btClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(510, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btNew
            // 
            this.btNew.AutoSize = true;
            this.btNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btNew.Location = new System.Drawing.Point(3, 3);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(64, 25);
            this.btNew.TabIndex = 11;
            this.btNew.Text = "New (F2)";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btSave
            // 
            this.btSave.AutoSize = true;
            this.btSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSave.Location = new System.Drawing.Point(73, 3);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(64, 25);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Save (F3)";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btSaveNew
            // 
            this.btSaveNew.AutoSize = true;
            this.btSaveNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSaveNew.Location = new System.Drawing.Point(143, 3);
            this.btSaveNew.Name = "btSaveNew";
            this.btSaveNew.Size = new System.Drawing.Size(99, 25);
            this.btSaveNew.TabIndex = 10;
            this.btSaveNew.Text = "Save / New (F4)";
            this.btSaveNew.UseVisualStyleBackColor = true;
            this.btSaveNew.Click += new System.EventHandler(this.btSaveNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.AutoSize = true;
            this.btDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDelete.Location = new System.Drawing.Point(248, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(73, 25);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Delete (F5)";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btClose.Location = new System.Drawing.Point(327, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(69, 25);
            this.btClose.TabIndex = 13;
            this.btClose.Text = "Close (F6)";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 31);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(510, 334);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtRemarks, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtFax, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtWorkTel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtMobileTel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtHomeTel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbHomeTel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbMobileTel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbWorkTel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbEmail, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbFax, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbAddress, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbRemarks, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(72, 248);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(400, 54);
            this.txtRemarks.TabIndex = 9;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPressed);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(72, 219);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(400, 23);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPressed);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(72, 190);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(400, 23);
            this.txtFax.TabIndex = 7;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPressed);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 23);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPressed);
            // 
            // txtWorkTel
            // 
            this.txtWorkTel.Location = new System.Drawing.Point(72, 132);
            this.txtWorkTel.Name = "txtWorkTel";
            this.txtWorkTel.Size = new System.Drawing.Size(400, 23);
            this.txtWorkTel.TabIndex = 5;
            this.txtWorkTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPressed);
            // 
            // txtMobileTel
            // 
            this.txtMobileTel.Location = new System.Drawing.Point(72, 103);
            this.txtMobileTel.Name = "txtMobileTel";
            this.txtMobileTel.Size = new System.Drawing.Size(400, 23);
            this.txtMobileTel.TabIndex = 4;
            this.txtMobileTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPressed);
            // 
            // txtHomeTel
            // 
            this.txtHomeTel.Location = new System.Drawing.Point(72, 74);
            this.txtHomeTel.Name = "txtHomeTel";
            this.txtHomeTel.Size = new System.Drawing.Size(400, 23);
            this.txtHomeTel.TabIndex = 3;
            this.txtHomeTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPressed);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(72, 45);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(400, 23);
            this.txtTel.TabIndex = 2;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPressed);
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(3, 20);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(39, 15);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lbTel
            // 
            this.lbTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(3, 49);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(23, 15);
            this.lbTel.TabIndex = 1;
            this.lbTel.Text = "Tel";
            // 
            // lbHomeTel
            // 
            this.lbHomeTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbHomeTel.AutoSize = true;
            this.lbHomeTel.Location = new System.Drawing.Point(3, 78);
            this.lbHomeTel.Name = "lbHomeTel";
            this.lbHomeTel.Size = new System.Drawing.Size(59, 15);
            this.lbHomeTel.TabIndex = 2;
            this.lbHomeTel.Text = "Home Tel";
            // 
            // lbMobileTel
            // 
            this.lbMobileTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMobileTel.AutoSize = true;
            this.lbMobileTel.Location = new System.Drawing.Point(3, 107);
            this.lbMobileTel.Name = "lbMobileTel";
            this.lbMobileTel.Size = new System.Drawing.Size(63, 15);
            this.lbMobileTel.TabIndex = 3;
            this.lbMobileTel.Text = "Mobile Tel";
            // 
            // lbWorkTel
            // 
            this.lbWorkTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbWorkTel.AutoSize = true;
            this.lbWorkTel.Location = new System.Drawing.Point(3, 136);
            this.lbWorkTel.Name = "lbWorkTel";
            this.lbWorkTel.Size = new System.Drawing.Size(54, 15);
            this.lbWorkTel.TabIndex = 4;
            this.lbWorkTel.Text = "Work Tel";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(3, 165);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // lbFax
            // 
            this.lbFax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFax.AutoSize = true;
            this.lbFax.Location = new System.Drawing.Point(3, 194);
            this.lbFax.Name = "lbFax";
            this.lbFax.Size = new System.Drawing.Size(24, 15);
            this.lbFax.TabIndex = 6;
            this.lbFax.Text = "Fax";
            // 
            // lbAddress
            // 
            this.lbAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(3, 223);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(49, 15);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "Address";
            // 
            // lbRemarks
            // 
            this.lbRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRemarks.AutoSize = true;
            this.lbRemarks.Location = new System.Drawing.Point(3, 267);
            this.lbRemarks.Name = "lbRemarks";
            this.lbRemarks.Size = new System.Drawing.Size(52, 15);
            this.lbRemarks.TabIndex = 8;
            this.lbRemarks.Text = "Remarks";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 23);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPressed);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "*Press [Enter] or [Tab] to switch to next field.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 365);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.savenewToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShowShortcutKeys = false;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.newToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newToolStripMenuItem.Text = "new";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // savenewToolStripMenuItem
            // 
            this.savenewToolStripMenuItem.Name = "savenewToolStripMenuItem";
            this.savenewToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.savenewToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.savenewToolStripMenuItem.Text = "savenew";
            this.savenewToolStripMenuItem.Click += new System.EventHandler(this.savenewToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // frmContact
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(510, 389);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmContact";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.frmContact_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btSaveNew;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbHomeTel;
        private System.Windows.Forms.Label lbMobileTel;
        private System.Windows.Forms.Label lbWorkTel;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbFax;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtWorkTel;
        private System.Windows.Forms.TextBox txtMobileTel;
        private System.Windows.Forms.TextBox txtHomeTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savenewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}