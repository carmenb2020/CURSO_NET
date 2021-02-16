using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botón para sumar
            int n1, n2, suma;
            if (txtNumero1.Text == "" || txtNumero2.Text == "")
            {
                MessageBox.Show("Debe ingresar ambos números");
            }
            else
            {
                n1 = int.Parse(txtNumero1.Text);
                n2 = int.Parse(txtNumero2.Text);
                suma = n1 + n2;
                txtResultado.Text = suma.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botón para salir de la aplicación
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Botón para restar
            int n1, n2, resta;
            if (txtNumero1.Text == "" || txtNumero2.Text == "")
            {
                MessageBox.Show("Debe ingresar ambos números");
            }
            else
            {
                n1 = int.Parse(txtNumero1.Text);
                n2 = int.Parse(txtNumero2.Text);
                resta = n1 - n2;
                txtResultado.Text = resta.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Botón para multiplicar
            int n1, n2, producto;
            if (txtNumero1.Text == "" || txtNumero2.Text == "")
            {
                MessageBox.Show("Debe ingresar ambos números");
            }
            else
            {
                n1 = int.Parse(txtNumero1.Text);
                n2 = int.Parse(txtNumero2.Text);
                producto = n1 * n2;
                txtResultado.Text = producto.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Botón para dividir
            int n1, n2, division;
            if (txtNumero1.Text == "" || txtNumero2.Text == "")
            {
                MessageBox.Show("Debe ingresar ambos números");
            }else { 
                n1 = int.Parse(txtNumero1.Text);
                n2 = int.Parse(txtNumero2.Text);
                division = n1 / n2;
                txtResultado.Text = division.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Botón para limpiar datos
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
