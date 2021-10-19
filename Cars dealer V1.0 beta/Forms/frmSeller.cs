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
    public partial class frmSeller : Form
    {
        private Seller seller = null;

        public frmSeller(Seller seller = null)
        {
            this.seller = seller;
            InitializeComponent();



        }

        void Reload(Seller seller)
        {

            if (seller != null)
            {
                inputFirstName.Text =  lblTitle.Text = seller.FullName;

                btnDel.Visible = !(seller.HasVehicles());
                  
                inputAddress.Text = seller.Address;
                inputPhone.Text = seller.Phone;
                inputEmail.Text = seller.Email;
                chkContactByPhone.Checked = seller.ContactByPhone;
                chkContactByEmail.Checked = seller.ContactByEmail;
                pnlEnterprise.Enabled = optEnterprise.Checked = seller.isEnterprise;
                optIndividul.Checked = !seller.isEnterprise; 
                inputVAT.Text = seller.VAT.ToString();
                inputFAX.Text = seller.FAX;
                inputNotes.Text = seller.Notes; 

            }
            else
            {
                lblTitle.Text = "Add Seller";
                btnDel.Visible = false;
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

            if (seller == null) { seller = new Seller(); }

            seller.FullName = inputFirstName.Text; 
            seller.Address = inputAddress.Text;
            seller.Phone = inputPhone.Text;
            seller.Email = inputEmail.Text;
            seller.ContactByPhone = chkContactByPhone.Checked;
            seller.ContactByEmail = chkContactByEmail.Checked;

            seller.isEnterprise = optEnterprise.Checked;
            seller.VAT = double.Parse(inputVAT.Text);
            seller.FAX = inputFAX.Text;
            seller.Notes = inputNotes.Text;

            seller = Program.db.Save(seller);


            //   Bunifu.Snackbar.Show(this, "Saved.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);

            Reload(seller);
        }



        private void BtnReservations_Click(object sender, EventArgs e)
        {
            pages.SetPage(0);
            indicator.Left = btnVehicle.Left;
            indicator.Width = btnVehicle.Width;
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
            Reload(seller);
        }

        private void OptEnterprise_Click(object sender, EventArgs e)
        {
            pnlEnterprise.Enabled = optEnterprise.Checked;
        }

        private void OptIndividul_Click(object sender, EventArgs e)
        {
            pnlEnterprise.Enabled = optEnterprise.Checked;
             
            inputFAX.Text = "";
            inputVAT.Text = "";
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            Reload(seller);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Seller?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

                Program.db.Delete(seller);
                MessageBox.Show("Deleted");
                this.Close();
            }
        }
    }
}
