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
    public partial class Services : Form
    {
        public DataTable dtExcel;
        public DataTable dtb;
        public MainMenu menu;
        public Services(DataTable dt,MainMenu mn)
        {
            dtExcel = dt;
            menu = mn;
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            //List<string> Populations = new List<string>();
            //string[] Pop;
            //List<string> s = new List<string>();
            //foreach (DataRow row in dtExcel.Rows)
            //{

            //    string temp = row[12].ToString();
            //    temp = temp.Trim();
            //    Pop = temp.Split(',');
            //    foreach (string st in Pop)
            //    {
            //        string tmp = st;
            //        tmp = st.Trim();
            //        if (!Populations.Contains(tmp))
            //            Populations.Add(tmp);
            //    }
            //}
            //Populations.Sort();
            //comboBox1.DataSource = Populations;
            //Populations.ForEach(Console.WriteLine);
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

                string temp = row[12].ToString();
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
