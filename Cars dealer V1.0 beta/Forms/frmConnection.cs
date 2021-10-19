using Micron;
using Newtonsoft.Json.Linq;
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
    public partial class frmConnection : Form
    {
        private JObject Data;

        public frmConnection()
        {
            this.Data = JObject.Parse(System.IO.File.ReadAllText("Config.json"));
            InitializeComponent();

          


        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!Helper.CustomTextbox.ValidateContainer(this))
            {
                Bunifu.Snackbar.Show(this, "Validation error.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                return;
            }

            Data["host"] = txtHost.Text;
            Data["database"] = txtDatabase.Text;
            Data["port"] = txtPort.Text;
            Data["user"] = txtUser.Text;
            Data["password"] = txtPassword.Text;

            MicronConfig config = new MicronConfig()
            {
                DatabaseName = Data["database"].ToString(),
                Host = Data["host"].ToString(),
                Password = Data["password"].ToString(),
                Port = Data["port"].ToString(),
                User = Data["user"].ToString(),
            };

            MicronDbContext.setups.Clear();
            MicronDbContext.AddConnectionSetup(config);

            var db = new Micron.MicronDbContext();

            if (db.GetMySQLConnection().State == System.Data.ConnectionState.Closed)
            {
                MessageBox.Show("Connection to the Host failed.");
                return;
            }

            System.IO.File.WriteAllText("Config.json", Data.ToString());
            Program.db = db;
            MessageBox.Show("Changes saved");
        }

        private void FrmConnection_Shown(object sender, EventArgs e)
        {
            txtHost.Text = Data["host"].ToString();
            txtDatabase.Text = Data["database"].ToString();
            txtPort.Text = Data["port"].ToString();
            txtUser.Text = Data["user"].ToString();
            txtPassword.Text = Data["password"].ToString();
        }
    }
}
