using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Mayor
{
   
    public partial class Form1 : Form
    {
        Cliente c1;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
                string _strMayor;
                int _intEdad;
                bool validoLimiteCredito;
                decimal decLimiteCredito;
                c1 = new Cliente();
                c1.Nombre = textNombre.Text;
                c1.FechaNacimiento = dtmFechaNacimiento.Value;
                validoLimiteCredito = decimal.TryParse(textLimiteCredito.Text, out decLimiteCredito);
                if (!validoLimiteCredito)
                {
                        MessageBox.Show("Debe ingresar el límite de crédito");
                }
                else
                {
                     _intEdad = c1.CalcularEdad();
                      if (c1.EsMayorEdad())
                      {
                          _strMayor = " es mayor de edad";
                      }
                      else
                      {
                          _strMayor = " no es mayor de edad";
                      }
                      MessageBox.Show(c1.Nombre + " tiene " + c1.CalcularEdad() + " años (s) \n" +
                      c1.Nombre + _strMayor + "\n" + "Límite de crédito: " + decLimiteCredito);
                }
            }
            catch
            {
                MessageBox.Show("Hay algún error");
            }
        }
    }
}
