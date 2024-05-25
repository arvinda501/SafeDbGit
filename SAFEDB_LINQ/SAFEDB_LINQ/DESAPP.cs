using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAFEDB_LINQ
{
    public partial class DESAPP : Form
    {
        public DESAPP()
        {
            InitializeComponent();
        }

        private void sELECTFINANCIALYEARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void DESAPP_Load(object sender, EventArgs e)
        {
            this.Text =  GlobalVariables.c_name1+" - "+GlobalVariables.YEARDES1 ;

            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.FromArgb(255, 224, 192);


                    break;
                }
            }

        }

        private void aCCOUNTLEDGERMASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PMAS = new PMAS();

            PMAS.Show();

        }
    }
}
