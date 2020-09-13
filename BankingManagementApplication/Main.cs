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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accountcreation account = new Accountcreation();
            account.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Balance account = new Balance();
            account.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Withdraw account = new Withdraw();
            account.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Deposit account = new Deposit();
            account.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transfer account = new transfer();
            account.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            About account = new About();
            account.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Contact account = new Contact();
            account.Show();
        }
    }
}
