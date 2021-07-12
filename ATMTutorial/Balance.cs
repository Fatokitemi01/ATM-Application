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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bisho\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void getBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTable where AccNum = '"+AccNumLabel.Text+ "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceLabel.Text = dt.Rows[0][0].ToString() + " cedis";
            con.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumLabel.Text = Home.AccNumber;
            getBalance();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
