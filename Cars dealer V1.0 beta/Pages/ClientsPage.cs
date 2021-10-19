﻿using System;
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
    public partial class ClientsPage : UserControl
    {
        public ClientsPage()
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
            var records = Program.db.GetRecords<Data.Models.Client>();

            if(txtSearch.Text.Trim().Length>0)
            {
                switch(inputSearchBy.selectedIndex)
                {
                    case 0:
                        records = records.Where(r => r.FirstName.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 1:
                        records = records.Where(r => r.LastName.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 2:
                        records = records.Where(r => r.Address.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 3:
                        records = records.Where(r => r.Phone.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 4:
                        records = records.Where(r => r.Email.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                    case 5:
                        records = records.Where(r => r.Enterprise.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                  
                    case 6:
                        records = records.Where(r => r.FAX.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
                        break;
                }


            }


            foreach (var client in records)
            {
                var r = grid.Rows.Add(new object[]{
                    client.FirstName,
                    client.LastName,
                    client.Address,
                    client.Phone,
                    client.Email,
                    client.ContactByPhone,
                    client.ContactByEmail,
                     client.Enterprise,
                     client.VAT,
                     client.FAX
                    });
                grid.Rows[r].Tag = client;
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
            new Helper.Popup.transparentBg(this.FindForm(), new Forms.frmClient());
            this.Cursor = Cursors.Default;
            LoadData();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printer.Clear();
            printer.AddImage(logo.Image, "width=150");
            printer.AddString("<h1>Client List</h1>");

            if (txtSearch.Text.Trim().Length>0)
            {
                printer.AddString("<h4>Filters: <b>"+inputSearchBy.selectedValue+"</b> "+txtSearch.Text+"</h4>"); 
            }

            printer.AddHorizontalRule();
            printer.AddDatagridView(grid);


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
            if (!(grid.CurrentRow.Index>=0)) e.Cancel = true;
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex >= 0)) return;
            this.Cursor = Cursors.WaitCursor;
            new Helper.Popup.transparentBg(this.FindForm(), new Forms.frmClient((Client)grid.CurrentRow.Tag));
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
    }
}
