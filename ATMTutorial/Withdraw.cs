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
    public partial class Withdraw : Form
    {
        public Withdraw()
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
            balanceLabel.Text = "Available Balance: " + dt.Rows[0][0].ToString() + " cedis";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void addTransaction()
        {
            string transType = "Withdraw";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTable VALUES('" + acc + "','" + transType + "'," + withdrawtb.Text + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();  
        }

        
        int newBalance;
        private void button1_Click(object sender, EventArgs e)
        {
            if (withdrawtb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else if (Convert.ToInt32(withdrawtb.Text) <= 0)
            {
                MessageBox.Show("Enter a valid amount");
            }
            else if (Convert.ToInt32(withdrawtb.Text) > bal)
            {
                MessageBox.Show("Enter a valid amount");
            }
            else
            {
                try
                {
                    newBalance = bal - Convert.ToInt32(withdrawtb.Text);
                    try
                    {
                        con.Open();
                        string query = "update AccountTable set Balance = " + newBalance + " where AccNum = '" + acc + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Withdraw Successful.");
                        con.Close();
                        addTransaction();
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        
       

        private void balanceLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
