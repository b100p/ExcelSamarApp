using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSamarApp.Views
{
    public partial class TraffickingType : Form
    {
        DataTable dtExcel;
        DataTable dtb;
        MainMenu menu;
        public TraffickingType(DataTable db,MainMenu mn)
        {
            dtExcel = db;
            menu = mn;
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] Pop;
            List<string> s = new List<string>();
            dtb = new DataTable();
            dtb.Columns.Add("Companies");
            s = checkedListBox1.CheckedItems.OfType<string>().ToList();

            foreach (DataRow row in dtExcel.Rows)
            {
                List<string> TraffickingType = new List<string>();

                string temp = row[11].ToString();
                temp = temp.Trim();
                Pop = temp.Split(',');
                foreach (string st in Pop)
                {
                    string tmp = st;
                    tmp = st.Trim();
                    if (!TraffickingType.Contains(tmp))
                        TraffickingType.Add(tmp);
                }
                if (ContainsAllItems(TraffickingType, s))
                    dtb.Rows.Add(row[0]);
            }


            dataGridView1.DataSource = dtb;
            Console.WriteLine(dtb.Rows.Count);
        }

        public static bool ContainsAllItems<T>(List<T> a, List<T> b)
        {
            return !b.Except(a).Any();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dtb, "TraffickingType");
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                wb.SaveAs(saveFileDialog1.FileName);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }
    }
}
