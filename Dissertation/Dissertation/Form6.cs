using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;

namespace Dissertation
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            fillCombo1();
            dtpFrom.Value = DateTime.Today.AddDays(-1);
        }

        public Form RefToForm4;
        public string myConn = "datasource=localhost;port=3306;username=root;password=";
        public string dateFrom = "";
        public string dateTo = "";
        public static DataSet ds = new DataSet("New_DataSet");
        public static int sheetCount = 0;
        public static string data = "";
        public bool view = false;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToForm4.Show();
        }

        public void fillCombo1()
        {
            string query = "select * from information_schema.tables where Table_Schema = 'DissertationDB'";
            MySqlConnection myCon = new MySqlConnection(myConn);
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader myReader;
            try
            {
                myCon.Open();
                myReader = myCmd.ExecuteReader();
                while (myReader.Read())
                {
                    string x = "login";
                    if (x != myReader.GetString("table_name"))
                        cbData.Items.Add(myReader.GetString("table_name"));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillCombo2()
        {
            cbReport.Items.Clear();
            cbReport.Items.Add("All Data");
            if (cbData.Text == "refund")
            {
                cbReport.Items.Add("Total Return");
            }
            else if (cbData.Text == "sales")
            {
                cbReport.Items.Add("Total Sold");
            }
        }

        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCombo2();
            if (cbData.Text == "refund" || cbData.Text == "sales")
            {
                lblDateF.Visible = true;
                lblDateT.Visible = true;
                dtpFrom.Visible = true;
                dtpTo.Visible = true;
            }
            else
            {
                lblDateF.Visible = false;
                lblDateT.Visible = false;
                dtpFrom.Visible = false;
                dtpTo.Visible = false;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            view = true;
            Report();
        }

        public void GetDate()
        {
            DateTime DateF = dtpFrom.Value;
            DateTime DateT = dtpTo.Value;
            dateFrom = DateF.ToString("yyyy-MM-dd");
            dateTo = DateT.ToString("yyyy-MM-dd");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Report();
            string file = data + ".xls";
            Workbook wBook = new Workbook();
            int row = 0;
            int col = 0;
            string stemp = "";
            int count = 0;
            int totalRow = 0;

            foreach (DataTable dt in ds.Tables)
            {
                Worksheet wSheet = new Worksheet(data);

                foreach (DataColumn dc in dt.Columns)
                {
                    wSheet.Cells[row, col] = new Cell(dc.ColumnName);
                    col++;
                }
                row = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    col = 0;
                    foreach (DataColumn dc in dt.Columns)
                    {
                        stemp = dr[dc.ColumnName].ToString();
                        wSheet.Cells[row, col] = new Cell(stemp);
                        col++;
                    }
                    row++;
                }
                wBook.Worksheets.Add(wSheet);
                totalRow = totalRow + row;
                row = 0;
                col = 0;
            }

            if (totalRow < 100)
            {
                Worksheet wSheet = new Worksheet("Sheet 2");
                count = 1;
                while (count < 100)
                {
                    wSheet.Cells[count, 0] = new Cell("");
                    count++;
                }
                wBook.Worksheets.Add(wSheet);
            }
            wBook.Save(file);
        }

        public void Report()
        {
            ds.Clear();
            ds.Tables.Clear();
            sheetCount++;
            string query = "";
            if (cbData.Text == "staff")
            {
                query = "select * from DissertationDB.Staff ;";
            }
            else if (cbData.Text == "product")
            {
                query = "select * from DissertationDB.Product ;";
            }
            else if (cbData.Text == "sales")
            {
                if (cbReport.Text == "All Data")
                {
                    query = "select * from DissertationDB.Sales ;";
                }
                else if (cbReport.Text == "Total Sold")
                {
                    GetDate();
                    query = "select Shop.Address, Product.ProductName, sum(Sales.Quantity) as TotalSold from DissertationDB.Product Right Join DissertationDB.Sales ON Product.ProductID = Sales.ProductID left join DissertationDB.Shop on Shop.ShopID = Sales.ShopID where Sales.SaleDate >= '" + dateFrom + "' and Sales.SaleDate <= '" + dateTo + "' group by Product.ProductID, Shop.ShopID order by Product.ProductID ;";
                }
            }
            else if (cbData.Text == "refund")
            {
                query = "select * from DissertationDB.Refund ;";
            }
            else if (cbData.Text == "stock")
            {
                query = "select * from DissertationDB.Stock ;";
            }
            else if (cbData.Text == "shop")
            {
                query = "select * from DissertationDB.Shop ;";
            }
            MySqlConnection myCon = new MySqlConnection(myConn);
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            try
            {
                data = cbData.Text;
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = myCmd;
                DataTable dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataset;
                sda.Update(dbDataset);

                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                ds.Tables.Add(dbDataset);
                if (view == true)
                {
                    Form7 f7 = new Form7();
                    f7.dataGridView1.DataSource = bSource;
                    f7.Show();
                }
                view = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
