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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bisho\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if(AccSurnameTb.Text == "" || AccNumTb.Text == "" || AccFirstNameTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "" || OccupationTb.Text == "" || PinTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO AccountTable VALUES('"+ AccNumTb.Text + "','" + AccSurnameTb.Text + "','"+ AccFirstNameTb.Text + "','"+ Dob.Value.Date + "','" + PhoneTb.Text + "','" + AddressTb.Text + "','"+ EducationCb.SelectedItem.ToString() + "','" + OccupationTb.Text + "','" + PinTb.Text + "',"+bal+")";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
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
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void EducationTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AccSurnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
