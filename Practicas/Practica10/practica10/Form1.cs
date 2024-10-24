using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica10
{
    public partial class Login : Form
    {
        string userName = "zahidLocote1";
        string password = "simoncarnal";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName == userTextBox.Text && password == passTextBox.Text)
            {
                Form2 contenido = new Form2();
                contenido.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña son incorrectos, verifique sus credenciales", "Acceso denegado",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                passTextBox.UseSystemPasswordChar = false;
            if (checkBox1.Checked == false)
                passTextBox.UseSystemPasswordChar = true;

        }
    }
}
