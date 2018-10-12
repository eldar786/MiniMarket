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
    public partial class Form1 : Form
    {

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.IsUserLoggedin)
            {



                Form3 f3 = new Form3();
                f3.Show();



            }
            else
            {
                MessageBox.Show("Please login as administrator");
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Program.IsUserLoggedin)
            {

                TestForm t = new TestForm();
                t.Show();



            }
            else
            {
                MessageBox.Show("Please login as administrator");
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.IsUserLoggedin)
            {

                TestForm t = new TestForm();
                t.Show();



            }
            else
            {
                MessageBox.Show("Please login as administrator");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/0ByWYWsXshG_pblpnRWJGX2JRb0E/view?usp=sharing");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();



        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
         
                MySqlCommand s = new MySqlCommand("select * from eldarminimarket.feedback");

                DataSet ds = new Sqldao().GetDataSet(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }
    }



       
        

        
    



