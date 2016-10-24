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
    public partial class Form4 : Form
    {

        public Form RefToForm1 { get; set; }
        public static string aLevel;
        public string myConn = "datasource=localhost;port=3306;username=root;password=";
        public bool Staff = true, Shop = false, Product = false, other = false;
        public int currentID = 0;

        public Form4()
        {
            InitializeComponent();
            btnStaff.Enabled = false;
            btnShop.Enabled = true;
            StaffID();
        }

        private void btnSignoff_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToForm1.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (other == false)
            {
                this.Text = "Staff";
                btnStaff.Enabled = false;
                btnShop.Enabled = true;
                btnChange.Visible = true;
                lblPassword.Visible = true;
                lblID.Text = "Staff ID";
                lblTitle.Text = "Title";
                lblFirstname.Text = "First Name";
                lblSurname.Text = "Surname";
                lblPosition.Text = "Position";
                lblHouse.Text = "House Number";
                tbTitle.Visible = false;
                cbTitle.Visible = true;
                tbPosition.Visible = false;
                cbPosition.Visible = true;
                lblStreet.Visible = true;
                lblCity.Visible = true;
                lblCounty.Visible = true;
                lblPostcode.Visible = true;
                lblTelephone.Visible = true;
                tbStreet.Visible = true;
                tbCity.Visible = true;
                tbCounty.Visible = true;
                tbPostcode.Visible = true;
                tbPhone.Visible = true;
                tbHouse.Visible = true;
                lblHouse.Visible = true;
                lblPosition.Visible = true;
                Staff = true;
                Product = false;
                Shop = false;
                clr();
            }
            else if(other == true)
            {
                this.Text = "Prdouct";
                btnStaff.Enabled = false;
                btnShop.Enabled = true;
                btnChange.Visible = false;
                lblPassword.Visible = false;
                lblID.Text = "Product ID";
                lblTitle.Text = "Product Name";
                lblFirstname.Text = "Product Type";
                lblSurname.Text = "Price";
                tbTitle.Visible = true;
                cbTitle.Visible = false;
                tbPosition.Visible = false;
                cbPosition.Visible = false;
                tbHouse.Visible = false;
                lblHouse.Visible = false;
                lblPosition.Visible = false;
                lblStreet.Visible = false;
                lblCity.Visible = false;
                lblCounty.Visible = false;
                lblPostcode.Visible = false;
                lblTelephone.Visible = false;
                tbStreet.Visible = false;
                tbCity.Visible = false;
                tbCounty.Visible = false;
                tbPostcode.Visible = false;
                tbPhone.Visible = false;
                Product = true;
                Staff = false;
                Shop = false;
                clr();
            }
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            if (other == false)
            {
                this.Text = "Shop";
                btnStaff.Enabled = true;
                btnShop.Enabled = false;
                btnChange.Visible = false;
                lblPassword.Visible = false;
                lblID.Text = "Shop ID";
                lblTitle.Text = "House Number";
                lblFirstname.Text = "Street";
                lblSurname.Text = "City";
                lblPosition.Text = "County";
                lblHouse.Text = "Postcode";
                tbHouse.Visible = true;
                lblHouse.Visible = true;
                lblPosition.Visible = true;
                tbTitle.Visible = true;
                cbTitle.Visible = false;
                tbPosition.Visible = true;
                cbPosition.Visible = false;
                lblStreet.Visible = false;
                lblCity.Visible = false;
                lblCounty.Visible = false;
                lblPostcode.Visible = false;
                lblTelephone.Visible = false;
                tbStreet.Visible = false;
                tbCity.Visible = false;
                tbCounty.Visible = false;
                tbPostcode.Visible = false;
                tbPhone.Visible = false;
                Staff = false;
                Shop = true;
                clr();
            }
            else if (other == true)
            {
                this.Hide();
                Form6 f6 = new Form6();
                f6.RefToForm4 = this;
                f6.ShowDialog();
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (other == false)
            {
                if (Staff == true || Shop == true)
                {
                    other = true;
                    btnStaff.Text = "Product";
                    btnShop.Text = "Reports";
                    btnStaff.Enabled = true;
                    btnShop.Enabled = true;
                }
                else
                {
                    other = true;
                    btnStaff.Text = "Product";
                    btnShop.Text = "Reports";
                    btnStaff.Enabled = false;
                    btnShop.Enabled = true;
                }
            }
            else if (other == true)
            {
                if (Product == true)
                {
                    other = false;
                    btnStaff.Text = "Staff";
                    btnShop.Text = "Shop";
                    btnStaff.Enabled = true;
                    btnShop.Enabled = true;
                }
                else if (Staff == true)
                {
                    other = false;
                    btnStaff.Text = "Staff";
                    btnShop.Text = "Shop";
                    btnStaff.Enabled = false;
                    btnShop.Enabled = true;
                }
                else if (Shop == true)
                {
                    other = false;
                    btnStaff.Text = "Staff";
                    btnShop.Text = "Shop";
                    btnStaff.Enabled = true;
                    btnShop.Enabled = false;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            string ID = tbID.Text;
            int correctID = Convert.ToInt16(ID) - 1;
            string query = "";
            if (correctID < 0)
                correctID = 0;
            if (correctID > currentID)
                correctID = currentID;
            clr();
            tbID.Text = Convert.ToString(correctID);
            if (Staff == true)
            {
                query = "select * from DissertationDB.Staff where Staff.StaffID = '" + correctID + "' ;";
            }
            else if (Shop == true)
            {
                query = "select * from DissertationDB.Shop where Shop.ShopID = '" + correctID + "';";
            }
            else if(Product == true)
            {
                query = "select * from DissertationDB.Product where Product.ProductID = '" + correctID + "' ;";
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
                    if (Staff == true)
                    {
                        cbTitle.Text = myReader.GetString("Title");
                        tbFirstname.Text = myReader.GetString("FirstName");
                        tbSurname.Text = myReader.GetString("LastName");
                        cbPosition.Text = myReader.GetString("Position");
                        tbHouse.Text = myReader.GetString("HouseNumber");
                        tbStreet.Text = myReader.GetString("Address");
                        tbCity.Text = myReader.GetString("City");
                        tbCounty.Text = myReader.GetString("County");
                        tbPostcode.Text = myReader.GetString("PostCode");
                        tbPhone.Text = myReader.GetString("ContactNumber");
                    }
                    else if (Shop == true)
                    {
                        tbTitle.Text = myReader.GetString("Number");
                        tbFirstname.Text = myReader.GetString("Address");
                        tbSurname.Text = myReader.GetString("City");
                        tbPosition.Text = myReader.GetString("County");
                        tbHouse.Text = myReader.GetString("PostCode");
                    }
                    else if(Product == true)
                    {
                        tbTitle.Text = myReader.GetString("ProductName");
                        tbFirstname.Text = myReader.GetString("ProductType");
                        tbSurname.Text = myReader.GetString("ProductPrice");
                    }
                }
                myCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string ID = tbID.Text;
            int correctID = Convert.ToInt16(ID) + 1;
            string query = "";
            if (correctID < 0)
                correctID = 0;
            if (correctID > currentID)
                correctID = currentID;
            clr();
            tbID.Text = Convert.ToString(correctID);
            if (Staff == true)
            {
                query = "select * from DissertationDB.Staff where Staff.StaffID = '" + correctID + "' ;";
            }
            else if (Shop == true)
            {
                query = "select * from DissertationDB.Shop where Shop.ShopID = '" + correctID + "';";
            }
            else if (Product == true)
            {
                query = "select * from DissertationDB.Product where Product.ProductID = '" + correctID + "' ;";
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
                    if (Staff == true)
                    {
                        cbTitle.Text = myReader.GetString("Title");
                        tbFirstname.Text = myReader.GetString("FirstName");
                        tbSurname.Text = myReader.GetString("LastName");
                        cbPosition.Text = myReader.GetString("Position");
                        tbHouse.Text = myReader.GetString("HouseNumber");
                        tbStreet.Text = myReader.GetString("Address");
                        tbCity.Text = myReader.GetString("City");
                        tbCounty.Text = myReader.GetString("County");
                        tbPostcode.Text = myReader.GetString("PostCode");
                        tbPhone.Text = myReader.GetString("ContactNumber");
                    }
                    else if (Shop == true)
                    {
                        tbTitle.Text = myReader.GetString("Number");
                        tbFirstname.Text = myReader.GetString("Address");
                        tbSurname.Text = myReader.GetString("City");
                        tbPosition.Text = myReader.GetString("County");
                        tbHouse.Text = myReader.GetString("PostCode");
                    }
                    else if (Product == true)
                    {
                        tbTitle.Text = myReader.GetString("ProductName");
                        tbFirstname.Text = myReader.GetString("ProductType");
                        tbSurname.Text = myReader.GetString("ProductPrice");
                    }
                }
                myCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "";
            int pID = 0;
            pID = 80010000 + Convert.ToInt16(tbID.Text);
            if (Staff == true)
            {
                query = "insert into DissertationDB.Staff (StaffID,Title,FirstName,LastName,Position,HouseNumber,Address,City,County,PostCode,ContactNumber) values('" + tbID.Text + "','" + cbTitle.Text + "','" + tbFirstname.Text + "','" + tbSurname.Text + "','" + cbPosition.Text + "','" + tbHouse.Text +"','" + tbStreet.Text +"','" + tbCity.Text +"','" + tbCounty.Text +"','" + tbPostcode.Text +"','" + tbPhone.Text +"') ;";
            }
            else if (Shop == true)
            {
                query = "insert into DissertationDB.Shop (ShopID,Number,Address,City,County,PostCode) values('" + tbID.Text + "','" + tbTitle.Text + "','" + tbFirstname.Text + "','" + tbSurname.Text + "','" + tbPosition.Text + "','" + tbHouse.Text + "') ;";
            }
            else if (Product == true)
            {
                query = "insert into DissertationDB.Product (ProductID,ProductCode,ProductName,ProductType,ProductPrice) values('" + tbID.Text + "','" + pID + "','" + tbTitle.Text + "','" + tbFirstname.Text + "','" + tbSurname.Text + "') ;";
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

                }
                myCon.Close();
                if(Staff == true)
                {
                    int alvl = 0;
                    if(cbPosition.Text == "CEO" || cbPosition.Text == "Finance")
                    {
                        alvl = 1;
                    }
                    else if(cbPosition.Text == "Manager" || cbPosition.Text == "Supervisor")
                    {
                        alvl = 2;
                    }
                    else if(cbPosition.Text == "Cashier")
                    {
                        alvl = 3;
                    }
                    else if(cbPosition.Text == "Administrator")
                    {
                        alvl = 4;
                    }
                    int login = 9000000 + Convert.ToInt16(tbID.Text);
                    Random rnd = new Random();
                    string pass = "";
                    int q = 0;
                    for(int i = 0; i < 4; i++)
                    {
                        q = rnd.Next(0, 10);
                        pass = pass + Convert.ToString(q);
                    }
                    query = "insert into DissertationDB.Login (LoginID,StaffID,Login,Password,AccessLevel) values('" + tbID.Text + "','" + tbID.Text + "','" + login + "','" + pass + "','" + alvl + "') ;";
                    MySqlCommand myCmd2 = new MySqlCommand(query, myCon);
                    try
                    {
                        myCon.Open();
                        myReader = myCmd2.ExecuteReader();
                        while (myReader.Read())
                        {

                        } 
                        MessageBox.Show("Your Login is " + login + "\nYour Password is " + pass);
                        myCon.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            clr();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "";
            if(Staff == true)
            {
                query = "update DissertationDB.Staff set Staff.Title = '" + cbTitle.Text + "',Staff.FirstName = '" + tbFirstname.Text + "',Staff.LastName = '" + tbSurname.Text + "',Staff.Position = '" + cbPosition.Text + "',Staff.HouseNumber = '" + tbHouse.Text + "',Staff.Address = '" + tbStreet.Text + "',Staff.City = '" + tbCity.Text + "',Staff.County = '" + tbCounty.Text + "',Staff.PostCode = '" + tbPostcode.Text + "',Staff.ContactNumber = '" + tbPhone.Text + "' where Staff.StaffID = '" + tbID.Text + "' ;";
            }
            else if (Shop == true)
            {
                query = "update DissertationDB.Shop set Shop.Number = '" + tbTitle.Text + "',Shop.Address = '" + tbFirstname.Text + "',Shop.City = '" + tbSurname.Text + "',Shop.County = '" + tbPosition.Text + "',Shop.PostCode = '" + tbHouse.Text + "' where Shop.ShopID = '" + tbID.Text + "' ;";
            }
            else if (Product == true)
            {
                query = "update DissertationDB.Product set Product.ProductName = '" + tbTitle.Text + "',Product.ProductType = '" + tbFirstname.Text + "',Product.ProductPrice = '" + tbSurname.Text + "' where Product.ProductID = '" + tbID.Text + "' ;";
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

                }
                myCon.Close();
                if (Staff == true)
                {
                    int alvl = 0;
                    if (cbPosition.Text == "CEO" || cbPosition.Text == "Finance")
                    {
                        alvl = 1;
                    }
                    else if (cbPosition.Text == "Manager" || cbPosition.Text == "Supervisor")
                    {
                        alvl = 2;
                    }
                    else if (cbPosition.Text == "Cashier")
                    {
                        alvl = 3;
                    }
                    else if (cbPosition.Text == "Administrator")
                    {
                        alvl = 4;
                    }
                    query = "update DissertationDB.Login set Login.AccessLevel = '" + alvl + "' where  Login.StaffID = '" + tbID.Text + "' ;";
                    MySqlConnection myCon2 = new MySqlConnection(myConn);
                    MySqlCommand myCmd2 = new MySqlCommand(query, myCon2);
                    MySqlDataReader myReader2;
                    try
                    {
                        myCon2.Open();
                        myReader2 = myCmd2.ExecuteReader();
                        while (myReader2.Read())
                        {

                        }
                        myCon2.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            clr();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "";
            if (Staff == true)
            {
                query = "delete from DissertationDB.Staff where Staff.StaffID = '" + tbID.Text + "' ;";
            }
            else if (Shop == true)
            {
                query = "delete from DissertationDB.Shop where Shop.ShopID = '" + tbID.Text + "' ;";
            }
            else if (Product == true)
            {
                query = "delete from DissertationDB.Product where Product.ProductID = '" + tbID.Text + "' ;";
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

                }
                myCon.Close();
                if (Staff == true)
                {
                    query = "delete from DissertationDB.Login where Login.StaffID = '" + tbID.Text + "' ;";
                    MySqlCommand myCmd2 = new MySqlCommand(query, myCon);
                    try
                    {
                        myCon.Open();
                        myReader = myCmd2.ExecuteReader();
                        while (myReader.Read())
                        {

                        }
                        myCon.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            clr();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            IDbox();
            string ID = tbID.Text;
            string query = "";
            clr();
            tbID.Text = ID;
            if (Staff == true)
            {
                query = "select * from DissertationDB.Staff where Staff.StaffID = '" + ID + "' ;";
            }
            else if (Shop == true)
            {
                query = "select * from DissertationDB.Shop where Shop.ShopID = '" + ID + "';";
            }
            else if (Product == true)
            {
                query = "select * from DissertationDB.Product where Product.ProductID = '" + ID + "';";
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
                    if (Staff == true)
                    {
                        cbTitle.Text = myReader.GetString("Title");
                        tbFirstname.Text = myReader.GetString("FirstName");
                        tbSurname.Text = myReader.GetString("LastName");
                        cbPosition.Text = myReader.GetString("Position");
                        tbHouse.Text = myReader.GetString("HouseNumber");
                        tbStreet.Text = myReader.GetString("Address");
                        tbCity.Text = myReader.GetString("City");
                        tbCounty.Text = myReader.GetString("County");
                        tbPostcode.Text = myReader.GetString("PostCode");
                        tbPhone.Text = myReader.GetString("ContactNumber");
                    }
                    else if (Shop == true)
                    {
                        tbTitle.Text = myReader.GetString("Number");
                        tbFirstname.Text = myReader.GetString("Address");
                        tbSurname.Text = myReader.GetString("City");
                        tbPosition.Text = myReader.GetString("County");
                        tbHouse.Text = myReader.GetString("PostCode");
                    }
                    else if (Product == true)
                    {
                        tbTitle.Text = myReader.GetString("ProductName");
                        tbFirstname.Text = myReader.GetString("ProductType");
                        tbSurname.Text = myReader.GetString("ProductPrice");
                    }
                }
                myCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void StaffID()
        {
            string query = "";
            if (Staff == true)
            {
                query = "select * from DissertationDB.Staff ;";
            }
            else if (Shop == true)
            {
                query = "select * from DissertationDB.Shop ;";
            }
            else if (Product == true)
            {
                query = "select * from DissertationDB.Product ;";
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
                    if(Staff == true)
                    {
                        x = myReader.GetString("StaffID");
                    }
                    else if (Shop == true)
                    {
                        x = myReader.GetString("ShopID");
                    }
                    else if (Product == true)
                    {
                        x = myReader.GetString("ProductID");
                    }
                    currentID = 1 + Convert.ToInt16(x);
                    tbID.Text = Convert.ToString(currentID);
                }
                myCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void clr()
        {
            tbID.Text = "";
            tbTitle.Text = "";
            cbTitle.Text = "";
            cbPosition.Text = "";
            tbPosition.Text = "";
            tbFirstname.Text = "";
            tbSurname.Text = "";
            tbHouse.Text = "";
            tbStreet.Text = "";
            tbCity.Text = "";
            tbCounty.Text = "";
            tbPostcode.Text = "";
            tbPhone.Text = "";
            StaffID();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string pass = "";
            int q = 0;
            for(int i = 0; i < 4; i++)
            {
                q = rnd.Next(10);
                pass = pass + Convert.ToString(q);
            }
            string query = "update DissertationDB.Login set Login.Password = '" + pass + "' where Login.StaffID = '" + tbID.Text + "' ;";
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
                myCon.Close();
                MessageBox.Show("Your Password has been changed to " + pass);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void IDbox()
        {
            Form5 f5 = new Form5();
            if (f5.ShowDialog(this) == DialogResult.OK)
            {
                this.tbID.Text = f5.tbID.Text;
            }
            f5.Dispose();
        }
    }
}
