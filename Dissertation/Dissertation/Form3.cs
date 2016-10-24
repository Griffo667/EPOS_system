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

namespace Dissertation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form RefToForm2 { get; set; }
        public static string aLevel;
        public static string shopID;
        public static string shop;
        public string myConn = "datasource=localhost;port=3306;username=root;password=";
        public static int stockID, counter = 0;
        public bool stock = true, order = false, report = false, check = false;
        public int sweetsBox = 50, dairyBox = 10, tobaccoBox = 20, drinksBox = 16, prod = 0; 
        public int[] stockOrder = new int[50], product = new int[50];

        private void btnSignoff_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToForm2.Show();
        }

        void refresh()
        {
            btnStockLevel.Text = "Order Stock";
            cbProductType.Items.Clear();
            cbProductType.Text = "Choose product type...";
            cbProduct.Items.Clear();
            cbProduct.Text = "Choose product...";
            lboxProduct.Items.Clear();
            lboxProduct.Items.Add("Stock        Products");
            txtQuantity.Text = "1";
            Array.Clear(product, 0, product.Length);
            Array.Clear(stockOrder, 0, stockOrder.Length);
            btnAddToOrder.Text = "Add To Order";
            lblProductType.Text = "Product Type";
            cbProductType.Visible = true;
            dtpDate.Visible = false;
            prod = 0;
            fillCombo();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            stock = true;
            order = false;
            report = false;
            refresh();
            this.Text = "Management - Stock";
            btnStock.Enabled = false;
            btnOrder.Enabled = true;
            btnShop.Enabled = true;
            btnAddToOrder.Visible = false;
            lblProduct.Visible = false;
            cbProduct.Visible = false;
            lblQuantity.Visible = false;
            txtQuantity.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            stock = false;
            order = true;
            report = false;
            refresh();
            this.Text = "Management - Order";
            btnStock.Enabled = true;
            btnOrder.Enabled = false;
            btnShop.Enabled = true;
            btnAddToOrder.Visible = true;
            lblProduct.Visible = true;
            cbProduct.Visible = true;
            lblQuantity.Visible = true;
            txtQuantity.Visible = true;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            stock = false;
            order = false;
            report = true;
            refresh();
            lboxProduct.Items.Clear();
            lboxProduct.Items.Add("Stock        Products");
            this.Text = "Management - Shop Reports";
            btnStock.Enabled = true;
            btnOrder.Enabled = true;
            btnShop.Enabled = false;
            btnAddToOrder.Visible = true;
            lblProduct.Visible = false;
            cbProduct.Visible = false;
            lblQuantity.Visible = false;
            txtQuantity.Visible = false;
            btnAddToOrder.Text = "Refund";
            btnStockLevel.Text = "Sales";
            lblProductType.Text = "Date";
            cbProductType.Visible = false;
            dtpDate.Visible = true;
        }

        public void fillCombo()
        {
            if (report == false)
            {
                cbProductType.Items.Add("All");
                string query = "select * from DissertationDB.Product ;";
                MySqlConnection myCon = new MySqlConnection(myConn);
                MySqlCommand myCmd = new MySqlCommand(query, myCon);
                MySqlDataReader myReader;
                try
                {
                    int count = 0;
                    string s = "";
                    myCon.Open();
                    myReader = myCmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (s != myReader.GetString("ProductType"))
                        {
                            count = 0;
                        }
                        count++;
                        if (count == 1)
                        {
                            s = myReader.GetString("ProductType");
                            cbProductType.Items.Add(s);
                        }
                    }
                    myCon.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        public void fillCombo2()
        {
            cbProduct.Items.Add("All");
            string x = cbProductType.Text;
            string query = "";
            if(x == "All")
            {
                query = "select * from DissertationDB.Product ;";
            }
            else
            {
                query = "select * from DissertationDB.Product where ProductType='" + x + "';";
            }
            MySqlConnection myCon = new MySqlConnection(myConn);
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader myReader;
            try
            {
                myCon.Open();
                myReader = myCmd.ExecuteReader();
                while (myReader.Read())
                {
                    string s = myReader.GetString("ProductName");
                    cbProduct.Items.Add(s);
                }
                myCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            fillCombo();
            StockID();
            btnStock.Enabled = false;
            lboxProduct.Items.Add("Quantity     Products");
            aLevel = Form1.accesslevel;
            shopID = Form1.shopID;
            shop = Form1.shop;
        }

        private void btnStockLevel_Click(object sender, EventArgs e)
        {
            if (stock == true)
            {
                lboxProduct.Items.Clear();
                lboxProduct.Items.Add("Quantity     Products");
                string query = "";
                if (cbProductType.Text == "All")
                {
                    query = "select * from DissertationDB.Product, DissertationDB.Stock where Product.ProductId=Stock.ProductID AND Stock.ShopID='" + shopID + "' ;";
                }
                else
                {
                    query = "select * from DissertationDB.Product, DissertationDB.Stock where Product.ProductId=Stock.ProductID AND Stock.ShopID='" + shopID + "' AND Product.ProductType='" + cbProductType.Text + "' ;";
                }
                MySqlConnection myCon = new MySqlConnection(myConn);
                MySqlCommand myCmd = new MySqlCommand(query, myCon);
                MySqlDataReader myReader;
                try
                {
                    myCon.Open();
                    myReader = myCmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        string x = myReader.GetString("ProductName");
                        string y = myReader.GetString("Quantity");
                        lboxProduct.Items.Add(y + "     " + x);
                    }
                    myCon.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else if(order == true)
            {
                MessageBox.Show("Items have been ordered", "Order");
                lboxProduct.Items.Clear();
                lboxProduct.Items.Add("Quantity     Products");
                for(int i = 0; i < prod; i++)
                {
                    counter = i;
                    ProductCheck(product[i], stockOrder[i]);
                    string query = "";
                    if (check == false)
                    {
                        query = "insert into DissertationDB.Stock (StockID,ShopID,ProductID,Quantity) values('" + stockID + "','" + shopID + "','" + product[i] + "','" + stockOrder[i] + "') ;";
                    }
                    else
                    {
                        query = "update DissertationDB.Stock set StockID='" + stockID + "',ShopID='" + shopID + "',ProductID='" + product[i] + "',Quantity='" + stockOrder[i] + "' where StockID='" + stockID + "' ;";
                    }
                    MySqlConnection myCon = new MySqlConnection(myConn);
                    MySqlCommand myCmd = new MySqlCommand(query, myCon);
                    MySqlDataReader myReader;
                    try
                    {
                        myCon.Open();
                        myReader = myCmd.ExecuteReader();
                        while(myReader.Read())
                        {

                        }
                        myCon.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    stockID++;
                    check = false;
                }
                Array.Clear(product, 0, product.Length);
                Array.Clear(stockOrder, 0, stockOrder.Length);
                prod = 1;
            }
            else if(report == true)
            {
                lboxProduct.Items.Clear();
                lboxProduct.Items.Add("Stock     Products");
                DateTime now = dtpDate.Value;
                counter = 0;
                int z = 0;
                string x = "";
                string date = now.ToString("yyyy-MM-dd");
                string query = "select Product.ProductName, sum(Sales.Quantity) as TotalQuantity from DissertationDB.Product Right Join DissertationDB.Sales ON Product.ProductID = Sales.ProductID where Sales.SaleDate= '" + date + "' AND Sales.ShopID= '" + shopID + "' group by Product.ProductID order by Product.ProductID ;";
                MySqlConnection myCon = new MySqlConnection(myConn);
                MySqlCommand myCmd = new MySqlCommand(query, myCon);
                MySqlDataReader myReader;
                try
                {
                    myCon.Open();
                    myReader = myCmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        x = myReader.GetString("ProductName");
                        string y = myReader.GetString("TotalQuantity");
                        z = Convert.ToInt32(y);
                        lboxProduct.Items.Add(y + "     " + x);
                    }
                    myCon.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void cbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(order == true)
            {
                cbProduct.Items.Clear();
                fillCombo2();
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (report == false)
            {
                int i = 0;
                try
                {
                    i = Convert.ToInt16(txtQuantity.Text);
                    if (cbProduct.Text == "All")
                    {
                        MultiProduct(i);
                    }
                    else
                    {
                        SingleProduct(i);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }
            }
            else
            {
                lboxProduct.Items.Clear();
                lboxProduct.Items.Add("Stock     Products");
                DateTime now = dtpDate.Value;
                counter = 0;
                int z = 0;
                string x = "";
                string date = now.ToString("yyyy-MM-dd");
                string query = "select Product.ProductName, sum(Refund.Quantity) as TotalQuantity from DissertationDB.Product Right Join DissertationDB.Refund ON Product.ProductID = Refund.ProductID where Refund.RefundDate= '" + date + "' AND Refund.ShopID= '" + shopID + "' group by Product.ProductID order by Product.ProductID ;";
                MySqlConnection myCon = new MySqlConnection(myConn);
                MySqlCommand myCmd = new MySqlCommand(query, myCon);
                MySqlDataReader myReader;
                try
                {
                    myCon.Open();
                    myReader = myCmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        x = myReader.GetString("ProductName");
                        string y = myReader.GetString("TotalQuantity");
                        z = Convert.ToInt32(y);
                        lboxProduct.Items.Add(y + "     " + x);
                    }
                    myCon.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        void StockID()
        {
            string query = "select * from DissertationDB.Stock ;";
            MySqlConnection myCon = new MySqlConnection(myConn);
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader myReader;
            try
            {
                myCon.Open();
                myReader = myCmd.ExecuteReader();
                while (myReader.Read())
                {
                    string x = myReader.GetString("StockID");
                    int y = Convert.ToInt32(x);
                    stockID = y + 1;
                }
                myCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void SingleProduct(int i)
        {
            string stockAmount = "";
            string query = "";
            if (cbProductType.Text == "All")
            {
                query = "select * from DissertationDB.Product where ProductName= '" + cbProduct.Text + "' ;";
            }
            else
            {
                query = "select * from DissertationDB.Product where ProductType= '" + cbProductType.Text + "' AND ProductName= '" + cbProduct.Text + "' ;";
            }
            MySqlConnection myCon = new MySqlConnection(myConn);
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader myReader;
            try
            {
                myCon.Open();
                myReader = myCmd.ExecuteReader();
                while (myReader.Read())
                {
                    string s = myReader.GetString("ProductName");
                    string ID = myReader.GetString("ProductID");
                    string type = myReader.GetString("ProductType");
                    int amount = 1;
                    int box = 1;
                    if (type == "Sweets")
                    {
                        box = sweetsBox;
                    }
                    else if (type == "Tobacco")
                    {
                        box = tobaccoBox;
                    }
                    else if (type == "Alcohol")
                    {
                        box = drinksBox;
                    }
                    else if (type == "Dairy")
                    {
                        box = dairyBox;
                    }
                    if (i == 1)
                    {
                        stockAmount = "box";
                    }
                    else
                    {
                        stockAmount = "boxes";
                    }
                    lboxProduct.Items.Add(stockAmount + "       " + s);
                    amount = Convert.ToInt16(txtQuantity.Text);
                    amount = amount * box;
                    product[prod] = Convert.ToInt16(ID);
                    stockOrder[prod] = amount;
                    prod++;
                }
                myCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void MultiProduct(int i)
        {
            string stockAmount = "";
            string query = "";
            if (cbProductType.Text == "All")
            {
                query = "select * from DissertationDB.Product ;";
            }
            else
            {
                query = "select * from DissertationDB.Product where ProductType= '" + cbProductType.Text + "' ;";
            }
            MySqlConnection myCon = new MySqlConnection(myConn);
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader myReader;
            try
            {
                myCon.Open();
                myReader = myCmd.ExecuteReader();
                while (myReader.Read())
                {
                    string s = myReader.GetString("ProductName");
                    string ID = myReader.GetString("ProductID");
                    string type = myReader.GetString("ProductType");
                    int amount = 1;
                    int box = 1;
                    if (type == "Sweets")
                    {
                        box = sweetsBox;
                    }
                    else if (type == "Tobacco")
                    {
                        box = tobaccoBox;
                    }
                    else if (type == "Alcohol")
                    {
                        box = drinksBox;
                    }
                    else if (type == "Dairy")
                    {
                        box = dairyBox;
                    }
                    if (i == 1)
                    {
                        stockAmount = "box";
                    }
                    else
                    {
                        stockAmount = "boxes";
                    }
                    lboxProduct.Items.Add(stockAmount + "     " + s);
                    amount = Convert.ToInt16(txtQuantity.Text);
                    amount = amount * box;
                    product[prod] = Convert.ToInt16(ID);
                    stockOrder[prod] = amount;
                    prod++;
                }
                myCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void ProductCheck(int p, int q)
        {
            string query = "select * from DissertationDB.Stock where ShopID= '" + shopID + "' AND ProductID= '" + p + "' ;";
            MySqlConnection myCon = new MySqlConnection(myConn);
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader myReader;
            try
            {
                myCon.Open();
                myReader = myCmd.ExecuteReader();
                StockID();
                int ID = stockID;
                while (myReader.Read())
                {
                    string x = myReader.GetString("StockID");
                    string quan = myReader.GetString("Quantity");
                    int y = Convert.ToInt32(x);
                    q += Convert.ToInt32(quan);
                    if (ID != y)
                    {
                        stockID = y;
                        stockOrder[counter] = q;
                        check = true;
                    }
                }
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (report == true)
            {
                lboxProduct.Items.Clear();
                lboxProduct.Items.Add("Stock        Products");
            }
            else
            {
                lboxProduct.Items.Clear();
                lboxProduct.Items.Add("Quantity     Products");
            }
        }
    }
}
