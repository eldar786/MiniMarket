using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LoginForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
          MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
          MySqlDataAdapter mda = new MySqlDataAdapter("select * from test_db.users", mcon);
 
                mcon.Open();
                DataSet ds = new DataSet();
                mda.Fill(ds,"users");
                dataGridView1.DataSource = ds.Tables["users"];
                mcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


      

