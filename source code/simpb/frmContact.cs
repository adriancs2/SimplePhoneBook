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
    public partial class frmContact : Form
    {
        Contact _c;
        ToolTip _t;
        ToolTip toolTip
        {
            get
            {
                _t = new ToolTip();
                _t.IsBalloon = true;
                return _t;
            }
            set
            {
                _t = value;
            }
        }
        System.Drawing.Color ColorbtSaveNew;
        Contact contact 
        {
            get
            {
                return _c;
            }
            set
            {
                _c = value;
                if (_c == null || _c.Id == 0)
                    btDelete.Enabled = false;
                else
                    btDelete.Enabled = true;
            }
        }
        Timer timer1 = new Timer();

        public frmContact()
        {
            BuildForm();
        }

        public frmContact(int id)
        {
            BuildForm();

            using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    contact = new Contact(cmd, id);

                    conn.Close();
                }
            }

            if (contact.Id > 0)
            {
                LoadData();
            }
        }

        void BuildForm()
        {
            InitializeComponent();

            this.menuStrip1.Visible = false;

            ColorbtSaveNew = this.btSaveNew.BackColor;

            this.Icon = config.AppIcon;

            txtAddress.GotFocus += txtGotFocus;
            txtEmail.GotFocus += txtGotFocus;
            txtFax.GotFocus += txtGotFocus;
            txtHomeTel.GotFocus += txtGotFocus;
            txtMobileTel.GotFocus += txtGotFocus;
            txtName.GotFocus += txtGotFocus;
            txtRemarks.GotFocus += txtGotFocus;
            txtTel.GotFocus += txtGotFocus;
            txtWorkTel.GotFocus += txtGotFocus;

            txtAddress.LostFocus += txtLostFocus;
            txtEmail.LostFocus += txtLostFocus;
            txtFax.LostFocus += txtLostFocus;
            txtHomeTel.LostFocus += txtLostFocus;
            txtMobileTel.LostFocus += txtLostFocus;
            txtName.LostFocus += txtLostFocus;
            txtRemarks.LostFocus += txtLostFocus;
            txtTel.LostFocus += txtLostFocus;
            txtWorkTel.LostFocus += txtLostFocus;
            btSaveNew.GotFocus += new EventHandler(btSaveNew_GotFocus);
            btSaveNew.LostFocus += new EventHandler(btSaveNew_LostFocus);

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 100;

            lbAddress.Visible = txtAddress.Visible = config.ContactFields.Address;
            lbEmail.Visible = txtEmail.Visible = config.ContactFields.Email;
            lbFax.Visible = txtFax.Visible = config.ContactFields.Fax;
            lbHomeTel.Visible = txtHomeTel.Visible = config.ContactFields.HomeTel;
            lbMobileTel.Visible = txtMobileTel.Visible = config.ContactFields.MobileTel;
            lbRemarks.Visible = txtRemarks.Visible = config.ContactFields.Remarks;
            lbTel.Visible = txtTel.Visible = config.ContactFields.Tel;
            lbWorkTel.Visible = txtWorkTel.Visible = config.ContactFields.WorkTel;

            contact = new Contact();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            txtName.Focus();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        void btSaveNew_LostFocus(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = ColorbtSaveNew;
            ((Button)sender).UseVisualStyleBackColor = true;
        }

        void btSaveNew_GotFocus(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.LightGreen;
        }

        void txtLostFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = System.Drawing.Color.White;
        }

        void txtGotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = System.Drawing.Color.LightYellow;

            if (!((TextBox)sender).Visible)
            {
                if (((TextBox)sender).Name == txtRemarks.Name)
                    btSaveNew.Focus();
                else
                    this.SelectNextControl(((Control)sender), true, true, true, true);
            }
        }

        private void txtKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (Keys.Enter != (Keys)e.KeyChar)
            {
                return;
            }

            if (((TextBox)sender).Name == txtRemarks.Name)
                btSaveNew.Focus();
            else
                this.SelectNextControl(((Control)sender), true, true, true, true);

            e.Handled = true;
        }

        void LoadData()
        {
            txtName.Text = contact.Name;
            txtTel.Text = contact.Tel;
            txtHomeTel.Text = contact.HomeTel;
            txtMobileTel.Text = contact.MobileTel;
            txtWorkTel.Text = contact.WorkTel;
            txtEmail.Text = contact.Email;
            txtAddress.Text = contact.Address;
            txtFax.Text = contact.Fax;
            txtRemarks.Text = contact.Remarks;
        }

        bool Save()
        {
            if (txtName.Text.Trim().Length == 0)
            {
                toolTip.IsBalloon = true;
                Point p = this.PointToClient(tableLayoutPanel1.PointToScreen(txtName.Location));
                toolTip.Show("Name cannot be empty.", this, new Point(p.X + 15, p.Y - 5), 1500);
                txtName.Focus();
                return false;
            }

            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic["name"] = txtName.Text;
            dic["tel"] = txtTel.Text;
            dic["hometel"] = txtHomeTel.Text;
            dic["mobiletel"] = txtMobileTel.Text;
            dic["worktel"] = txtWorkTel.Text;
            dic["email"] = txtEmail.Text;
            dic["fax"] = txtFax.Text;
            dic["address"] = txtAddress.Text;
            dic["remarks"] = txtRemarks.Text;

            using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    if (contact.Id > 0)
                    {
                        cmd.CommandText = SQLHelper.BuildUpdateSql(cmd, "phonebook", dic, "id", contact.Id.ToString());
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd.CommandText = SQLHelper.BuildInsertSql(cmd, "phonebook", dic);
                        cmd.ExecuteNonQuery();

                        int a = SQLHelper.ExecuteScalarInt(cmd, "SELECT last_insert_rowid();");
                        contact = new Contact(cmd, a);
                    }

                    conn.Close();
                }
            }

            toolTip.IsBalloon = true;
            toolTip.Show("Saved", this, new Point(btSave.Location.X+50, btSave.Location.Y), 1000);
            return true;
        }

        void New()
        {
            contact = new Contact();
            LoadData();
            txtName.Focus();
        }

        void Delete()
        {
            if (contact.Id > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand())
                        {
                            cmd.Connection = conn;
                            conn.Open();

                            cmd.CommandText = "delete from phonebook where id = " + contact.Id;
                            cmd.ExecuteNonQuery();

                            conn.Close();
                        }
                    }
                    this.Close();
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btSaveNew_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                New();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void savenewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btSaveNew_Click(this, null);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
