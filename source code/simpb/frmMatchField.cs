using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimPB
{
    public partial class frmMatchField : Form
    {
        bool stopProcess = false;

        public Dictionary<int, string> dicDataBind = new Dictionary<int, string>();

        Dictionary<int, ComboBox> dicCombobox = new Dictionary<int, ComboBox>();

        Dictionary<string, bool> dicUsedField = new Dictionary<string, bool>();

        public frmMatchField(string[] sa)
        {
            InitializeComponent();
            this.Icon = config.AppIcon;

            for (int i = 0; i < sa.Length; i++)
            {
                dicCombobox.Add(i, GetNewComboBox());
                dicCombobox[i].SelectedIndexChanged += new EventHandler(frmMatchField_SelectedIndexChanged);
            }

            int rowCount = 0;
            foreach (KeyValuePair<int, ComboBox> kv in dicCombobox)
            {
                rowCount = rowCount + 1;
                tableLayoutPanel1.Controls.Add(kv.Value, 1, rowCount);
                Label lb = new Label();
                lb.Text = sa[kv.Key];
                lb.AutoSize = true;
                lb.Anchor = AnchorStyles.Left;
                tableLayoutPanel1.Controls.Add(lb, 0, rowCount);
            }
        }

        void frmMatchField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stopProcess)
                return;

            stopProcess = true;

            dicUsedField = new Dictionary<string, bool>();

            List<string> lst = new List<string>();

            foreach (KeyValuePair<int, ComboBox> kv in dicCombobox)
            {
                lst.Add(kv.Value.SelectedValue + "");
                if (kv.Value.SelectedIndex > 0)
                {
                    dicUsedField[kv.Value.SelectedValue + ""] = true;
                }
            }

            int count = -1;

            foreach (KeyValuePair<int, ComboBox> kv in dicCombobox)
            {
                count = count + 1;
                string curValue = lst[count];

                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Rows.Add("0", "None");

                if (!dicUsedField.ContainsKey("name") || curValue == "name")
                    dt.Rows.Add("name", "Name");

                if (!dicUsedField.ContainsKey("tel") || curValue == "tel")
                dt.Rows.Add("tel", "Tel");

                if (!dicUsedField.ContainsKey("hometel") || curValue == "hometel")
                dt.Rows.Add("hometel", "Home Tel");

                if (!dicUsedField.ContainsKey("mobiletel") || curValue == "mobiletel")
                dt.Rows.Add("mobiletel", "Mobile Tel");

                if (!dicUsedField.ContainsKey("worktel") || curValue == "worktel")
                dt.Rows.Add("worktel", "Work Tel");

                if (!dicUsedField.ContainsKey("email") || curValue == "email")
                dt.Rows.Add("email", "Email");

                if (!dicUsedField.ContainsKey("fax") || curValue == "fax")
                dt.Rows.Add("fax", "Fax");

                if (!dicUsedField.ContainsKey("address") || curValue == "address")
                dt.Rows.Add("address", "Address");

                if (!dicUsedField.ContainsKey("remarks") || curValue == "remarks")
                dt.Rows.Add("remarks", "Remarks");

                kv.Value.DataSource = dt;
                kv.Value.DisplayMember = "name";
                kv.Value.ValueMember = "id";

                try
                {
                    kv.Value.SelectedValue = curValue;
                }
                catch { }
            }

            stopProcess = false;
        }

        ComboBox GetNewComboBox()
        {
            ComboBox cb = new ComboBox();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Rows.Add("0", "None");
            dt.Rows.Add("name", "Name");
            dt.Rows.Add("tel", "Tel");
            dt.Rows.Add("hometel", "Home Tel");
            dt.Rows.Add("mobiletel", "Mobile Tel");
            dt.Rows.Add("worktel", "Work Tel");
            dt.Rows.Add("email", "Email");
            dt.Rows.Add("fax", "Fax");
            dt.Rows.Add("address", "Address");
            dt.Rows.Add("remarks", "Remarks");
            cb.DataSource = dt;
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            return cb;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that the fields are matched correctly?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dicDataBind = new Dictionary<int, string>();
                foreach (KeyValuePair<int, ComboBox> kv in dicCombobox)
                {
                    if (kv.Value.SelectedIndex == 0)
                    { }
                    else
                    {
                        dicDataBind.Add(kv.Key, kv.Value.SelectedValue + "");
                    }
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
