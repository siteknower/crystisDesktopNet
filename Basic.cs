using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystisDesktop;

namespace CrystisDesktopNet
{
    public partial class frmBasic : Form
    {
        public frmBasic()
        {
            InitializeComponent();

            string filename = "schema.xml";
            textBox1.Visible = false;

            using (System.IO.FileStream stream = new System.IO.FileStream(filename, System.IO.FileMode.Open))
            {

                dsCustomers.ReadXmlSchema(stream);
                //dsCustomers.ReadXmlSchema("schema.xml");

                DataSet tds = GetData();
                int a = 1;

                DataGridView1.DataSource = tds.Tables["Users"];

                foreach (DataGridViewColumn column in DataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private DataSet GetData()
        {
            DataTable dt = dsCustomers.Tables["Users"];
            dt.Rows.Add("ABDEN", "Maria Weiss", "Berlin", "Germany");
            dt.Rows.Add("AXEIS", "Pedro Alvarez", "México D.F.", "Mexico");
            dt.Rows.Add("BENOI", "Anna Tóth", "Szeged", "Hungary");
            dt.Rows.Add("CAZLE", "Jan Eriksson", "Mannheim", "Sweden");
            dt.Rows.Add("DRFOS", "Giulia Donatelli", "Milano", "Italia");
            return dsCustomers;
        }

        private void frmBasic_Load(object sender, EventArgs e)
        {
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            clsCrystisClass tsi = new clsCrystisClass();
            string preslAccountCode = "DEMO1";  // your account code
            string preslUserCode = "0000"; // yout user code

            tsi.AccountCode = preslAccountCode;
            tsi.UserCode = preslUserCode;
            tsi.dsRPT = dsCustomers;
            tsi.DEST = 0;

            //tsi.SortTableName = "Users";
            //tsi.SortField1 = "Country";
            //tsi.SortDirection = '1';  // '1' - ascending,  '2' - descending

            //tsi.SortField2 = "";
            //tsi.SortField3 = "";
            //tsi.SortDirection = "";
            //tsi.ReportFormula = "";  

            string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomerReport1.rpt");
            tsi.ReportFullName = rptPath;

            tsi.ShowForm();
        }

        private void btnGetReportUrl_Click(object sender, EventArgs e)
        {
            clsCrystisClass tsi = new clsCrystisClass();
            string preslAccountCode = "DEMO1";  // your account code
            string preslUserCode = "0000"; // yout user code

            tsi.AccountCode = preslAccountCode;
            tsi.UserCode = preslUserCode;
            tsi.dsRPT = dsCustomers;
            tsi.DEST = 0;

            string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomerReport1.rpt");
            tsi.ReportFullName = rptPath;

            string tgetReportUrl = tsi.getReportUrl();

            textBox1.Visible = true;
            textBox1.Text = tgetReportUrl;
        }
    }
}
