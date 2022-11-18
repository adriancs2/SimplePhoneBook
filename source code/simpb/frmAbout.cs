using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimPB
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            this.Icon = config.AppIcon;
            lbVersion.Text += config.AppVersion;
        }
    }
}
