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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseManager.OpenConnection();
            string query = "select * from userdata where username=" +"'"+ textBox1.Text +"'"+ " and password= " + "'"+textBox2.Text+"'";
            SqlCommand cmd = new SqlCommand(query ,DatabaseManager.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
           
            if (dt.Rows.Count<.05)
            {
                 MessageBox.Show("User Name and password mismatch");
                return;

            }

            else
            {

                var COMPANYS = new COMPANYS();
                COMPANYS.Show();
                //this.Close();
                this.Hide();
            }
                       
                 
        }
    }
}
