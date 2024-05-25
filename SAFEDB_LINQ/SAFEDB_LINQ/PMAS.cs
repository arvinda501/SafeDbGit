using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SAFEDB_LINQ
{
    public partial class PMAS : Form
    {
        public PMAS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
              //DatabaseManager.OpenConnection();
              //MessageBox.Show("Connection Opened Successfully");
            dsiplydata();

        }
        private void dsiplydata()

        {
            DatabaseManager.OpenConnection();
            string query = " select * from userdata where username="+"'"+textBox1.Text+"'"+" and password="+"'"+textBox2.Text+"'" ;

            SqlCommand cmd = new SqlCommand(query, DatabaseManager.connection);
            SqlDataAdapter adapter = new SqlDataAdapter (cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            
            if (dt.Rows.Count > 0)
            {
                textBox3.Text = dt.Rows[0]["username"].ToString();
                textBox4.Text = dt.Rows[0]["password"].ToString();

            }
            else


            


            {
                MessageBox.Show("Invalid username or password.");
            }
            DatabaseManager.CloseConnection();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseManager.CloseConnection();
            MessageBox.Show("Connection CLOSED Successfully");
        }
    }
}