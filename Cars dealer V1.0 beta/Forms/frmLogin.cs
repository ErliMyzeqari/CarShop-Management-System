using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_dealer_V1._0_beta.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!Helper.CustomTextbox.ValidateContainer(this))
            {
                Bunifu.Snackbar.Show(this, "Validation error.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            var user = Program.db.GetRecord<User>($"email LIKE '{txtEmail.Text}' AND password like '{txtPassw.Text}'");

            if(user==null)
            {
                Bunifu.Snackbar.Show(this, "Invalid credentials, Contact Admin.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            Program.currentUser = user;
            this.Close();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            new Helper.Popup.transparentBg(this, new Forms.frmConnection());
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {

            txtEmail.Text = "erlimyzeqari5@gmail.com";
            txtPassw.Text = "12345";
            if (Program.db.GetMySQLConnection().State == System.Data.ConnectionState.Closed)
            {
                MessageBox.Show("Could not connect to Host");
                new Helper.Popup.transparentBg(this, new Forms.frmConnection());
            }
        }
    }
}
