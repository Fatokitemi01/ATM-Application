using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMTutorial
{
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

       
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bisho\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string acc = Login.AccNumber;
        int bal;
        private void getBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTable where AccNum = '" + acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceLabel.Text = "Available Balance: " + dt.Rows[0][0].ToString() + " cedis";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
        }
       
        private void addTransaction1()
        {
            string transType = "Withdraw";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTable VALUES('" + acc + "','" + transType + "'," + 100 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addTransaction2()
        {
            string transType = "Withdraw";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTable VALUES('" + acc + "','" + transType + "'," + 500 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addTransaction3()
        {
            string transType = "Withdraw";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTable VALUES('" + acc + "','" + transType + "'," + 1000 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addTransaction4()
        {
            string transType = "Withdraw";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTable VALUES('" + acc + "','" + transType + "'," + 2000 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addTransaction5()
        {
            string transType = "Withdraw";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTable VALUES('" + acc + "','" + transType + "'," + 5000 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addTransaction6()
        {
            string transType = "Withdraw";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTable VALUES('" + acc + "','" + transType + "'," + 10000 + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bal < 100)
            {
                MessageBox.Show("Insufficient funds");
            }
            else
            {
                int newBalance = bal - 100;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newBalance + " where AccNum = '" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful.");
                    con.Close();
                    addTransaction1();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Insufficient funds");
            }
            else
            {
                int newBalance = bal - 500;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newBalance + " where AccNum = '" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful.");
                    con.Close();
                    addTransaction2();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Insufficient funds");
            }
            else
            {
                int newBalance = bal - 1000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newBalance + " where AccNum = '" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful.");
                    con.Close();
                    addTransaction3();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Insufficient funds");
            }
            else
            {
                int newBalance = bal - 2000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newBalance + " where AccNum = '" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful.");
                    con.Close();
                    addTransaction4();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Insufficient funds");
            }
            else
            {
                int newBalance = bal - 5000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newBalance + " where AccNum = '" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful.");
                    con.Close();
                    addTransaction5();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("Insufficient funds");
            }
            else
            {
                int newBalance = bal - 10000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newBalance + " where AccNum = '" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful.");
                    con.Close();
                    addTransaction6();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
