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
using System.Globalization;

namespace Cars_dealer_V1._0_beta.Pages
{
    public partial class ReportsPage : UserControl
    {
        public ReportsPage()
        {
            if (DesignTimeHelper.IsInDesignMode) return;
            InitializeComponent();
            date.Value = DateTime.Now;
        }

        private void report1_Click(object sender, EventArgs e)
        {
            printer.Clear();
            printer.AddImage(logo.Image, "width=150");
            printer.AddString($"<h3> {date.Value.ToString("MMMM", CultureInfo.InvariantCulture)} {date.Value.Year} Daily Report</h3>");

            DataTable table = new DataTable();
            table.Columns.Add("Day");
            table.Columns.Add("Sales");
            table.Columns.Add("Reservations");
            table.Columns.Add("Total Expenses");
            table.Columns.Add("Total Income");
            table.Columns.Add("Balance");

            for (int i = 1; i < 31; i++)
            {
                try
                {
                    var curdate = new DateTime(date.Value.Year, date.Value.Month, i);
                    table.Rows.Add(new object[] {
                        curdate.ToLongDateString(),
                        Program.db.GetRecords<Data.Models.Vehicle>().Where(r=>r.HasReservations() && r.GetReservations().FirstOrDefault().Sold && DateTime.Parse(r.GetReservations().FirstOrDefault().DateSold)==curdate).Count(),
                        Program.db.GetRecords<Data.Models.Vehicle>().Where(r=>r.HasReservations() && !r.GetReservations().FirstOrDefault().Sold && DateTime.Parse(r.GetReservations().FirstOrDefault().DateReserved)==curdate).Count(),
                        Program.db.GetRecords<Data.Models.Expens>().Where(r=>DateTime.Parse( r.Date) == curdate).Sum(r=>r.Amount).ToString("N1"),
                        Program.db.GetRecords<Data.Models.Payment>().Where(r=>DateTime.Parse( r.Date) == curdate).Sum(r=>r.Amount).ToString("N1"),
                        (Program.db.GetRecords<Data.Models.Payment>().Where(r=>DateTime.Parse( r.Date) == curdate).Sum(r=>r.Amount)-
                        Program.db.GetRecords<Data.Models.Expens>().Where(r=>DateTime.Parse( r.Date) == curdate).Sum(r=>r.Amount)).ToString("N1")
                    });
                }
                catch (Exception)
                { 
                }
            }

            printer.AddDataTable(table);


            DataTable table2 = new DataTable();
             table2.Columns.Add("Sales");
            table2.Columns.Add("Reservations");
            table2.Columns.Add("Total Expenses");
            table2.Columns.Add("Total Income");
            table2.Columns.Add("Balance");

            table2.Rows.Add(new object[] {
                        Program.db.GetRecords<Data.Models.Vehicle>().Where(r=>r.HasReservations() && r.GetReservations().FirstOrDefault().Sold && DateTime.Parse(r.GetReservations().FirstOrDefault().DateSold).Month==date.Value.Month && DateTime.Parse(r.GetReservations().FirstOrDefault().DateSold).Year==date.Value.Year).Count(),
                        Program.db.GetRecords<Data.Models.Vehicle>().Where(r=>r.HasReservations() && !r.GetReservations().FirstOrDefault().Sold && DateTime.Parse(r.GetReservations().FirstOrDefault().DateReserved).Month==date.Value.Month && DateTime.Parse(r.GetReservations().FirstOrDefault().DateReserved).Year==date.Value.Year).Count(),
                        Program.db.GetRecords<Data.Models.Expens>().Where(r=>DateTime.Parse( r.Date).Month == date.Value.Month && DateTime.Parse( r.Date).Year == date.Value.Year).Sum(r=>r.Amount).ToString("N1"),
                        Program.db.GetRecords<Data.Models.Payment>().Where(r=>DateTime.Parse( r.Date).Month == date.Value.Month  && DateTime.Parse( r.Date).Year == date.Value.Year ).Sum(r=>r.Amount).ToString("N1"),
                        (Program.db.GetRecords<Data.Models.Payment>().Where(r=>DateTime.Parse( r.Date).Month == date.Value.Month && DateTime.Parse( r.Date).Year == date.Value.Year ).Sum(r=>r.Amount)-
                        Program.db.GetRecords<Data.Models.Expens>().Where(r=>DateTime.Parse( r.Date).Month ==  date.Value.Month && DateTime.Parse( r.Date).Year ==  date.Value.Year).Sum(r=>r.Amount)).ToString("N1")
            });

            printer.AddString("<p>Summary</p>");

            printer.AddDataTable(table2);


            printer.ShowPrintPreviewDialog();
        }

        private void report2_Click(object sender, EventArgs e)
        {
            printer.Clear();
            printer.AddImage(logo.Image, "width=150");
            printer.AddString($"<h3>Monthly Report for year  {date.Value.Year}</h3>");

            DataTable table = new DataTable();
            table.Columns.Add("Month");
            table.Columns.Add("Sales");
            table.Columns.Add("Reservations");
            table.Columns.Add("Total Expenses");
            table.Columns.Add("Total Income");
            table.Columns.Add("Balance");

            for (int i = 1; i < 12; i++)
            {
                try
                {
                    var curdate = new DateTime(date.Value.Year, i, 1);
                    table.Rows.Add(new object[] {
                       curdate.ToString("MMMM", CultureInfo.InvariantCulture),
                       Program.db.GetRecords<Data.Models.Vehicle>().Where(r=>r.HasReservations() && r.GetReservations().FirstOrDefault().Sold && DateTime.Parse(r.GetReservations().FirstOrDefault().DateSold).Month==curdate.Month && DateTime.Parse(r.GetReservations().FirstOrDefault().DateSold).Year==curdate.Year).Count(),
                       Program.db.GetRecords<Data.Models.Vehicle>().Where(r=>r.HasReservations() && !r.GetReservations().FirstOrDefault().Sold && DateTime.Parse(r.GetReservations().FirstOrDefault().DateReserved).Month==curdate.Month && DateTime.Parse(r.GetReservations().FirstOrDefault().DateReserved).Year==curdate.Year).Count(),
                       Program.db.GetRecords<Data.Models.Expens>().Where(r=>DateTime.Parse( r.Date).Month == curdate.Month && DateTime.Parse( r.Date).Year == curdate.Year).Sum(r=>r.Amount).ToString("C1"),
                       Program.db.GetRecords<Data.Models.Payment>().Where(r=>DateTime.Parse( r.Date).Month == curdate.Month  && DateTime.Parse( r.Date).Year == curdate.Year ).Sum(r=>r.Amount).ToString("C1"),
                       (Program.db.GetRecords<Data.Models.Payment>().Where(r=>DateTime.Parse( r.Date).Month == curdate.Month && DateTime.Parse( r.Date).Year == curdate.Year ).Sum(r=>r.Amount)-
                       Program.db.GetRecords<Data.Models.Expens>().Where(r=>DateTime.Parse( r.Date).Month ==  curdate.Month && DateTime.Parse( r.Date).Year ==  curdate.Year).Sum(r=>r.Amount)).ToString("C1")
                    });
                }
                catch (Exception)
                {
                }
            }

            printer.AddDataTable(table);


            DataTable table2 = new DataTable();
            table2.Columns.Add("Sales");
            table2.Columns.Add("Reservations");
            table2.Columns.Add("Total Expenses");
            table2.Columns.Add("Total Income");
            table2.Columns.Add("Balance");

                table2.Rows.Add(new object[] {
                       Program.db.GetRecords<Data.Models.Vehicle>().Where(r=>r.HasReservations() && r.GetReservations().FirstOrDefault().Sold &&   DateTime.Parse(r.GetReservations().FirstOrDefault().DateSold).Year==date.Value.Year).Count(),
                       Program.db.GetRecords<Data.Models.Vehicle>().Where(r=>r.HasReservations() && !r.GetReservations().FirstOrDefault().Sold &&   DateTime.Parse(r.GetReservations().FirstOrDefault().DateReserved).Year==date.Value.Year).Count(),
                       Program.db.GetRecords<Data.Models.Expens>().Where(r=> DateTime.Parse( r.Date).Year == date.Value.Year).Sum(r=>r.Amount).ToString("C1"),
                       Program.db.GetRecords<Data.Models.Payment>().Where(r=>  DateTime.Parse( r.Date).Year == date.Value.Year ).Sum(r=>r.Amount).ToString("C1"),
                       (Program.db.GetRecords<Data.Models.Payment>().Where(r=> DateTime.Parse( r.Date).Year == date.Value.Year ).Sum(r=>r.Amount)-
                       Program.db.GetRecords<Data.Models.Expens>().Where(r=>  DateTime.Parse( r.Date).Year ==  date.Value.Year).Sum(r=>r.Amount)).ToString("C1")
                });

            printer.AddString("<p>Summary</p>");

            printer.AddDataTable(table2);


            printer.ShowPrintPreviewDialog();
        }
    }
}
