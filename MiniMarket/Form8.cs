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

namespace MiniMarket
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3308;username=root;password=root";
            string Query = "insert into eldarminimarket.feedback (Name, `E-mail`, Phone, Address, FirmName, Message) values('" + this.Name_txt.Text + "', '" + this.Email_txt.Text + "', '" + this.Phone_txt.Text + "', '" + this.Address_txt.Text + "', '" + this.FirmName_txt.Text + "', '" + this.Message_txt.Text + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Your feedback has been sumbit.");
        }

        private void Feedbackform_Load(object sender, EventArgs e)
        {
     
        }
    }
}
