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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bisho\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string acc = Login.AccNumber;
        private void addTransaction()
        {
            string transType = "Deposit";
            try
            {
                con.Open();
                string query = "INSERT INTO TransactionTable VALUES('" + acc + "','" + transType + "'," + DepositAmntTb.Text + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void button1_Click(object sender, EventArgs e)
        {
              if (DepositAmntTb.Text == "" || Convert.ToInt32(DepositAmntTb.Text) <= 0)
            {
                MessageBox.Show("Enter the amount to deposit");
            }
            else
            {

                newBalance = oldBalance + Convert.ToInt32(DepositAmntTb.Text);
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newBalance + " where AccNum = '" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deposit Successful.");
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
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
        int oldBalance;
        int newBalance;
        private void getBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTable where AccNum = '" + acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
