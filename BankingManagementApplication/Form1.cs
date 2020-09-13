using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bankingfinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count;

        private void txtpass_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtuser_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtuser.Text;
            password = txtpass.Text;

            count = count + 1;

            if (count > 3)
            {
                MessageBox.Show("System has been blocked😑😑");
                Application.Exit();
            }

            if (username == "" && password == "")
            {
                label3.Text = ("Blanks are not allowed!!😶😶😶🙄");
            }

            else if (username.Length >= 10 && password.Length >= 10)
            {
                label3.Text = ("Only 10 characters allowed!😶😶😶🙄");
            }
            else
            {

                if (username == "monkey" && password == "pinky")
                {
                    // label3.Text = "Login Successful👌👌😎";

                    progrbar pr = new progrbar();
                    this.Hide();
                    pr.Show();



                }
                else
                {
                    label3.Text = "Invalid UserName or Password😮😶😑";
                    txtuser.Clear();
                    txtpass.Clear();
                    txtuser.Focus();
                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             label3.Text = "";
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
