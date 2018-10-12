using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiniMarket
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar='*';
            txtPassword.MaxLength = 10;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string constring = "datasource=localhost;port=3308;username=root;password=root";
            string Query = "SELECT * FROM eldarminimarket.users where username = '"+ txtUsername.Text + "'" + " and password = '" + txtPassword.Text+"'" ;//"insert into cita204.users (name, password, email) values('"+ this.textBox1.Text +"', '"+ this.textBox2.Text +"', '"+ this.textBox3.Text +"');";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);

                if (dbdataset.Rows.Count > 0)
                {
                   
                    MessageBox.Show("Login is successful");
                    Program.IsUserLoggedin = true;

                }
                else {
                    MessageBox.Show("Password or Username Incorrect ,Try Again"); 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}


