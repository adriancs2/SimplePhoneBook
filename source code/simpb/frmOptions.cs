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
    public partial class frmOptions : Form
    {

        public frmOptions()
        {        
            InitializeComponent();
            this.Icon = config.AppIcon;

            cbTel.Checked = config.ContactFields.Tel;
            cbHomeTel.Checked = config.ContactFields.HomeTel;
            cbMobileTel.Checked = config.ContactFields.MobileTel;
            cbWorkTel.Checked = config.ContactFields.WorkTel;
            cbEmail.Checked = config.ContactFields.Email;
            cbFax.Checked = config.ContactFields.Fax;
            cbAddress.Checked = config.ContactFields.Address;
            cbRemarks.Checked = config.ContactFields.Remarks;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic["tel"] = Convert.ToInt32(cbTel.Checked);
            dic["hometel"] = Convert.ToInt32(cbHomeTel.Checked);
            dic["mobiletel"] = Convert.ToInt32(cbMobileTel.Checked);
            dic["worktel"] = Convert.ToInt32(cbWorkTel.Checked);
            dic["email"] = Convert.ToInt32(cbEmail.Checked);
            dic["fax"] = Convert.ToInt32(cbFax.Checked);
            dic["address"] = Convert.ToInt32(cbAddress.Checked);
            dic["remarks"] = Convert.ToInt32(cbRemarks.Checked);

            Dictionary<string, object> dic2 = new Dictionary<string, object>();
            dic2["name"] = Convert.ToInt32(cbSearchName.Checked);
            dic2["tel"] = Convert.ToInt32(cbSearchTel.Checked);
            dic2["hometel"] = Convert.ToInt32(cbSearchHomeTel.Checked);
            dic2["mobiletel"] = Convert.ToInt32(cbSearchMobileTel.Checked);
            dic2["worktel"] = Convert.ToInt32(cbSearchWorkTel.Checked);
            dic2["email"] = Convert.ToInt32(cbSearchEmail.Checked);
            dic2["fax"] = Convert.ToInt32(cbSearchFax.Checked);
            dic2["address"] = Convert.ToInt32(cbSearchAddress.Checked);
            dic2["remarks"] = Convert.ToInt32(cbSearchRemarks.Checked);

            using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = SQLHelper.BuildUpdateSql(cmd, "usedcontactfield", dic, "id", "1");
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = SQLHelper.BuildUpdateSql(cmd, "searchfield", dic2, "id", "1");
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            config.ContactFields = new ContactFields();
            config.SearchFields = new SearchFields();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cbCheckChanged(object sender, EventArgs e)
        {
            cbSearchAddress.Enabled = cbAddress.Checked;
            cbSearchEmail.Enabled = cbEmail.Checked;
            cbSearchFax.Enabled = cbFax.Checked;
            cbSearchHomeTel.Enabled = cbHomeTel.Checked;
            cbSearchMobileTel.Enabled = cbMobileTel.Checked;
            cbSearchRemarks.Enabled = cbRemarks.Checked;
            cbSearchTel.Enabled = cbTel.Checked;
            cbSearchWorkTel.Enabled = cbWorkTel.Checked;

            if (!cbAddress.Checked)
                cbSearchAddress.Checked = false;

            if (!cbEmail.Checked)
                cbSearchEmail.Checked = false;

            if (!cbFax.Checked)
                cbSearchFax.Checked = false;

            if (!cbHomeTel.Checked)
                cbSearchHomeTel.Checked = false;

            if (!cbMobileTel.Checked)
                cbSearchMobileTel.Checked = false;

            if (!cbRemarks.Checked)
                cbSearchRemarks.Checked = false;

            if (!cbSearchTel.Checked)
                cbSearchTel.Checked = false;

            if (!cbWorkTel.Checked)
                cbSearchWorkTel.Checked = false;
        }

        private void cbSearchCheckedChanged(object sender, EventArgs e)
        {
            bool atLeastOneChecked = false;

            foreach (Control c in flowLayoutPanel3.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        atLeastOneChecked = true;
                        return;
                    }
                }
            }

            if (!atLeastOneChecked)
            {
                cbSearchName.Checked = true;
            }
        }
    }
}
