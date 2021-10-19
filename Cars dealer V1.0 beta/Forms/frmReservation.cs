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
    public partial class frmReservation : Form
    {
        private readonly Vehicle vehicle;
        private readonly Client client;
        private Reservation reservation;

        public frmReservation(Vehicle vehicle, Client client)
        {
            this.vehicle = vehicle;
            this.client = client;
            InitializeComponent();

            lblVehicle.Text = vehicle.GetModel().GetBrand().Name + " " + vehicle.GetModel().Name + " " + vehicle.Chassis;
            lblClient.Text = client.FirstName + " " + client.LastName + " (" + client.Email + ")";

            txtDateReserved.Value = DateTime.Now;
            txtDueDate.Value = DateTime.Now.AddDays(30);

            txtSellingPrice.Text = vehicle.Selling_Price.ToString();
           

            

        }

        public frmReservation(Reservation reservation)
        {
            this.reservation = reservation;
            this.vehicle = reservation.GetVehicle();
            this.client = reservation.GetClient();
            InitializeComponent();

           lblTitle.Text =   lblVehicle.Text = vehicle.GetModel().GetBrand().Name + " " + vehicle.GetModel().Name + " " + vehicle.Chassis;
            lblClient.Text = client.FirstName + " " + client.LastName + " (" + client.Email + ")";
            txtDateReserved.Value = DateTime.Parse(reservation.DateReserved);
            txtDueDate.Value = DateTime.Parse(reservation.DueDate);
            txtSellingPrice.Text = reservation.SellingPrice.ToString();
            chkSold.Value = reservation.Sold;
            inputNotes.Text = reservation.Notes;
            if (reservation.Sold) txtDateSold.Value = DateTime.Parse(reservation.DateSold);
             
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddReservation_Click(object sender, EventArgs e)
        {
            if (txtSellingPrice.Text.Trim().Length == 0) txtSellingPrice.Text = "0";

            if (!Helper.CustomTextbox.ValidateContainer(this))
            {
                Bunifu.Snackbar.Show(this, "Validation error.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            if (reservation == null)
            {
                reservation = new Reservation() { ReservedBy = Program.currentUser.UserID};
            }

            reservation.ClientID = client.ClientID;
            reservation.VehicleID = vehicle.VehicleID;
            reservation.DateReserved = txtDateReserved.Value.ToShortDateString();
            reservation.DueDate = txtDueDate.Value.ToShortDateString();
            reservation.Notes = inputNotes.Text;
            reservation.SellingPrice = double.Parse(txtSellingPrice.Text.Trim());
            reservation.Sold = chkSold.Value;
            reservation.DateSold = txtDateSold.Value.ToShortDateString();



            Program.db.Save(reservation);
            MessageBox.Show("Saved");
        }

        private void LblClient_Click(object sender, EventArgs e)
        {
            new Helper.Popup.transparentBg(this.FindForm(), new frmClient(client));
        }

        private void ChkSold_OnValuechange(object sender, EventArgs e)
        {
            lblDateSold.Visible = txtDateSold.Visible = chkSold.Value;

        }
    }
}
