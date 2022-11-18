namespace SimPB
{
    partial class frmOptions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbTel = new System.Windows.Forms.CheckBox();
            this.cbHomeTel = new System.Windows.Forms.CheckBox();
            this.cbMobileTel = new System.Windows.Forms.CheckBox();
            this.cbWorkTel = new System.Windows.Forms.CheckBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.cbFax = new System.Windows.Forms.CheckBox();
            this.cbAddress = new System.Windows.Forms.CheckBox();
            this.cbRemarks = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSearchName = new System.Windows.Forms.CheckBox();
            this.cbSearchTel = new System.Windows.Forms.CheckBox();
            this.cbSearchHomeTel = new System.Windows.Forms.CheckBox();
            this.cbSearchMobileTel = new System.Windows.Forms.CheckBox();
            this.cbSearchWorkTel = new System.Windows.Forms.CheckBox();
            this.cbSearchEmail = new System.Windows.Forms.CheckBox();
            this.cbSearchFax = new System.Windows.Forms.CheckBox();
            this.cbSearchAddress = new System.Windows.Forms.CheckBox();
            this.cbSearchRemarks = new System.Windows.Forms.CheckBox();
            this.btSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Fields";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.checkBox1);
            this.flowLayoutPanel2.Controls.Add(this.cbTel);
            this.flowLayoutPanel2.Controls.Add(this.cbHomeTel);
            this.flowLayoutPanel2.Controls.Add(this.cbMobileTel);
            this.flowLayoutPanel2.Controls.Add(this.cbWorkTel);
            this.flowLayoutPanel2.Controls.Add(this.cbEmail);
            this.flowLayoutPanel2.Controls.Add(this.cbFax);
            this.flowLayoutPanel2.Controls.Add(this.cbAddress);
            this.flowLayoutPanel2.Controls.Add(this.cbRemarks);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(209, 245);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the fields that you what to use.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(3, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(78, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Name";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbTel
            // 
            this.cbTel.AutoSize = true;
            this.cbTel.Location = new System.Drawing.Point(3, 48);
            this.cbTel.Name = "cbTel";
            this.cbTel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbTel.Size = new System.Drawing.Size(62, 19);
            this.cbTel.TabIndex = 2;
            this.cbTel.Text = "Tel";
            this.cbTel.UseVisualStyleBackColor = true;
            this.cbTel.CheckedChanged += new System.EventHandler(this.cbCheckChanged);
            // 
            // cbHomeTel
            // 
            this.cbHomeTel.AutoSize = true;
            this.cbHomeTel.Location = new System.Drawing.Point(3, 73);
            this.cbHomeTel.Name = "cbHomeTel";
            this.cbHomeTel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbHomeTel.Size = new System.Drawing.Size(98, 19);
            this.cbHomeTel.TabIndex = 3;
            this.cbHomeTel.Text = "Home Tel";
            this.cbHomeTel.UseVisualStyleBackColor = true;
            this.cbHomeTel.CheckedChanged += new System.EventHandler(this.cbCheckChanged);
            // 
            // cbMobileTel
            // 
            this.cbMobileTel.AutoSize = true;
            this.cbMobileTel.Location = new System.Drawing.Point(3, 98);
            this.cbMobileTel.Name = "cbMobileTel";
            this.cbMobileTel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbMobileTel.Size = new System.Drawing.Size(102, 19);
            this.cbMobileTel.TabIndex = 4;
            this.cbMobileTel.Text = "Mobile Tel";
            this.cbMobileTel.UseVisualStyleBackColor = true;
            this.cbMobileTel.CheckedChanged += new System.EventHandler(this.cbCheckChanged);
            // 
            // cbWorkTel
            // 
            this.cbWorkTel.AutoSize = true;
            this.cbWorkTel.Location = new System.Drawing.Point(3, 123);
            this.cbWorkTel.Name = "cbWorkTel";
            this.cbWorkTel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbWorkTel.Size = new System.Drawing.Size(93, 19);
            this.cbWorkTel.TabIndex = 5;
            this.cbWorkTel.Text = "Work Tel";
            this.cbWorkTel.UseVisualStyleBackColor = true;
            this.cbWorkTel.CheckedChanged += new System.EventHandler(this.cbCheckChanged);
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(3, 148);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbEmail.Size = new System.Drawing.Size(75, 19);
            this.cbEmail.TabIndex = 6;
            this.cbEmail.Text = "Email";
            this.cbEmail.UseVisualStyleBackColor = true;
            this.cbEmail.CheckedChanged += new System.EventHandler(this.cbCheckChanged);
            // 
            // cbFax
            // 
            this.cbFax.AutoSize = true;
            this.cbFax.Location = new System.Drawing.Point(3, 173);
            this.cbFax.Name = "cbFax";
            this.cbFax.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbFax.Size = new System.Drawing.Size(63, 19);
            this.cbFax.TabIndex = 7;
            this.cbFax.Text = "Fax";
            this.cbFax.UseVisualStyleBackColor = true;
            this.cbFax.CheckedChanged += new System.EventHandler(this.cbCheckChanged);
            // 
            // cbAddress
            // 
            this.cbAddress.AutoSize = true;
            this.cbAddress.Location = new System.Drawing.Point(3, 198);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbAddress.Size = new System.Drawing.Size(88, 19);
            this.cbAddress.TabIndex = 8;
            this.cbAddress.Text = "Address";
            this.cbAddress.UseVisualStyleBackColor = true;
            this.cbAddress.CheckedChanged += new System.EventHandler(this.cbCheckChanged);
            // 
            // cbRemarks
            // 
            this.cbRemarks.AutoSize = true;
            this.cbRemarks.Location = new System.Drawing.Point(3, 223);
            this.cbRemarks.Name = "cbRemarks";
            this.cbRemarks.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbRemarks.Size = new System.Drawing.Size(91, 19);
            this.cbRemarks.TabIndex = 9;
            this.cbRemarks.Text = "Remarks";
            this.cbRemarks.UseVisualStyleBackColor = true;
            this.cbRemarks.CheckedChanged += new System.EventHandler(this.cbCheckChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.btSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(541, 345);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 273);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.flowLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(224, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Fields";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.cbSearchName);
            this.flowLayoutPanel3.Controls.Add(this.cbSearchTel);
            this.flowLayoutPanel3.Controls.Add(this.cbSearchHomeTel);
            this.flowLayoutPanel3.Controls.Add(this.cbSearchMobileTel);
            this.flowLayoutPanel3.Controls.Add(this.cbSearchWorkTel);
            this.flowLayoutPanel3.Controls.Add(this.cbSearchEmail);
            this.flowLayoutPanel3.Controls.Add(this.cbSearchFax);
            this.flowLayoutPanel3.Controls.Add(this.cbSearchAddress);
            this.flowLayoutPanel3.Controls.Add(this.cbSearchRemarks);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(287, 245);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "When searching records, search the following fields.";
            // 
            // cbSearchName
            // 
            this.cbSearchName.AutoSize = true;
            this.cbSearchName.Checked = true;
            this.cbSearchName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSearchName.Location = new System.Drawing.Point(3, 18);
            this.cbSearchName.Name = "cbSearchName";
            this.cbSearchName.Padding = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.cbSearchName.Size = new System.Drawing.Size(78, 24);
            this.cbSearchName.TabIndex = 10;
            this.cbSearchName.Text = "Name";
            this.cbSearchName.UseVisualStyleBackColor = true;
            this.cbSearchName.CheckedChanged += new System.EventHandler(this.cbSearchCheckedChanged);
            // 
            // cbSearchTel
            // 
            this.cbSearchTel.AutoSize = true;
            this.cbSearchTel.Location = new System.Drawing.Point(3, 48);
            this.cbSearchTel.Name = "cbSearchTel";
            this.cbSearchTel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbSearchTel.Size = new System.Drawing.Size(62, 19);
            this.cbSearchTel.TabIndex = 11;
            this.cbSearchTel.Text = "Tel";
            this.cbSearchTel.UseVisualStyleBackColor = true;
            this.cbSearchTel.CheckedChanged += new System.EventHandler(this.cbSearchCheckedChanged);
            // 
            // cbSearchHomeTel
            // 
            this.cbSearchHomeTel.AutoSize = true;
            this.cbSearchHomeTel.Location = new System.Drawing.Point(3, 73);
            this.cbSearchHomeTel.Name = "cbSearchHomeTel";
            this.cbSearchHomeTel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbSearchHomeTel.Size = new System.Drawing.Size(98, 19);
            this.cbSearchHomeTel.TabIndex = 12;
            this.cbSearchHomeTel.Text = "Home Tel";
            this.cbSearchHomeTel.UseVisualStyleBackColor = true;
            this.cbSearchHomeTel.CheckedChanged += new System.EventHandler(this.cbSearchCheckedChanged);
            // 
            // cbSearchMobileTel
            // 
            this.cbSearchMobileTel.AutoSize = true;
            this.cbSearchMobileTel.Location = new System.Drawing.Point(3, 98);
            this.cbSearchMobileTel.Name = "cbSearchMobileTel";
            this.cbSearchMobileTel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbSearchMobileTel.Size = new System.Drawing.Size(102, 19);
            this.cbSearchMobileTel.TabIndex = 13;
            this.cbSearchMobileTel.Text = "Mobile Tel";
            this.cbSearchMobileTel.UseVisualStyleBackColor = true;
            this.cbSearchMobileTel.CheckedChanged += new System.EventHandler(this.cbSearchCheckedChanged);
            // 
            // cbSearchWorkTel
            // 
            this.cbSearchWorkTel.AutoSize = true;
            this.cbSearchWorkTel.Location = new System.Drawing.Point(3, 123);
            this.cbSearchWorkTel.Name = "cbSearchWorkTel";
            this.cbSearchWorkTel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbSearchWorkTel.Size = new System.Drawing.Size(93, 19);
            this.cbSearchWorkTel.TabIndex = 14;
            this.cbSearchWorkTel.Text = "Work Tel";
            this.cbSearchWorkTel.UseVisualStyleBackColor = true;
            this.cbSearchWorkTel.CheckedChanged += new System.EventHandler(this.cbSearchCheckedChanged);
            // 
            // cbSearchEmail
            // 
            this.cbSearchEmail.AutoSize = true;
            this.cbSearchEmail.Location = new System.Drawing.Point(3, 148);
            this.cbSearchEmail.Name = "cbSearchEmail";
            this.cbSearchEmail.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbSearchEmail.Size = new System.Drawing.Size(75, 19);
            this.cbSearchEmail.TabIndex = 15;
            this.cbSearchEmail.Text = "Email";
            this.cbSearchEmail.UseVisualStyleBackColor = true;
            this.cbSearchEmail.CheckedChanged += new System.EventHandler(this.cbSearchCheckedChanged);
            // 
            // cbSearchFax
            // 
            this.cbSearchFax.AutoSize = true;
            this.cbSearchFax.Location = new System.Drawing.Point(3, 173);
            this.cbSearchFax.Name = "cbSearchFax";
            this.cbSearchFax.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbSearchFax.Size = new System.Drawing.Size(63, 19);
            this.cbSearchFax.TabIndex = 16;
            this.cbSearchFax.Text = "Fax";
            this.cbSearchFax.UseVisualStyleBackColor = true;
            this.cbSearchFax.CheckedChanged += new System.EventHandler(this.cbSearchCheckedChanged);
            // 
            // cbSearchAddress
            // 
            this.cbSearchAddress.AutoSize = true;
            this.cbSearchAddress.Location = new System.Drawing.Point(3, 198);
            this.cbSearchAddress.Name = "cbSearchAddress";
            this.cbSearchAddress.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbSearchAddress.Size = new System.Drawing.Size(88, 19);
            this.cbSearchAddress.TabIndex = 17;
            this.cbSearchAddress.Text = "Address";
            this.cbSearchAddress.UseVisualStyleBackColor = true;
            this.cbSearchAddress.CheckedChanged += new System.EventHandler(this.cbSearchCheckedChanged);
            // 
            // cbSearchRemarks
            // 
            this.cbSearchRemarks.AutoSize = true;
            this.cbSearchRemarks.Location = new System.Drawing.Point(3, 223);
            this.cbSearchRemarks.Name = "cbSearchRemarks";
            this.cbSearchRemarks.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cbSearchRemarks.Size = new System.Drawing.Size(91, 19);
            this.cbSearchRemarks.TabIndex = 18;
            this.cbSearchRemarks.Text = "Remarks";
            this.cbSearchRemarks.UseVisualStyleBackColor = true;
            this.cbSearchRemarks.CheckedChanged += new System.EventHandler(this.cbSearchCheckedChanged);
            // 
            // btSave
            // 
            this.btSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSave.Location = new System.Drawing.Point(225, 282);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(541, 345);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox cbTel;
        private System.Windows.Forms.CheckBox cbHomeTel;
        private System.Windows.Forms.CheckBox cbMobileTel;
        private System.Windows.Forms.CheckBox cbWorkTel;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.CheckBox cbFax;
        private System.Windows.Forms.CheckBox cbAddress;
        private System.Windows.Forms.CheckBox cbRemarks;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSearchName;
        private System.Windows.Forms.CheckBox cbSearchTel;
        private System.Windows.Forms.CheckBox cbSearchHomeTel;
        private System.Windows.Forms.CheckBox cbSearchMobileTel;
        private System.Windows.Forms.CheckBox cbSearchWorkTel;
        private System.Windows.Forms.CheckBox cbSearchEmail;
        private System.Windows.Forms.CheckBox cbSearchFax;
        private System.Windows.Forms.CheckBox cbSearchAddress;
        private System.Windows.Forms.CheckBox cbSearchRemarks;
    }
}