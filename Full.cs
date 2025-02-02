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
    public partial class frmFull : Form
    {
        DataSet dsCustomers = new DataSet();

        public frmFull()
        {
            InitializeComponent();

            this.DataGridView1.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(DataGridView1_ColumnHeaderMouseClick);

            dsCustomers.Tables.Add(new DataTable("Users"));

            DataTable dt = dsCustomers.Tables["Users"];
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Town", typeof(string));
            dt.Columns.Add("Country", typeof(string));

            DataSet tds = GetData();
            int a = 1;

            DataGridView1.DataSource = tds.Tables["Users"];

            this.DataGridView1.Sort(this.DataGridView1.Columns["Id"], ListSortDirection.Ascending);

            lblColumn.Text = "Id";
            lblAscDesc.Text = "ascending";

        }


        private DataSet GetData()
        {
            DataTable dt = dsCustomers.Tables["Users"];
            dt.Rows.Add("ABDEN", "Maria Weiss", "Berlin", "Germany");
            dt.Rows.Add("AXEIS", "Pedro Alvarez", "México D.F.", "Mexico");
            dt.Rows.Add("BENOI", "Anna Tóth", "Szeged", "Hungary");
            dt.Rows.Add("CAZLE", "Jan Eriksson", "Mannheim", "Sweden");
            dt.Rows.Add("DRFOS", "Johan Hofmann", "Lübeck", "Germany");
            return dsCustomers;
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            clsCrystisClass tsi = new clsCrystisClass();
            string preslAccountCode = "DEMO1";  // your account code
            string preslUserCode = "0000"; // yout user code

            tsi.AccountCode = preslAccountCode;
            tsi.UserCode = preslUserCode;
            tsi.dsRPT = dsCustomers;
            tsi.SortTableName = "Users";
            if (rbtScreen.Checked == true)
            {
                tsi.DEST = 0;
            }
            else
            {
                tsi.DEST = 1;
            }
            tsi.SortField1 = DataGridView1.SortedColumn.DataPropertyName;
            string SORTORD = "1";
            if (DataGridView1.SortOrder == SortOrder.Ascending)
            {
                SORTORD = "1";
            }
            else
            {
                SORTORD = "2";
            }
            tsi.SortDirection = SORTORD;

            if (chkFormula.Checked == true)
            {
                tsi.ReportFormula = "{Users.Country} = 'Germany'";
            }
            else
            {
                tsi.ReportFormula = "";
            }

            string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomerReport1.rpt");
            tsi.ReportFullName = rptPath;


            tsi.ShowForm();
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = DataGridView1.Columns[e.ColumnIndex];
            string direction;

            // Check the sort direction
            if (column.HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                direction = "ascending";
            }
            else if (column.HeaderCell.SortGlyphDirection == SortOrder.Descending)
            {
                direction = "descending";
            }
            else
            {
                direction = "none";
            }

            lblColumn.Text = column.HeaderText;
            lblAscDesc.Text = direction;
        }

        private void frmFull_Load(object sender, EventArgs e)
        {
        }
    }
}
