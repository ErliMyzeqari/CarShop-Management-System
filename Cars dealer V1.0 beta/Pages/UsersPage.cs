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

namespace Cars_dealer_V1._0_beta.Pages
{
    public partial class UsersPage : UserControl
    {
        public UsersPage()
        {
            if (DesignTimeHelper.IsInDesignMode) return;
            InitializeComponent();
            LoadData();
        }


        void LoadData()
        {
            var records = Program.db.GetRecords<Data.Models.User>();
            grid.Rows.Clear();

            foreach (var user in records)
            {
             var r =    grid.Rows.Add(new object[] {
                    null,
                    user.FullName,
                    user.Initials,
                    user.email,
                    "****"
                });

                grid.Rows[r].Tag = user;
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            var user = new Data.Models.User();
            user.FullName = "Unknown";
            user.email = "";
            user.Initials = "";
            user.password = "";
            user.isAdmin = true;
            Program.db.Save(user);
            LoadData();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0) return;
            var user = (Data.Models.User)grid.CurrentRow.Tag;
            if (user.UserID == Program.currentUser.UserID)
            {
                MessageBox.Show("Cannot delete current user");
                return;
            }

            if(MessageBox.Show("Delete selected record?","CONFIRM!",MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
            {
                Program.db.Delete(user);
                LoadData();
            }
        }

        private void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var user = (Data.Models.User)grid.CurrentRow.Tag;
            var val = grid.CurrentCell.Value.ToString();
            if(e.ColumnIndex==1)
            {
                //NAME
                user.FullName = val;

            }
            else if (e.ColumnIndex == 2)
            {
                //INITIALS
                user.Initials = val;
            }
            else if (e.ColumnIndex == 3)
            {
                //EMAIL
                user.email = val;
            }
            else if (e.ColumnIndex == 4)
            {
                //PASSWORD
                if(val.Length>0 & !val.Contains("*")) user.password = val;
            
            }
            Program.db.Save(user);
        }
    }
}
