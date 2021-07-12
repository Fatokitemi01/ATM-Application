using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMTutorial
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.Show();
        }
        public static string AccNumber;
        private void Home_Load(object sender, EventArgs e)
        {
            AccNumberLabel.Text = "Account Number:" + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            this.Hide();
            deposit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            this.Hide();
            withdraw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MiniStatement ms = new MiniStatement();
            this.Hide();
            ms.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FastCash fastcash = new FastCash();
            fastcash.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin cp = new ChangePin();
            cp.Show();
            this.Hide();
        }
    }
}
