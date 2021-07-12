
namespace ATMTutorial
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AccNumberLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 82);
            this.panel1.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Close.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(810, 2);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(28, 26);
            this.Close.TabIndex = 13;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Your Transaction Please";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(59, 183);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "DEPOSIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(507, 183);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "WITHDRAW";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(59, 297);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(279, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "FAST CASH";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(507, 297);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(279, 43);
            this.button4.TabIndex = 12;
            this.button4.Text = "MINI STATEMENT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(59, 416);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(279, 43);
            this.button5.TabIndex = 13;
            this.button5.Text = "CHANGE PIN ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBalance.ForeColor = System.Drawing.Color.White;
            this.btnBalance.Location = new System.Drawing.Point(507, 416);
            this.btnBalance.Margin = new System.Windows.Forms.Padding(4);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(279, 43);
            this.btnBalance.TabIndex = 14;
            this.btnBalance.Text = "BALANCE";
            this.btnBalance.UseVisualStyleBackColor = false;
            this.btnBalance.Click += new System.EventHandler(this.button6_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.BackColor = System.Drawing.SystemColors.Control;
            this.Logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Logout.Location = new System.Drawing.Point(385, 516);
            this.Logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(88, 22);
            this.Logout.TabIndex = 15;
            this.Logout.Text = "LOGOUT";
            this.Logout.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 554);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 12);
            this.panel2.TabIndex = 16;
            // 
            // AccNumberLabel
            // 
            this.AccNumberLabel.AutoSize = true;
            this.AccNumberLabel.BackColor = System.Drawing.Color.White;
            this.AccNumberLabel.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumberLabel.ForeColor = System.Drawing.Color.Green;
            this.AccNumberLabel.Location = new System.Drawing.Point(187, 100);
            this.AccNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccNumberLabel.Name = "AccNumberLabel";
            this.AccNumberLabel.Size = new System.Drawing.Size(233, 33);
            this.AccNumberLabel.TabIndex = 14;
            this.AccNumberLabel.Text = "Account Number";
            this.AccNumberLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 566);
            this.Controls.Add(this.AccNumberLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGOUT";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AccNumberLabel;
    }
}