using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_E_Biller_Facturer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font tipotexto = new Font("Arial Black", 12, FontStyle.Bold);
     
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }
    }
}
