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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bisho\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string acc = Login.AccNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ChangePinTb.Text == "" || NewPinTb.Text == "")
            {
                MessageBox.Show("Enter and confirm the new pin");
            }
            else if (ChangePinTb.Text != NewPinTb.Text)
            {
                MessageBox.Show("Passwords do not match!");
            }
            else
            {

                //newBalance = oldBalance + Convert.ToInt32(DepositAmntTb.Text);
                try
                {
                    con.Open();
                    string query = "update AccountTable set Pin = " + ChangePinTb.Text + " where AccNum = '" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin change was Successful.");
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
