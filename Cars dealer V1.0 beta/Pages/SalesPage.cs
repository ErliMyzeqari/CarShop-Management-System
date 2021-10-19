using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;
using Data.Models;
using Cars_dealer_V1._0_beta.Forms;

namespace Cars_dealer_V1._0_beta.Pages
{
    public partial class SalesPage : UserControl
    {
        private frmDatePicker dateRange;
        private int totVehicles;
        private double totProfit;
        private double totBalance;
        private double actualProfit;

        public SalesPage()
        {
            if (DesignTimeHelper.IsInDesignMode) return;
            InitializeComponent();
            this.dateRange = new Forms.frmDatePicker();
            grid.RowHeadersVisible = true;
            LoadData();


        }


        void LoadData()
        {

            lbldate.Text = dateRange.startDate.Value.ToShortDateString() + " - " + dateRange.endDate.Value.ToShortDateString();

            int i = -1;
          
            grid.Rows.Clear();
            var records = Program.db.GetRecords<Data.Models.Vehicle>().Where(r=>r.HasReservations());
            //get sold cars

            records = records.Where(r => r.GetReservations().Where(rr => rr.Sold == true).Count() > 0);
            //filter dates
            records = records.Where(r=>
             
                DateTime.Parse(r.GetReservations().FirstOrDefault().DateSold).Date >= dateRange.startDate.Value.Date
                &&
                 DateTime.Parse(r.GetReservations().FirstOrDefault().DateSold).Date <= dateRange.endDate.Value.Date
             ); 


            if (txtSearch.Text.Trim().Length > 0)
            {
                switch (inputSearchBy.selectedIndex)
                {
                    case 0:
                        records = records.Where(r => r.GetModel().Name.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 1:
                        records = records.Where(r => r.Type.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 2:
                        records = records.Where(r => r.Version.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 3:
                        records = records.Where(r => r.Transmission.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 4:
                        records = records.Where(r => r.Year.ToString().ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 5:
                        records = records.Where(r => r.CC.ToString().ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 6:
                        records = records.Where(r => r.Color.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 7:
                        records = records.Where(r => r.Warranty.ToString().ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 8:
                        records = records.Where(r => r.Chassis.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 9:
                        records = records.Where(r => r.GetSeller().FullName.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 10:
                        records = records.Where(r => r.Internet.ToString().ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 11:
                        records = records.Where(r => r.VAT.ToString().ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                }


            }


            this.totVehicles = 0;
            this.totProfit = 0.0;
            this.totBalance = 0.0;
            this.actualProfit = 0.0;
            foreach (var vehicle in records)
            {
                var res = vehicle.GetReservations().FirstOrDefault();
                var client = res.GetClient();
                var seller = vehicle.GetSeller();
                var payments = res.GetPayments().Sum(r => r.Amount);
                var expenses = vehicle.GetExpenses().Sum(r => r.Amount);
                var total_cost = expenses + res.SellingPrice;
                var balance = (res.SellingPrice + expenses) - payments;
                var profit = res.SellingPrice - vehicle.Buying_Price;
                var row = grid.Rows.Add(new object[]{

                     imageList1.Images[0],
                     vehicle.GetReservations().FirstOrDefault().DateSold,
                     vehicle.GetModel().GetBrand().Name+" "+  vehicle.GetModel().Name+" "+ vehicle.CC  +"CC "+ vehicle.Chassis,
                     client.FirstName+" "+ client.LastName,
                     seller.FullName,
                     vehicle.Export_Price>0? "✔":"",
                     vehicle.VAT? "✔":"",
                     vehicle.forEnterprise? "✔":"",
                     vehicle.Buying_Price>0 ? vehicle.Buying_Price.ToString("N2") : null,
                     vehicle.Export_Price.ToString("N2"),
                     vehicle.Selling_Price.ToString("N2"),
                     res.SellingPrice.ToString("N2") , //selling price,
                     payments.ToString("N2"),//payments,
                     expenses.ToString("N2"),//expenses,
                     total_cost.ToString("N2"),//total cost
                     balance.ToString("N2"),//balance
                     profit.ToString("N2") ,//profit
                    });
                grid.Rows[row].Tag = vehicle;


                totVehicles++;
                totProfit += profit;
                totBalance += balance; 

            }

            lblVehicles.Text = totVehicles.ToString();
            lblBalance.Text = totBalance.ToString("N1");
            lblProfit.Text =  totProfit.ToString("N1"); 
            

            if (i >= 0 && grid.RowCount > i)
            {
                grid.CurrentRow.Cells[0].Selected = false;
                grid.Rows[i].Cells[0].Selected = true;
            }
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            new Helper.Popup.transparentBg(this.FindForm(), new Forms.frmStock());
            this.Cursor = Cursors.Default;
            LoadData();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printer.Clear();
            printer.AddImage(logo.Image, "width=150");
            printer.AddString("<h1>Sales List</h1>");

            printer.AddString("<h4>Sales from: <b>" + dateRange.startDate.Value.ToShortDateString() + "</b> to <b>" + dateRange.endDate.Value.ToShortDateString() + "</h4>");

            if (txtSearch.Text.Trim().Length > 0)
            {
                printer.AddString("<h4>Filters: <b>" + inputSearchBy.selectedValue + "</b> " + txtSearch.Text + "</h4>");
            }
             
            printer.AddHorizontalRule();

            DataTable dt = new DataTable();

            dt.Columns.Add("VEHICLES");
            dt.Columns.Add("TOTAL BALANCE");
            dt.Columns.Add("TOTAL PROFIT"); 

            dt.Rows.Add(new object[] { lblVehicles.Text,lblBalance.Text,lblProfit.Text});


            printer.AddDataTable(dt);

            printer.AddLineBreak();
            colImg.Visible = false;
            printer.AddDatagridView(grid);
            colImg.Visible = true;

            printer.ShowPrintPreviewDialog();

        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void InputSearchBy_onItemSelected(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (!(grid.CurrentRow.Index >= 0)) e.Cancel = true;
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex >= 0)) return;
            this.Cursor = Cursors.WaitCursor;
            new Helper.Popup.transparentBg(this.FindForm(), new Forms.frmStock((Vehicle)grid.CurrentRow.Tag));
            this.Cursor = Cursors.Default;
            LoadData();

        }

        private void BtnCSV_Click(object sender, EventArgs e)
        {
            SaveSCVDLG.ShowDialog();
        }

        private void SaveSCVDLG_FileOk(object sender, CancelEventArgs e)
        {
            Helper.ImportExportCSV.ExportToFile(grid, SaveSCVDLG.FileName);

        }

        private void InputFilter_onItemSelected(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > 0)) return;
            if (e.ColumnIndex == colVehicle.Index)
            {
                if (!(e.RowIndex >= 0)) return;
                this.Cursor = Cursors.WaitCursor;
                new Helper.Popup.transparentBg(this.FindForm(), new Forms.frmStock((Vehicle)grid.CurrentRow.Tag));
                this.Cursor = Cursors.Default;
                LoadData();
            }

            if (e.ColumnIndex == colClient.Index)
            {
                if (!(e.RowIndex >= 0)) return;
                this.Cursor = Cursors.WaitCursor;
                new Helper.Popup.transparentBg(this.FindForm(), new Forms.frmClient(((Vehicle)grid.CurrentRow.Tag).GetReservations().FirstOrDefault().GetClient()));
                this.Cursor = Cursors.Default;
                LoadData();
            }

            if (e.ColumnIndex == colSeller.Index)
            {
                if (!(e.RowIndex >= 0)) return;
                this.Cursor = Cursors.WaitCursor;
                new Helper.Popup.transparentBg(this.FindForm(), new Forms.frmSeller(((Vehicle)grid.CurrentRow.Tag).GetSeller()));
                this.Cursor = Cursors.Default;
                LoadData();
            }

        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            new Helper.Popup.transparentBg(this.FindForm(), dateRange);
            this.Cursor = Cursors.Default;
            if (dateRange.DialogResult == DialogResult.Yes) LoadData();

        }

        private void Lbldate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BtnFilter_Click(btnFilter, new EventArgs());
        }
    }
}
