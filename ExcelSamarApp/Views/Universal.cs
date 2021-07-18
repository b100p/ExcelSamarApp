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
    public partial class Universal : Form
    {
        public DataTable dtExcel;
        public DataTable dtb;
        public MainMenu menu;
        public Universal(DataTable dt,MainMenu mn)
        {
            dtExcel = dt;
            menu = mn;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] Pop;
            string[] Ser;
            string[] Traf;
            List<string> TrafficChk = new List<string>();
            List<string> PopulationChk = new List<string>();
            List<string> ServiceChk = new List<string>();
            dtb = new DataTable();
            dtb.Columns.Add("Companies");
            TrafficChk = chklstTrafficType.CheckedItems.OfType<string>().ToList();
            PopulationChk = chklstPopulation.CheckedItems.OfType<string>().ToList();
            ServiceChk = chklstServices.CheckedItems.OfType<string>().ToList();

            foreach (DataRow row in dtExcel.Rows)
            {
                List<string> TraffickingType = new List<string>();
                List<string> Population = new List<string>();
                List<string> Services= new List<string>();

                string tempTraffic = row[11].ToString();
                string tempPopulation = row[10].ToString();
                string tempService = row[12].ToString();
                tempPopulation = tempPopulation.Trim();
                Pop = tempPopulation.Split(',');
                tempTraffic = tempTraffic.Trim();
                Traf = tempTraffic.Split(',');
                tempService = tempService.Trim();
                Ser = tempService.Split(',');
                foreach (string st in Pop)
                {
                    string tmp = st;
                    tmp = st.Trim();
                    if (!Population.Contains(tmp))
                        Population.Add(tmp);
                }
                foreach (string st in Ser)
                {
                    string tmp = st;
                    tmp = st.Trim();
                    if (!Services.Contains(tmp))
                        Services.Add(tmp);
                }
                foreach (string st in Traf)
                {
                    string tmp = st;
                    tmp = st.Trim();
                    if (!TraffickingType.Contains(tmp))
                        TraffickingType.Add(tmp);
                }
                if (ContainsAllItems(TraffickingType, TrafficChk) && ContainsAllItems(Population,PopulationChk) && ContainsAllItems(Services,ServiceChk))
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
    }
}
