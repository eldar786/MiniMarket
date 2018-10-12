using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MiniMarket
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3308;username=root;password=root";
            string Query = "insert into eldarminimarket.suporder (Name, Lastname, Phone, Email, Company, Type, Quantity, PlaceToDeliver, Rating) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox4.Text + "', '" + this.textBox5.Text + "', '" + this.textBox6.Text + "', '" + this.textBox7.Text + "', '" + this.textBox8.Text + "','" + this.textBox9.Text + "');";
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
            MessageBox.Show("Your order has been received.");

            string constring2 = "datasource=localhost;port=3308;username=root;password=root";
            string Query2 = "insert into eldarminimarket.customer (FirstName, LastName, PhoneNumber, Email, address) values('" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox4.Text + "', '" + this.textBox5.Text + "', '" + this.textBox6.Text + "');";
            MySqlConnection conDataBase2 = new MySqlConnection(constring2);
            MySqlCommand cmdDataBase2 = new MySqlCommand(Query2, conDataBase2);
            MySqlDataReader myReader2;
            try
            {
                conDataBase2.Open();
                myReader2 = cmdDataBase2.ExecuteReader();
                while (myReader2.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}



