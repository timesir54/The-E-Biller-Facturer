using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_E_Biller_Facturer.NewFolder;

namespace The_E_Biller_Facturer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == SuperAdminNewFolder.Username && txtPassword.Text == SuperAdminNewFolder.Password)
            {

                txtUsername.Text = "";
                txtPassword.Text = "";
                this.Hide();
                Home home = new Home();
                home.Closed += (s, args) => this.Close();
                home.Show();

            }
            else {

                MessageBox.Show("Usuario o contraseña incorrectos, redacte mejor la proxima vez");
            
            }
            

        


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = txtPassword.UseSystemPasswordChar;
        }
    }
}
