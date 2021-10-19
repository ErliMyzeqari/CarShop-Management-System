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

namespace Cars_dealer_V1._0_beta.Pages
{
    public partial class StocksPage : UserControl
    {
        public StocksPage()
        {
            if (DesignTimeHelper.IsInDesignMode) return;
            InitializeComponent();
            grid.RowHeadersVisible = true;
            LoadData();
        }


        void LoadData()
        {
            int i = -1;
          

            grid.Rows.Clear();
            var records = Program.db.GetRecords<Data.Models.Vehicle>();
            //exlude sold cars
            records = records.Where(r => r.GetReservations().Where(rr => rr.Sold == true).Count() == 0);

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


            if (inputFilter.selectedIndex == 1)
            {
                records = records.Where(r => r.HasReservations() == false);
            }
            else if (inputFilter.selectedIndex == 2)
            {
                records = records.Where(r => r.GetReservations().Where(rr => rr.Sold == false).Count() > 0);
            }



            foreach (var vehicle in records)
            {
                var r = grid.Rows.Add(new object[]{
                    (
                     vehicle.HasReservations() ? (vehicle.GetReservations().FirstOrDefault().Sold ? imageList1.Images[0]:imageList1.Images[1]) : imageList1.Images[2]),
                     vehicle.KeyNo,
                     vehicle.Type,
                     vehicle.GetModel().Name,
                     vehicle.GetModel().GetBrand().Name,
                     vehicle.Version,
                     vehicle.Transmission,
                     vehicle.Year,
                     vehicle.CC,
                     vehicle.Color,
                     vehicle.Warranty,
                     vehicle.Chassis,
                     vehicle.GetSeller().FullName,
                     vehicle.Internet? "✔":"",
                     vehicle.VAT? "✔":"",
                     vehicle.forEnterprise? "✔":"",
                     vehicle.Buying_Price>0 ? vehicle.Buying_Price.ToString("N2") : null,
                     vehicle.Export_Price.ToString("N2"),
                     vehicle.Selling_Price.ToString("N2")
                    });
                grid.Rows[r].Tag = vehicle;


                grid.Rows[r].Cells[0].ToolTipText = (vehicle.HasReservations() ? (vehicle.GetReservations().FirstOrDefault().Sold ? "Sold" : "Reserved") : "Available");
            }
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
            Control btnSender = (Control)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip1.Show(ptLowerLeft);

           
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
            if (e.ColumnIndex == colSeller.Index)
            {
                if (!(e.RowIndex >= 0)) return;
                this.Cursor = Cursors.WaitCursor;
                new Helper.Popup.transparentBg(this.FindForm(), new Forms.frmSeller(((Vehicle)grid.CurrentRow.Tag).GetSeller()));
                this.Cursor = Cursors.Default;
                LoadData();
            }

        }

        private void PrintListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printer.Clear();
            printer.AddImage(logo.Image, "width=150");
            if (inputFilter.selectedIndex > 0)
            {
                printer.AddString($"<h1>{inputFilter.selectedValue} Vehicles</h1>");
            }
            else
            {
                printer.AddString("<h1>Stock List</h1>");
            }
            if (txtSearch.Text.Trim().Length > 0)
            {
                printer.AddString("<h4>Filters: <b>" + inputSearchBy.selectedValue + "</b> " + txtSearch.Text + "</h4>");
            }

            printer.AddHorizontalRule();
            colImg.Visible = false;
            printer.AddDatagridView(grid);
            colImg.Visible = true;

            printer.ShowPrintPreviewDialog();
        }

        private void GenerateStickersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printer.Clear();
            DataTable dt = new DataTable();
            dt.Columns.Add(" ");
            dt.Columns.Add("  ");



            foreach (DataGridViewRow row in grid.Rows)
            {
                dt.Rows.Clear();
                var vehicle = (Vehicle)row.Tag;

                printer.AddLineBreak();
                if (vehicle.Export_Price > 0) printer.AddString($"<div align='center'> <p style=\"font-size:70px;color:crimson\">EXPORT</p></div>");
                printer.AddString($"<h1  align='center'>{vehicle.GetModel().GetBrand().Name.ToUpper()} {vehicle.GetModel().Name.ToUpper()}</h1>");
                printer.AddHorizontalRule();
                printer.AddString("<div style='width:70%;margin-left:20%;'>");
                printer.AddString($"<h2>Engine Capacity: <span style='float:right;margin-top:-25'>{vehicle.CC}</span></h2>");
                printer.AddString($"<h2>Transmission: <span style='float:right;margin-top:-25'>{vehicle.Transmission}</span></h2>");
                printer.AddString($"<h2>KM: <span style='float:right;margin-top:-25'>{vehicle.KM}</span></h2>");
                printer.AddString($"<h2>Year: <span style='float:right;margin-top:-25'>{vehicle.Year}</span></h2>");
                printer.AddString($"<h2>Warranty: <span style='float:right;margin-top:-25'>{vehicle.Warranty}</span></h2>");
                printer.AddString($"<h2>KEY No: <span style='float:right;margin-top:-25'>{vehicle.KeyNo}</span></h2>");

                if (vehicle.Features.Trim().Length > 0)
                {
                    printer.AddLineBreak();
                    printer.AddString($"<h2><u>Options/Features</u></h2>");
                    printer.AddString($"<h3>{vehicle.Features}</h3>");
                }
                printer.AddString("</div>");

                printer.AddLineBreak();
                printer.AddLineBreak();
                printer.AddHorizontalRule();
                printer.AddString($"<div align='center'> <p style=\"font-size:120px\">{vehicle.Buying_Price.ToString("C2")}</p></div>");
                printer.AddHorizontalRule();


                if (row.Index < grid.RowCount - 1) printer.NewPage();

            }

            printer.ShowPrintPreviewDialog();
        }
    }
}
