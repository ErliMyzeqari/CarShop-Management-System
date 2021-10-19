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
    public partial class frmDatePicker : Form
    {
        public frmDatePicker()
        {
            InitializeComponent();


            startDate.Value = DateTime.Now;
            endDate.Value = DateTime.Now.AddDays(30);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
