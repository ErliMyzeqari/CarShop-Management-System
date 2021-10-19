using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_dealer_V1._0_beta.Helper
{
    public static class ImportExportCSV
    {
        public static void ExportToFile(DataGridView dataGridView1, string filename)
        {
            var sb = new StringBuilder();

            List<DataGridViewColumn> headers = new List<DataGridViewColumn>();

            foreach (var item in dataGridView1.Columns.Cast<DataGridViewColumn>())
            {
                if (item.HeaderText.Trim().Length > 0)
                {
                    headers.Add(item);
                }
            }


            sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText).ToArray()));



            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                List<DataGridViewCell> cells = new List<DataGridViewCell>();

                foreach (var item in row.Cells.Cast<DataGridViewCell>())
                {
                    if (dataGridView1.Columns[item.ColumnIndex].HeaderText.Trim().Length > 0)
                    {
                        DataGridViewCell cell = item;
                        if (dataGridView1.Columns[cell.ColumnIndex].DefaultCellStyle.Format == "C2" && cell.Value!=null)
                        {
                            cell.Value = "$" + cell.Value.ToString();
                        }
                        cells.Add(cell);
                    }
                }
                sb.AppendLine(string.Join(",", cells.Select(cell => cell.Value).ToArray()));
            }



            File.WriteAllText(filename, sb.ToString());
        }

        public static DataTable ImportCSV(string strFilePath)
        {
            StreamReader sr = new StreamReader(strFilePath);
            string[] headers = sr.ReadLine().Split(',');
            DataTable dt = new DataTable();
            foreach (string header in headers)
            {
                dt.Columns.Add(header.ToLower());
            }
            while (!sr.EndOfStream)
            {
                string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                DataRow dr = dt.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

    }
}
