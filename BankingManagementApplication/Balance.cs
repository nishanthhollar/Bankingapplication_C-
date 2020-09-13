using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Bankingfinal
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server = localhost; database = bankdb;  username = root; password =;");

        private void Balance_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "select* from account where accid = '" + txtacc.Text + "'";
                MySqlCommand cmd = new MySqlCommand(str, con);


                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    txtbal.Text = rd[4].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
