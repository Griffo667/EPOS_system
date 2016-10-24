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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.MaxLength = 4;
            txtPassword.PasswordChar = '*';
            txtUsername.MaxLength = 7;
        }

        public static string shop;
        public static string shopID;
        public static string accesslevel;
        public static string staffID;
        public static string staffName;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand("select * from DissertationDB.Login where Login='" + this.txtUsername.Text + "' and Password='" + this.txtPassword.Text + "' ;", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while(myReader.Read())
                {
                    count++;
                    accesslevel = myReader.GetString("AccessLevel");
                    staffID = myReader.GetString("StaffID");
                }
                StaffName();
                if(count == 1)
                {
                    if (shopID == "Head Office")
                    {
                        if (accesslevel == "1" || accesslevel == "4")
                        {
                            txtPassword.Text = "";
                            txtUsername.Text = "";
                            comboBox1.Text = "";
                            this.Hide();
                            Form4 f4 = new Form4();
                            f4.RefToForm1 = this;
                            f4.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("You do not have the required access to view the head office page.");
                            txtPassword.Text = "";
                            txtUsername.Text = "";
                            comboBox1.Text = "";
                        }
                    }
                    else
                    {
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                        comboBox1.Text = "";
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.RefToForm1 = this;
                        f2.ShowDialog();
                    }
                }
                else if(count > 1)
                {
                    MessageBox.Show("Duplicate Username and password ....Access Denied.");
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Incorrect Username and/or Password.");
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    comboBox1.Text = "";
                }
                myConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillCombo()
        {
            string myConn = "datasource=localhost;port=3306;username=root;password=";
            string query = "select * from DissertationDB.Shop ;";
            MySqlConnection myCon = new MySqlConnection(myConn);
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader myReader;
            try
            {
                myCon.Open();
                myReader = myCmd.ExecuteReader();
                while(myReader.Read())
                {
                    string x = myReader.GetString("ShopID");
                    string y = myReader.GetString("Address");
                    string z = myReader.GetString("City");
                    string combined = "Shop " + x + ", " + y + ", " + z;
                    comboBox1.Items.Add(combined);
                }
                myCon.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Head Office")
            {
                string myConn = "datasource=localhost;port=3306;username=root;password=";
                string query = "select * from DissertationDB.Shop ;";
                MySqlConnection myCon = new MySqlConnection(myConn);
                MySqlCommand myCmd = new MySqlCommand(query, myCon);
                MySqlDataReader myReader;
                try
                {
                    myCon.Open();
                    myReader = myCmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        string x = myReader.GetString("ShopID");
                        string y = myReader.GetString("Address");
                        string z = myReader.GetString("City");
                        string combo = "Shop " + x + ", " + y + ", " + z;
                        if (combo == comboBox1.Text)
                        {
                            shopID = myReader.GetString("ShopID");
                            shop = combo;
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                shopID = comboBox1.Text;
                shop = comboBox1.Text;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.SelectionStart = 0;
            txtUsername.SelectionLength = txtUsername.Text.Length;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectionStart = 0;
            txtPassword.SelectionLength = txtPassword.Text.Length;
        }

        void StaffName()
        {
            string myConn = "datasource=localhost;port=3306;username=root;password=";
            string query = "select * from DissertationDB.Staff where StaffID='" + staffID + "';";
            MySqlConnection myCon = new MySqlConnection(myConn);
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader myReader;
            try
            {
                myCon.Open();
                myReader = myCmd.ExecuteReader();
                while (myReader.Read())
                {
                    string fName = myReader.GetString("FirstName");
                    string lName = myReader.GetString("LastName");
                    staffName = fName + " " + lName;
                }
                myCon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
