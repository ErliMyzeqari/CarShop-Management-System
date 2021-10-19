using Cars_dealer_V1._0_beta.Helper;
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
    public partial class frmClient : Form
    {
        private Client client = null;

        public frmClient(Client client = null)
        {
            this.client = client;
            InitializeComponent();



        }

        void Reload(Client client)
        {

            if (client != null)
            {
                lblTitle.Text = client.FirstName + " " + client.LastName;
                btnDel.Visible = !(client.HasReservations());
                inputFirstName.Text = client.FirstName;
                inputLastName.Text = client.LastName;
                inputAddress.Text = client.Address;
                inputPhone.Text = client.Phone;
                inputEmail.Text = client.Email;
                chkContactByPhone.Checked = client.ContactByPhone;
                chkContactByEmail.Checked = client.ContactByEmail;
                pnlEnterprise.Enabled = optEnterprise.Checked = client.Enterprise.Trim().Length > 0;
                optIndividul.Checked = client.Enterprise.Trim().Length == 0;
                inputEnterprise.Text = client.Enterprise;
                inputVAT.Text = client.VAT.ToString();
                inputFAX.Text = client.FAX;
                inputNotes.Text = client.Notes;
                //btnReservations.Visible = true;

            }
            else
            {
                lblTitle.Text = "Add Client";

            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStock_Shown(object sender, EventArgs e)
        {
            //avoid flicker
            this.Opacity = 1;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!Helper.CustomTextbox.ValidateContainer(tabPage1))
            {
                Bunifu.Snackbar.Show(this, "Validation error.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            if (!inputVAT.Enabled) inputVAT.Text = 0.ToString();


            if (client == null) { client = new Client(); }

            client.FirstName = inputFirstName.Text;
            client.LastName = inputLastName.Text;
            client.Address = inputAddress.Text;
            client.Phone = inputPhone.Text;
            client.Email = inputEmail.Text;
            client.ContactByPhone = chkContactByPhone.Checked;
            client.ContactByEmail = chkContactByEmail.Checked;

            client.Enterprise = inputEnterprise.Text;
            client.VAT = double.Parse(inputVAT.Text);
            client.FAX = inputFAX.Text;
            client.Notes = inputNotes.Text;

            client = Program.db.Save(client); 

            //   Bunifu.Snackbar.Show(this, "Saved.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);

            Reload(client);
        }



        private void BtnReservations_Click(object sender, EventArgs e)
        {
            pages.SetPage(0);
            indicator.Left = btnVehicle.Left;
            indicator.Width = btnVehicle.Width;
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            pages.SetPage(1);
            indicator.Left = btnReservations.Left;
            indicator.Width = btnReservations.Width;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in tabPage1.Controls.OfType<CustomTextbox>().ToList())
            {
                ctrl.Text = "";
            }
            chkContactByEmail.Checked = chkContactByPhone.Checked = true;
            optEnterprise.Checked = false;
            optIndividul.Checked = true;
            pnlEnterprise.Enabled = false;
        }


        private void FrmStock_Load(object sender, EventArgs e)
        {
            Reload(client);
        }

        private void OptEnterprise_Click(object sender, EventArgs e)
        {
            pnlEnterprise.Enabled = optEnterprise.Checked;
        }

        private void OptIndividul_Click(object sender, EventArgs e)
        {
            pnlEnterprise.Enabled = optEnterprise.Checked;
            inputEnterprise.Text = "";
            inputFAX.Text = "";
            inputVAT.Text = "";
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            Reload(client);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Client?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

                Program.db.Delete(client);
                MessageBox.Show("Deleted");
                this.Close();
            }
        }
    }
}
