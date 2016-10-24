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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtProductID.MaxLength = 8;
        }

        public static string aLevel;
        public static string shopID;
        public static string shop;
        public static string staffID;
        public static string staffName;
        public static int saleID, stockID;
        public static decimal total;
        public static decimal[] cost = new decimal[50];
        public int prod = 0, recieptNumber, refundID;
        public int[] item = new int[100], quantity = new int[100];
        public bool itemvoid = false, cancel = false, paid = false, outOfDate = false;
        public bool sale = true, refund = false, prSearch = false;
        public Form RefToForm1 { get; set; }

        private void Restart()
        {
            txtProductID.Visible = true;
            comboBox1.Visible = false;
            btnNextItem.Enabled = false;
            btnVoid.Enabled = false;
            Product.Enabled = false;
            Price.Enabled = false;
            prSearch = false;
            itemvoid = false;
            outOfDate = false;
            SaleID();
            Product.Items.Clear();
            Price.Items.Clear();
            Product.Items.Add("Product");
            Price.Items.Add("Price");
            txtProductID.Text = "";
            txtQuantity.Text = "1";
            txtTotal.Text = "£0.00";
            lblProductID.Text = "Product ID";
            txtProductID.Text = "";
            lblQuantity.Text = "Quantity";
            btnNextItem.Text = "Next Item";
            btnProductSearch.Text = "Product Search";
            total = 0;
            Array.Clear(item, 0, item.Length);
            Array.Clear(quantity, 0, quantity.Length);
            Array.Clear(cost, 0, cost.Length);
            prod = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            aLevel = Form1.accesslevel;
            shopID = Form1.shopID;
            shop = Form1.shop;
            staffID = Form1.staffID;
            staffName = Form1.staffName;
            Restart();
            btnSale.Enabled = false;
            this.Text = "Sale - " + staffName + ", " + shop;
            if(aLevel == "3")
            {
                btnReport.Enabled = false;
            }
            else
            {
                btnReport.Enabled = true;
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToForm1.Show();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text + "0";
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text + "00";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text + "9";
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            this.Text = "Sale - " + staffName + ", " + shop;
            btnSale.Enabled = false;
            btnRefund.Enabled = true;
            sale = true;
            refund = false;
            Restart();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            Restart();
            this.Text = "Refund - " + staffName + ", " + shop;
            btnSale.Enabled = true;
            btnRefund.Enabled = false;
            sale = false;
            refund = true;
            lblProductID.Text = "Reciept Number";
            btnProductSearch.Text = "Find Reciept";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.RefToForm2 = this;
            this.Hide();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cancel == false)
            {
                string myConn = "datasource=localhost;port=3306;username=root;password=";
                string query = "";
                if (prSearch == false)
                {
                    query = "select * from DissertationDB.Product where ProductCode='" + txtProductID.Text + "';";
                }
                else
                {
                    query = "select * from DissertationDB.Product where ProductName='" + comboBox1.Text + "';";
                }
                MySqlConnection myCon = new MySqlConnection(myConn);
                MySqlCommand myCmd = new MySqlCommand(query, myCon);
                MySqlDataReader myReader;
                try
                {
                    decimal y = 0;
                    myCon.Open();
                    myReader = myCmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        string x = myReader.GetString("ProductName");
                        string ID = myReader.GetString("ProductID");
                        y = myReader.GetDecimal("ProductPrice");
                        decimal quant = Convert.ToDecimal(txtQuantity.Text);
                        y = y * quant;
                        cost[prod] = y;
                        item[prod] = Convert.ToInt32(ID);
                        quantity[prod] = Convert.ToInt32(quant);
                        Product.Items.Add(txtQuantity.Text + " x " + x);
                        Price.Items.Add("£" + y);
                        total += y;
                        txtTotal.Text = "£" + total;
                        prod++;
                    }
                    myCon.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                txtProductID.Text = "";
                txtQuantity.Text = "1";
                itemvoid = true;
                btnVoid.Enabled = true;
                lblProductID.Text = "Product ID";
                btnProductSearch.Text = "Product Search";
                prSearch = false;
                txtProductID.Visible = true;
                comboBox1.Visible = false;
                comboBox1.Items.Clear();
                comboBox1.Text = "";
            }
            else
            {
                cancel = false;
                itemvoid = true;
                btnNextItem.Text = "Next Item";
                Product.Enabled = false;
            }
        }

        private void txtProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sale == true)
            {
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    btnNextItem.PerformClick();
                    e.Handled = true;
                }
            }
            else
            {
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    btnProductSearch.PerformClick();
                    e.Handled = true;
                }
            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            if (prSearch == false)
            {
                if (txtProductID.TextLength == 8)
                {
                    btnNextItem.Enabled = true;
                }
                else
                {
                    btnNextItem.Enabled = false;
                }
            }
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            if (sale == true)
            {
                if (paid == false)
                {
                    paid = true;
                    Product.Items.Add("");
                    Price.Items.Add("");
                    Product.Items.Add("Subtotal");
                    Price.Items.Add("£" + total);
                    SaleID();
                    Product.Items.Add("");
                    Price.Items.Add("");
                    Product.Items.Add("Reciept Number");
                    Price.Items.Add(recieptNumber);
                }
                else
                {
                    Sale();
                    paid = false;
                    Restart();
                }
            }
            else if(refund == true)
            {
                Sale();
                Restart();
                lblProductID.Text = "Reciept Number";
                btnProductSearch.Text = "Find Reciept";
            }
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            txtQuantity.SelectionStart = 0;
            txtQuantity.SelectionLength = txtQuantity.Text.Length;
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            if (refund == false)
            {
                if (prSearch == false)
                {
                    lblProductID.Text = "Product Name";
                    txtProductID.Text = "";
                    btnProductSearch.Text = "Previous Menu";
                    prSearch = true;
                    txtProductID.Visible = false;
                    comboBox1.Visible = true;
                    comboBox1.Items.Clear();
                    comboBox1.Text = "";
                }
                else
                {
                    lblProductID.Text = "Product ID";
                    txtProductID.Text = "";
                    btnProductSearch.Text = "Product Search";
                    prSearch = false;
                    btnNextItem.Enabled = false;
                    txtProductID.Visible = true;
                    comboBox1.Visible = false;
                    comboBox1.Items.Clear();
                    comboBox1.Text = "";
                }
            }
            else
            {
                prod = 0;
                Product.Items.Clear();
                Price.Items.Clear();
                Product.Items.Add("Product");
                Price.Items.Add("Price");
                recieptNumber = Convert.ToInt32(txtProductID.Text);
                Product.Enabled = true;
                Price.Enabled = true;
                string reciept = txtProductID.Text;
                string myConn = "datasource=localhost;port=3306;username=root;password=";
                string query = "select Product.ProductID, Product.ProductName, Sales.Quantity, Product.ProductPrice from DissertationDB.Sales, DissertationDB.Product where RecieptNumber= '" + reciept + "' AND Sales.ProductID = Product.ProductID;";
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
                        int ID = myReader.GetUInt16("ProductID");
                        decimal z = myReader.GetDecimal("ProductPrice");
                        item[prod] = ID;
                        quantity[prod] = Convert.ToInt32(y);
                        z = z * Convert.ToDecimal(y);
                        Product.Items.Add(y + " x " + x);
                        Price.Items.Add("£" + z);
                        total += z;
                        prod++;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                myCon.Close();
            }
        }

        private void txtProductID_Enter(object sender, EventArgs e)
        {
            txtProductID.SelectionStart = 0;
            txtProductID.SelectionLength = txtProductID.Text.Length;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNextItem.Enabled = true;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnNextItem.PerformClick();
            }
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            if(itemvoid == true)
            {
                btnNextItem.Text = "Cancel";
                Product.Enabled = true;
                cancel = true;
                itemvoid = false;
                btnNextItem.Enabled = true;
            }
            else
            {
                int i = Product.SelectedIndex;
                Price.SetSelected(i, true);
                string y = Price.GetItemText(Price.SelectedItem);
                int z = 1;
                y = y.Substring(z);
                try
                {
                    total -= Convert.ToDecimal(y);
                    Price.Items.RemoveAt(i);
                    Product.Items.RemoveAt(i);
                    Product.Items.Insert(i, "");
                    Price.Items.Insert(i, "");
                    txtTotal.Text = "£" + total;
                    btnNextItem.Text = "Next Item";
                    Product.Enabled = false;
                    cancel = false;
                    itemvoid = true;
                    btnNextItem.Enabled = false;
                    item[i - 1] = 0;
                    quantity[i - 1] = 0;
                }
                catch
                {
                    MessageBox.Show("This can not be voided.", "Invalid Selection");
                    Price.SetSelected(i, false);
                    Product.SetSelected(i, false);
                }
            }
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            string myConn = "datasource=localhost;port=3306;username=root;password=";
            string query = "select * from DissertationDB.Product where ProductName LIKE '" + comboBox1.Text + "%';";
            MySqlConnection myCon = new MySqlConnection(myConn);
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader myReader;
            try
            {
                myCon.Open();
                myReader = myCmd.ExecuteReader();
                comboBox1.Items.Clear();
                while (myReader.Read())
                {
                    string x = myReader.GetString("ProductName");
                    comboBox1.Items.Add(x);
                }
                myCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            comboBox1.SelectionStart = comboBox1.Text.Length + 1;
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = false;
        }

        void SaleID()
        {
            string myConn = "datasource=localhost;port=3306;username=root;password=";
            string query = "";
            if (sale == true)
            {
                query = "select * from DissertationDB.Sales ;";
            }
            else if(refund == true)
            {
                query = "select * from DissertationDB.Refund ;";
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
                    string x = "";
                    if (sale == true)
                    {
                        x = myReader.GetString("SalesID");
                    }
                    else if (refund == true)
                    {
                        x = myReader.GetString("RefundID");
                    }
                    string reciept = "50000000";
                    if(sale == true)
                    {
                        reciept = myReader.GetString("RecieptNumber");
                    }
                    int y = Convert.ToInt32(x);
                    if (sale == true)
                    {
                        saleID =  y + 1;
                    }
                    else if (refund == true)
                    {
                        refundID = y + 1;
                    }
                    y = Convert.ToInt32(reciept);
                    recieptNumber = y + 1;
                    if(refund == true)
                    {
                        recieptNumber = Convert.ToInt32(txtProductID.Text);
                    }
                }
                myCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message,"This Section");
            }
        }

        void Sale()
        {
            DateTime time = DateTime.Now;
            string saleTime = time.ToString("HH:mm:ss");
            string saleDate = time.ToString("yyyy-MM-dd");

            if(sale == true)
            {
                for (int i = 0; i < prod; i++)
                {
                    if (item[i] != 0)
                    {
                        string myConn = "datasource=localhost;port=3306;username=root;password=";
                        string query = "insert into DissertationDB.Sales (SalesID,StaffID,ShopID,ProductID,Quantity,SaleValue,RecieptNumber,SaleDate,SaleTime) values('" + saleID + "','" + staffID + "','" + shopID + "','" + item[i] + "','" + quantity[i] + "','" + cost[i] + "','" + recieptNumber + "','" + saleDate + "','" + saleTime + "' ) ;";
                        MySqlConnection myCon = new MySqlConnection(myConn);
                        MySqlCommand myCmd = new MySqlCommand(query, myCon);
                        MySqlDataReader myReader;
                        try
                        {
                            myCon.Open();
                            myReader = myCmd.ExecuteReader();
                            while (myReader.Read())
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                        saleID++;
                        myCon.Close();
                        ProductCheck(item[i], quantity[i], i);
                        string myConn2 = "datasource=localhost;port=3306;username=root;password=";
                        string query2 = "update DissertationDB.Stock set StockID='" + stockID + "',ShopID='" + shopID + "',ProductID='" + item[i] + "',Quantity='" + quantity[i] + "' where StockID='" + stockID + "' ;";
                        MySqlConnection myCon2 = new MySqlConnection(myConn2);
                        MySqlCommand myCmd2 = new MySqlCommand(query2, myCon2);
                        MySqlDataReader myReader2;
                        try
                        {
                            myCon2.Open();
                            myReader2 = myCmd2.ExecuteReader();
                            while (myReader2.Read())
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                        myCon2.Close();
                    }
                }
            }
            else if (refund == true)
            {
                SaleID();
                int i = Product.SelectedIndex - 1;
                if (i >= 0)
                {
                    Refunded(item[i], i);
                    if (outOfDate == false)
                    {
                        string myConn = "datasource=localhost;port=3306;username=root;password=";
                        string query = "insert into DissertationDB.Refund (RefundID,StaffID,SalesID,ShopID,ProductID,Quantity,RefundValue,RecieptNum,RefundDate,RefundTime) values('" + refundID + "','" + staffID + "','" + saleID + "','" + shopID + "','" + item[i] + "','" + quantity[i] + "','" + total + "','" + recieptNumber + "','" + saleDate + "','" + saleTime + "' ) ;";
                        MySqlConnection myCon = new MySqlConnection(myConn);
                        MySqlCommand myCmd = new MySqlCommand(query, myCon);
                        MySqlDataReader myReader;
                        try
                        {
                            myCon.Open();
                            myReader = myCmd.ExecuteReader();
                            while (myReader.Read())
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                        refundID++;
                        myCon.Close();
                        ProductCheck(item[i], quantity[i], i);
                        string myConn2 = "datasource=localhost;port=3306;username=root;password=";
                        string query2 = "update DissertationDB.Stock set StockID='" + stockID + "',ShopID='" + shopID + "',ProductID='" + item[i] + "',Quantity='" + quantity[i] + "' where StockID='" + stockID + "' ;";
                        MySqlConnection myCon2 = new MySqlConnection(myConn2);
                        MySqlCommand myCmd2 = new MySqlCommand(query2, myCon2);
                        MySqlDataReader myReader2;
                        try
                        {
                            myCon2.Open();
                            myReader2 = myCmd2.ExecuteReader();
                            while (myReader2.Read())
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                        myCon2.Close();
                    }
                    else
                    {
                        MessageBox.Show("Product has expired warranty or\nProduct has already been returned", "Error");
                        outOfDate = false;
                    }
                }
            }
        }

        void ProductCheck(int p, int q, int i)
        {
            string myConn = "datasource=localhost;port=3306;username=root;password=";
            string query = "select * from DissertationDB.Stock where ShopID= '" + shopID + "' AND ProductID= '" + p + "' ;";
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
                    string quan = myReader.GetString("Quantity");
                    int y = Convert.ToInt32(x);
                    if (sale == true)
                    {
                        q = Convert.ToInt32(quan) - q;
                    }
                    else if (refund == true)
                    {
                        q = Convert.ToInt32(quan) + q;
                    }
                    stockID = y;
                    quantity[i] = q;
                }
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        void Refunded(int p, int i)
        {
            DateTime now = DateTime.Now;
            string myConn = "datasource=localhost;port=3306;username=root;password=";
            string query = "select *, Refund.SalesID as RefSaleID, Sales.SalesID as SaleID from DissertationDB.Refund, DissertationDB.Sales where Sales.ShopID= '" + shopID + "' AND Sales.ProductID= '" + p + "' ;";
            MySqlConnection myCon = new MySqlConnection(myConn);
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader myReader;
            try
            {
                myCon.Open();
                myReader = myCmd.ExecuteReader();
                while (myReader.Read())
                {
                    string x = myReader.GetString("SaleDate");
                    string a = myReader.GetString("RefSaleID");
                    string b = myReader.GetString("SaleID");
                    saleID = Convert.ToUInt16(b);
                    DateTime sale = Convert.ToDateTime(x);
                    int y = (sale - now).Days;
                    if(y > 28 || a == b)
                    {
                        outOfDate = true;
                    }
                }
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.Text = Convert.ToString(Product.SelectedIndex);
        }
    }
}
