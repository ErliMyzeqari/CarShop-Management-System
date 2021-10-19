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
    public partial class frmStock : Form
    {
        private Vehicle vehicle = null;
        private bool Sold;

        public frmStock(Vehicle vehicle = null)
        {
            this.vehicle = vehicle;
            InitializeComponent();
            inputSellingPrice.IconRight = imageList1.Images[0];
           
            txtReservation.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtReservation.AutoCompleteSource = AutoCompleteSource.CustomSource;


           // Reload(vehicle);

        }

        void Reload(Vehicle vehicle)
        {
            inputBrand.Clear();
            foreach (var brand in Program.db.GetRecords<Brand>())
            {
                inputBrand.AddItem(brand.Name);
                if (inputBrand.selectedIndex == -1) inputBrand.selectedIndex = 0;
            }
            inputSeller.Clear();
            foreach (var seller in Program.db.GetRecords<Seller>())
            {
                inputSeller.Items.Add(seller.FullName);
                if (inputSeller.selectedIndex == -1) inputSeller.selectedIndex = 0;
            }


            if (vehicle != null)
            {
                txtReservation.AutoCompleteCustomSource.Clear();
                txtReservation.PlaceholderText = $"Search {(vehicle.forEnterprise ? "enterprise" : "individual")} clients...";
                foreach (var client in Program.db.GetRecords<Client>().Where(r => r.Enterprise.Trim().Length > 0 == vehicle.forEnterprise))
                {
                    txtReservation.AutoCompleteCustomSource.Add(client.Email + " (" + client.FirstName + " " + client.LastName + ")");
                    txtReservation.AutoCompleteCustomSource.Add(client.Phone + " (" + client.FirstName + " " + client.LastName + ")");
                }
                lblTitle.Text = vehicle.GetModel().GetBrand().Name + " " + vehicle.GetModel().Name + " - " + vehicle.Chassis;
                btnDel.Visible = !(vehicle.HasExpenses() || vehicle.HasReservations());
                chkDemo.Checked = vehicle.Type == "Demo";
                chkOccassion.Checked = vehicle.Type == "Occasion";
                inputSeller.SelectedItem(vehicle.GetSeller().FullName);
                inputBrand.SelectedItem(vehicle.GetModel().GetBrand().Name);
                inputModel.SelectedItem(vehicle.GetModel().Name);
                inputFuelType.SelectedItem(vehicle.Fuel);

                inputYear.Text = vehicle.Year.ToString();
                inputVersion.Text = vehicle.Version.ToString();
                inputKM.Text = vehicle.KM.ToString();
                inputCC.Text = vehicle.CC.ToString();
                inputColor.Text = vehicle.Color;
                inputWarranty.Text = vehicle.Warranty.ToString();
                inputChassis.Text = vehicle.Chassis.ToString();
                chkAuto.Checked = vehicle.Transmission == "Automatic";
                chkManual.Checked = vehicle.Transmission == "Manual";
                chkInternet.Checked = vehicle.Internet;
                chkVat.Checked = vehicle.VAT;
                inputBuyingrice.Text = vehicle.Buying_Price.ToString();
                inputExportPrice.Text = vehicle.Export_Price.ToString();
                inputSellingPrice.Text = vehicle.Selling_Price.ToString();
                chkExport.Checked = vehicle.Export_Price > 0;
                chkEnterprises.Checked = vehicle.forEnterprise;
                inputFeatures.Text = vehicle.Features;
                inputKey.Text = vehicle.KeyNo;
                btnReservations.Visible =
                 btnExpenses.Visible = true;
                btnPayments.Visible = vehicle.HasReservations();

                if (vehicle.GetReservations().Count() == 0)
                {
                    //no reservation not sold
                    this.Sold = false;
                    btnReservations.Text = "Reserve";
                    txtReservation.Visible = true;
                    btnAddReservation.Visible = false;

                    pnlReserved.Visible = false;
                }
                else
                {

                    btnReservations.Text = "Reservations";
                    this.Sold = false;
                    btnEditReservation.Text = "Edit Reservation";
                    lblDatesoldLabel.Visible = lblDateSold.Visible = false;
                    pnlSold.Visible = true;

                    var reservation = vehicle.GetReservations().FirstOrDefault();

                    if (vehicle.GetReservations().Where(re => re.Sold == true).Count() > 0)
                    {
                        //sold
                        btnReservations.Text = "View Sale";
                        this.Sold = true;
                        btnEditReservation.Text = "Modify Sale";
                        lblDatesoldLabel.Visible = lblDateSold.Visible = true;
                        lblDateSold.Text = DateTime.Parse(reservation.DateSold).ToLongDateString();
                    }





                    if (!Sold && reservation.GetPayments().Count() == 0)
                    {
                        btnCancelReservation.Visible = true;
                    }
                    //reserved not soled
                    this.Sold = false;
                    lblFirstName.Text = reservation.GetClient().FirstName;
                    lblLastName.Text = reservation.GetClient().LastName;
                    txtDateReserved.Text = DateTime.Parse(reservation.DateReserved).ToLongDateString();
                    lblDueDate.Text = DateTime.Parse(reservation.DueDate).ToLongDateString();
                    lblSellingPrice.Text = reservation.SellingPrice.ToString("N2");
                    lblSold.Text = reservation.Sold ? "SOLD" : "RESERVED";

                    lblExpenses.Text = vehicle.GetExpenses().Select(r => r.Amount).Sum().ToString("N2");
                    lblPayments.Text = reservation.GetPayments().Select(r => r.Amount).Sum().ToString("N2");
                    lblSellingExpenses.Text = (reservation.SellingPrice + vehicle.GetExpenses().Select(r => r.Amount).Sum()).ToString("N2");
                    lblProfit.Text = ((reservation.SellingPrice + vehicle.GetExpenses().Select(r => r.Amount).Sum()) - vehicle.Buying_Price).ToString("N2");
                    lblBalance.Text = ((reservation.SellingPrice + vehicle.GetExpenses().Select(r => r.Amount).Sum()) - reservation.GetPayments().Select(r => r.Amount).Sum()).ToString("N2");
                    if (lblProfit.Text.Contains("-"))
                    {
                        lblProfit.ForeColor = Color.Crimson;
                    }
                    else
                    {
                        lblProfit.ForeColor = Color.SeaGreen;
                    }

                    if (reservation.Sold)
                    {
                        lblSold.ForeColor = Color.SeaGreen;
                    }
                    else
                    {
                        lblSold.ForeColor = Color.Crimson;
                    }

                    txtReservation.Visible = false;
                    btnAddReservation.Visible = false;

                    pnlReserved.Visible = true;

                    //payments
                    gridP.Rows.Clear();
                    gridP.RowHeadersVisible = true;
                    foreach (var payment in reservation.GetPayments())
                    {
                        var r = gridP.Rows.Add(
                            new object[]
                            {
                                DateTime.Parse( payment.Date).ToShortDateString(),
                                payment.PaidBy,
                                payment.Description,
                                payment.Amount
                            }
                            );
                        gridP.Rows[r].Tag = payment;
                    }

                    lblTotPayment.Text = reservation.GetPayments().Select(R => R.Amount).Sum().ToString("N2");


                    //expenses
                    gridE.Rows.Clear();
                    gridE.RowHeadersVisible = true;
                    foreach (var expense in vehicle.GetExpenses())
                    {
                        var r = gridE.Rows.Add(
                            new object[]
                            {
                                DateTime.Parse( expense.Date).ToShortDateString(),
                                expense.Description,
                                expense.Amount
                            }
                            );
                        gridE.Rows[r].Tag = expense;
                    }

                    lblTotExpenses.Text = vehicle.GetExpenses().Select(R => R.Amount).Sum().ToString("N2");




                }

            }
            else
            {
                lblTitle.Text = "Add Stock";
                btnDel.Visible =
              btnReservations.Visible =
                btnExpenses.Visible =
                 btnPayments.Visible = false;
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
            txtReservation.Text = "";
        }

        private void InputBrand_onItemSelected(object sender, EventArgs e)
        {

            inputModel.Clear();
            var brand = Program.db.GetRecords<Brand>().ToList()[inputBrand.selectedIndex];
            foreach (var model in brand.GetModels())
            {
                inputModel.AddItem(model.Name);
                if (inputModel.selectedIndex == -1) inputModel.selectedIndex = 0;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!Helper.CustomTextbox.ValidateContainer(tabPage1))
            {
                Bunifu.Snackbar.Show(this, "Validation error.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            if (inputExportPrice.Text.Trim().Length == 0) inputExportPrice.Text = "0";
            if (inputSellingPrice.Text.Trim().Length == 0) inputSellingPrice.Text = "0";

            if (vehicle == null) { vehicle = new Vehicle() { CreatedBy = Program.currentUser.UserID}; }

            vehicle.Buying_Price = Double.Parse(inputBuyingrice.Text.Trim());
            vehicle.CC = int.Parse(inputCC.Text.Trim());
            vehicle.Chassis = inputChassis.Text.Trim();
            vehicle.Color = inputColor.Text.Trim();
            vehicle.Export_Price = double.Parse(inputExportPrice.Text.Trim());
            vehicle.Fuel = inputFuelType.selectedValue;
            vehicle.Selling_Price = double.Parse(inputSellingPrice.Text.Trim());
            vehicle.Internet = chkInternet.Checked;
            vehicle.KM = int.Parse(inputKM.Text.Trim());
            vehicle.ModelID = Program.db.GetRecords<Brand>().ToList()[inputBrand.selectedIndex].GetModels().ToList()[inputModel.selectedIndex].ModelID;
            vehicle.SellerID = Program.db.GetRecords<Seller>().ToList()[inputSeller.selectedIndex].SellerID;
            vehicle.Transmission = chkAuto.Checked ? "Automatic" : "Manual";
            vehicle.Type = chkDemo.Checked ? "Demo" : "Occasion";
            vehicle.VAT = chkVat.Checked;
            vehicle.Version = inputVersion.Text.Trim();
            vehicle.Warranty = int.Parse(inputWarranty.Text.Trim());
            vehicle.Year = int.Parse(inputYear.Text.Trim());
            vehicle.Features = inputFeatures.Text.Trim();
            vehicle.KeyNo = inputKey.Text;
            vehicle.forEnterprise = chkEnterprises.Checked;

            vehicle = Program.db.Save(vehicle);


            //   Bunifu.Snackbar.Show(this, "Saved.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);

            Reload(vehicle);
        }

        private void ChkExport_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkExport.Checked)
            {
                inputExportPrice.Enabled = true;
                inputExportPrice.IconRight = null;

            }
            else
            {
                inputExportPrice.Text = "";
                inputExportPrice.Enabled = false;
                inputExportPrice.IconRight = imageList1.Images[0];

            }

        }

        private void ChkIndividal_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {


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
            chkDemo.Checked = chkAuto.Checked = true;
            chkOccassion.Checked = chkManual.Checked = false;

            inputSeller.selectedIndex = inputBrand.selectedIndex = inputFuelType.selectedIndex = 0;

            inputYear.Text =
               inputVersion.Text =
               inputKM.Text =
               inputCC.Text =
               inputColor.Text =
               inputWarranty.Text =
               inputChassis.Text =
               inputBuyingrice.Text =
               inputExportPrice.Text =
               inputSellingPrice.Text =
                inputKey.Text =
               inputFeatures.Text = string.Empty;
        }

        private void BtnAddReservation_Click(object sender, EventArgs e)
        {
            inputYear.Text = "Hello world";
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            Reload(vehicle);
        }

        private void BtnExpenses_Click(object sender, EventArgs e)
        {
            pages.SetPage(2);
            indicator.Left = btnExpenses.Left;
            indicator.Width = btnExpenses.Width;
        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            pages.SetPage(3);
            indicator.Left = btnPayments.Left;
            indicator.Width = btnPayments.Width;
        }

        private void TxtReservation_TextChanged(object sender, EventArgs e)
        {
            btnAddReservation.Visible = false;

        }

        private void TxtReservation_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtReservation.Text.Contains(" ("))
            {
                var srch = txtReservation.Text.Substring(0, txtReservation.Text.IndexOf(" (")).Trim();
                var found = Program.db.GetRecords<Client>("phone LIKE '" + srch + "' OR email LIKE '" + srch + "'");

                btnAddReservation.Visible = found?.Count() > 0;


            }
        }

        private void BtnAddReservation_Click_1(object sender, EventArgs e)
        {
            var srch = txtReservation.Text.Substring(0, txtReservation.Text.IndexOf(" (")).Trim();
            var found = Program.db.GetRecords<Client>("phone LIKE '" + srch + "' OR email LIKE '" + srch + "'");
            if (found?.Count() > 0)
            {
                var client = found.FirstOrDefault();

                new Helper.Popup.transparentBg(this.FindForm(), new frmReservation(vehicle, client));
                Reload(vehicle);
            }
        }

        private void BtnEditReservation_Click(object sender, EventArgs e)
        {
            new Helper.Popup.transparentBg(this.FindForm(), new frmReservation(vehicle.GetReservations().FirstOrDefault()));
            Reload(vehicle);
        }

        private void BtnCancelReservation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel Reservation?", null, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Program.db.Delete(vehicle.GetReservations().FirstOrDefault());

                Reload(vehicle);
            }
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {


            var reservation = vehicle.GetReservations().FirstOrDefault();
            var client = reservation.GetClient();

            Payment payment = new Payment()
            {
                Amount = 0,
                Date = DateTime.Now.ToShortDateString(),
                Description = "",
                Notes = "",
                PaidBy = client.FirstName + " " + client.LastName,
                ReservationID = reservation.ReservatonID,
                ReceivedBy = Program.currentUser.UserID
            };
            Program.db.Save(payment);
            Reload(vehicle);
        }

        private void GridP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var value = gridP.CurrentCell.Value.ToString();
            if (value.Trim().Length == 0) return;
            var payment = (Payment)gridP.CurrentRow.Tag;
            if (e.ColumnIndex == colDate.Index)
            {
                try
                {
                    payment.Date = DateTime.Parse(value).ToShortDateString();
                }
                catch (Exception)
                {
                    gridP.CurrentCell.Value = payment.Date;
                }
            }
            else if (e.ColumnIndex == colPaidBy.Index)
            {
                try
                {
                    payment.PaidBy = value;
                }
                catch (Exception)
                {
                    gridP.CurrentCell.Value = payment.PaidBy;
                }
            }
            else if (e.ColumnIndex == colDescriptin.Index)
            {
                try
                {
                    payment.Description = value;
                }
                catch (Exception)
                {
                    gridP.CurrentCell.Value = payment.Description;
                }
            }
            else if (e.ColumnIndex == colAmount.Index)
            {
                try
                {
                    payment.Amount = double.Parse(value.Replace(",", ""));
                }
                catch (Exception)
                {
                }
                gridP.CurrentCell.Value = payment.Amount.ToString("N0");
            }

            gridP.CurrentRow.Tag = Program.db.Save(payment);
            lblTotPayment.Text = payment.GetReservation().GetPayments().Select(R => R.Amount).Sum().ToString("N2");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //get selected itea
            if (gridP.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Delete Payment?", "", MessageBoxButtons.YesNoCancel) != DialogResult.Yes) return;

            var payment = (Payment)gridP.CurrentRow.Tag;
            Program.db.Delete(payment);
            Reload(vehicle);

        }

        private void SaveSCVDLG_FileOk(object sender, CancelEventArgs e)
        {
            if (pages.SelectedIndex==2)
            {
                Helper.ImportExportCSV.ExportToFile(gridP, SaveSCVDLG.FileName);
            }
            else
            {
                Helper.ImportExportCSV.ExportToFile(gridE, SaveSCVDLG.FileName);
            }
        }

        private void BtnCSV_Click(object sender, EventArgs e)
        {
            SaveSCVDLG.ShowDialog();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printer.Clear();
            var cleint = vehicle.GetReservations().FirstOrDefault().GetClient();
            printer.AddString("<h1>Received Payments</h1>");

            printer.AddString("<h4>Vehicle: <b>" + vehicle.GetModel().GetBrand().Name + " " + vehicle.GetModel().Name + " " + vehicle.Chassis + "</b>");
            printer.AddString("<h4>Client: <b>" + cleint.FirstName + " " + cleint.LastName + "</b>");

            printer.AddHorizontalRule();
            printer.AddDatagridView(gridP);

            printer.ShowPrintPreviewDialog();
        }

        private void BunifuImageButton5_Click(object sender, EventArgs e)
        {


            Expens expense = new Expens()
            {
                Amount = 0,
                Date = DateTime.Now.ToShortDateString(),
                Description = "",
                VehicleID = vehicle.VehicleID,
                Notes = "",
                CreatedBy=Program.currentUser.UserID
            };
            Program.db.Save(expense);
            Reload(vehicle);
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            //get selected itea
            if (gridE.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Delete Epense?", "", MessageBoxButtons.YesNoCancel) != DialogResult.Yes) return;

            var expense = (Expens)gridE.CurrentRow.Tag;
            Program.db.Delete(expense);
            Reload(vehicle);
        }

        private void GridE_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var value = gridE.CurrentCell.Value.ToString();
            if (value.Trim().Length == 0) return;

            var expense = (Expens)gridE.CurrentRow.Tag;
            if (e.ColumnIndex == colDateE.Index)
            {
                try
                {
                    expense.Date = DateTime.Parse(value).ToShortDateString();
                }
                catch (Exception)
                {
                    gridE.CurrentCell.Value = expense.Date;
                }
            }

            else if (e.ColumnIndex == colDescE.Index)
            {
                try
                {
                    expense.Description = value;
                }
                catch (Exception)
                {
                    gridE.CurrentCell.Value = expense.Description;
                }
            }
            else if (e.ColumnIndex == colAmountE.Index)
            {
                try
                {
                    expense.Amount = double.Parse(value.Replace(",", ""));
                }
                catch (Exception)
                {
                }
                gridE.CurrentCell.Value = expense.Amount.ToString("N0");
            }

            gridE.CurrentRow.Tag = Program.db.Save(expense);
            lblTotExpenses.Text = vehicle.GetExpenses().Select(R => R.Amount).Sum().ToString("N2");

        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            Reload(vehicle);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Vehicle?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

                Program.db.Delete(vehicle);
                MessageBox.Show("Deleted");
                this.Close();
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Helper.Popup.transparentBg(this.FindForm(), new frmBrands());
            Reload(vehicle);
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Helper.Popup.transparentBg(this.FindForm(), new frmBrands());
            Reload(vehicle);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Helper.Popup.transparentBg(this.FindForm(), new Forms.frmClient());
            Reload(vehicle);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            printer.Clear();
            var cleint = vehicle.GetReservations().FirstOrDefault().GetClient();
            printer.AddString("<h1>Expenses</h1>");

            printer.AddString("<h4>Vehicle: <b>" + vehicle.GetModel().GetBrand().Name + " " + vehicle.GetModel().Name + " " + vehicle.Chassis + "</b>");
          
            printer.AddHorizontalRule();
            printer.AddDatagridView(gridP);

            printer.ShowPrintPreviewDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            SaveSCVDLG.ShowDialog();
        }
    }
}
