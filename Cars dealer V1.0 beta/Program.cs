//MicronConfig config = new MicronConfig()
//{
//    DatabaseName = "car_dealer"
//}
using Data.Models;
using Micron;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_dealer_V1._0_beta
{
    static class Program
    {

        public static Micron.MicronDbContext db;
        internal static User currentUser;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var Data = Newtonsoft.Json.Linq.JObject.Parse(System.IO.File.ReadAllText("Config.json"));
            MicronConfig config = new MicronConfig()
            {
                DatabaseName = Data["database"].ToString(),
                Host = Data["host"].ToString(),
                Password = Data["password"].ToString(),
                Port = Data["port"].ToString(),
                User = Data["user"].ToString(),
            };

            MicronDbContext.AddConnectionSetup(config);

            db = new Micron.MicronDbContext();
          

            Program.db.DebugMode = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
