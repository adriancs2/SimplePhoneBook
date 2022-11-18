namespace SimPB
{
    partial class frmImport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btSelectNone = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colnSample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerShutDown = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btSelectAll);
            this.flowLayoutPanel1.Controls.Add(this.btSelectNone);
            this.flowLayoutPanel1.Controls.Add(this.btImport);
            this.flowLayoutPanel1.Controls.Add(this.btCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(444, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btSelectAll
            // 
            this.btSelectAll.AutoSize = true;
            this.btSelectAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSelectAll.Location = new System.Drawing.Point(3, 3);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(65, 25);
            this.btSelectAll.TabIndex = 0;
            this.btSelectAll.Text = "Select All";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // btSelectNone
            // 
            this.btSelectNone.AutoSize = true;
            this.btSelectNone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSelectNone.Location = new System.Drawing.Point(74, 3);
            this.btSelectNone.Name = "btSelectNone";
            this.btSelectNone.Size = new System.Drawing.Size(80, 25);
            this.btSelectNone.TabIndex = 1;
            this.btSelectNone.Text = "Select None";
            this.btSelectNone.UseVisualStyleBackColor = true;
            this.btSelectNone.Click += new System.EventHandler(this.btSelectNone_Click);
            // 
            // btImport
            // 
            this.btImport.AutoSize = true;
            this.btImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btImport.Location = new System.Drawing.Point(160, 3);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(177, 25);
            this.btImport.TabIndex = 2;
            this.btImport.Text = "Start Import Selected Contacts";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCancel.Location = new System.Drawing.Point(343, 3);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(92, 25);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel Import";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnSelect,
            this.colnSample});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(444, 531);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValueNeeded);
            this.dataGridView1.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValuePushed);
            // 
            // colnSelect
            // 
            this.colnSelect.Frozen = true;
            this.colnSelect.HeaderText = "";
            this.colnSelect.Name = "colnSelect";
            this.colnSelect.Width = 5;
            // 
            // colnSample
            // 
            this.colnSample.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colnSample.HeaderText = "Column1";
            this.colnSample.Name = "colnSample";
            this.colnSample.Width = 81;
            // 
            // timerShutDown
            // 
            this.timerShutDown.Interval = 500;
            this.timerShutDown.Tick += new System.EventHandler(this.timerShutDown_Tick);
            // 
            // frmImport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(444, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 370);
            this.Name = "frmImport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btSelectNone;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnSample;
        private System.Windows.Forms.Timer timerShutDown;

    }
}