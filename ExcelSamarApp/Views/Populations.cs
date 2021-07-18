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

namespace ExcelSamarApp
{
    public partial class Populations : Form
    {
        public DataTable dtExcel;
        public DataTable dtb;
        MainMenu menu;
        public Populations(DataTable dt,MainMenu mn)
        {
            menu = mn;
            dtExcel = dt;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Adult");
            comboBox1.Items.Add("Citizens of the Country");
            comboBox1.Items.Add("Ethnic Minorities");
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Foreign Nationals");
            comboBox1.Items.Add("Homeless Populations");
            comboBox1.Items.Add("LGBTQI Individuals");
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Migrant Workers");
            comboBox1.Items.Add("Minor");
            comboBox1.Items.Add("People with Disabilities");
            comboBox1.Items.Add("People with HIV/AIDS");
            comboBox1.Items.Add("Refugees/Asylum Seekers");
            comboBox1.Items.Add("Religious/Social/Political Minority Groups");
            comboBox1.Items.Add("Sex Workers");
            comboBox1.Items.Add("Transgender Female-to-Male");
            comboBox1.Items.Add("Transgender Male-to-Female");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            dtb = new DataTable();
            dtb.Columns.Add("Companies");
            List<string> Populations = new List<string>();
            string[] Pop;
            foreach (DataRow row in dtExcel.Rows)
            {
                string temp = row[10].ToString();
                temp = temp.Trim();
                Pop = temp.Split(',');
                foreach (string st in Pop)
                {
                    string tmp = st;
                    tmp = st.Trim();
                    if (!Populations.Contains(tmp))
                        Populations.Add(tmp);
                }
                if (Populations.Contains(comboBox1.SelectedItem))
                            dtb.Rows.Add(row[0]);

            }
            dataGridView1.DataSource = dtb;
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
                List<string> Populations = new List<string>();

                string temp = row[10].ToString();
                temp = temp.Trim();
                Pop = temp.Split(',');
                foreach (string st in Pop)
                {
                    string tmp = st;
                    tmp = st.Trim();
                    if (!Populations.Contains(tmp))
                        Populations.Add(tmp);
                }
                if (ContainsAllItems(Populations, s))
                    dtb.Rows.Add(row[0]);
            }
                
            
            dataGridView1.DataSource = dtb;
            Console.WriteLine(dtb.Rows.Count);
        }


        //public static bool ScrambledEquals<T>(IEnumerable<T> list1, IEnumerable<T> list2)
        //{
        //    var cnt = new Dictionary<T, int>();
        //    foreach (T s in list1)
        //    {
        //        if (cnt.ContainsKey(s))
        //        {
        //            cnt[s]++;
        //        }
        //        else
        //        {
        //            cnt.Add(s, 1);
        //        }
        //    }
        //    foreach (T s in list2)
        //    {
        //        if (cnt.ContainsKey(s))
        //        {
        //            cnt[s]--;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    return cnt.Values.All(c => c == 0);
        //}
        public static bool ContainsAllItems<T>(List<T> a, List<T> b)
        {
            return !b.Except(a).Any();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dtb, "Populations");
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
