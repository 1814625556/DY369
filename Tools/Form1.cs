using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInstall_Click(object sender, EventArgs e)
        {
            ServiceHelper.Install(this.ServicePathTxt.Text.Trim());
        }

        private void BtnUnInstall_Click(object sender, EventArgs e)
        {
            ServiceHelper.Uninstall(this.ServicePathTxt.Text.Trim());
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            ServiceHelper.Start("");
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            ServiceHelper.Stop("");
        }
    }
}
