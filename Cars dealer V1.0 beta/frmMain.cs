using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_dealer_V1._0_beta
{
    public partial class frmMain : Form
    {
        public frmMain()
        {

            new Forms.frmLogin().ShowDialog();
            InitializeComponent();

            lblUsername.Text = Program.currentUser.FullName;
            lblUserType.Text = Program.currentUser.isAdmin? "Admin": "User";
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            var btn = (Control)sender;
            indicator.Top = btn.Top;
              pages.SetPage(btn.Text.Trim());
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
    }
}
