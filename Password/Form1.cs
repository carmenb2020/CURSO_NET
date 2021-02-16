using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botón para ingresar
            Form2 crucigrama = new Form2();
            string Login, Password; //variables de texto
            Login = txtLogin.Text.Trim(); //quita espacios
            Password = txtPassword.Text.TrimEnd();
            if (Login == "Ofimega" && Password=="danone")
            {
                MessageBox.Show("Bienvenido al sistema");
                crucigrama.Show();
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botón para salir
            if (MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1)==System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
