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
    public partial class frmBrands : Form
    {
        public frmBrands()
        {
            InitializeComponent();

            foreach (Brand item in Program.db.GetRecords<Brand>())
            {
                var r = gridBrands.Rows.Add(new object[] {
                    item.Name
              });
                gridBrands.Rows[r].Tag = item;
            }
            GridBrands_SelectionChanged(null, null);
        }

        private void GridBrands_SelectionChanged(object sender, EventArgs e)
        {
            var brand = (Brand)gridBrands.CurrentRow.Tag;
            gridModels.Rows.Clear();
            if (brand == null) return;
            foreach (Model item in brand.GetModels())
            {
                var r = gridModels.Rows.Add(new object[] {
                    item.Name
              });
                gridModels.Rows[r].Tag = item;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton5_Click(object sender, EventArgs e)
        {
            var brand = Program.db.Save(new Brand() { Name = "", Country = "" });
            var r = gridBrands.Rows.Add();
            gridBrands.Rows[r].Tag = brand;
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (gridBrands.RowCount == 0) return;
            var brand = (Brand)gridBrands.CurrentRow.Tag;
            Model model = new Model() { BrandID = brand.BrandID };
            model = Program.db.Save(model);
            var r = gridModels.Rows.Add();
            gridModels.Rows[r].Tag = model;
        }

        private void GridBrands_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var brand = (Brand)gridBrands.CurrentRow.Tag;
            brand.Name = gridBrands.CurrentCell.Value?.ToString();
            gridBrands.CurrentRow.Tag = Program.db.Save(brand);
        }

        private void GridModels_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var model = (Model)gridModels.CurrentRow.Tag;
            model.Name = gridModels.CurrentCell.Value?.ToString();
            gridModels.CurrentRow.Tag = Program.db.Save(model);
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (gridBrands.RowCount == 0)
            {
                MessageBox.Show("Select a brand to delete");
                return;
            }
            var brand = (Brand)gridBrands.CurrentRow.Tag;
            if (brand.HasModels())
            {
                MessageBox.Show("Denied: The Brand has associated vehicle Models.");
                return;
            }

            if (MessageBox.Show("Delete Brand?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

                gridBrands.CurrentRow.Visible = !Program.db.Delete(brand);
            }
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (gridModels.RowCount == 0)
            {
                MessageBox.Show("Select a model to delete");
                return;
            }

            var model = (Model)gridModels.CurrentRow.Tag;
            if (model.HasVehicles())
            {
                MessageBox.Show("Denied: The model has associated vehicles.");
                return;
            }


            if (MessageBox.Show("Delete Model?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

                gridModels.CurrentRow.Visible = !Program.db.Delete(model);
            }
        }
    }
}
