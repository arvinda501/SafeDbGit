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
using System.Data.SqlClient;
namespace SAFEDB_LINQ
{
    public partial class COMPANYS : Form
    {

        public COMPANYS()
        {
            InitializeComponent();
            firmselect();
        }

       private void firmselect()
        {
            DatabaseManager.OpenConnection();
            string query = "select company.name as firmname,company.gstin from company order by firmcode";
            SqlCommand cmd = new SqlCommand(query, DatabaseManager.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        



    private void button1_Click(object sender, EventArgs e)
        {
            
            var DESAPP = new DESAPP();
            DESAPP.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void COMPANYS_Load(object sender, EventArgs e)
        {

        }
    }
}
