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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botón para salir
            if (MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botón para comprobar
            int intentos;
            string Vertical1 = txtVertical1.Text.ToUpper(),
                   Vertical2 = txtVertical2.Text.ToUpper(),
                   Vertical3 = txtVertical3.Text.ToUpper(),
                   Vertical4 = txtVertical4.Text.ToUpper(),
                   Vertical5 = txtVertical5.Text.ToUpper(),
                   Arriba1 = txtArriba1.Text.ToUpper(),
                   Arriba2 = txtArriba2.Text.ToUpper(),
                   Abajo1 = txtAbajo1.Text.ToUpper(),
                   Abajo2 = txtAbajo2.Text.ToUpper(),
                   Abajo3 = txtAbajo3.Text.ToUpper(),
                   Abajo4 = txtAbajo4.Text.ToUpper();
            if (Vertical1 != "L" || Vertical2 != "O" || Vertical3 != "R" || Vertical4 != "O" || Vertical5 != "S" ||
                       Arriba1 != "R" || Arriba2 != "O" ||
                       Abajo1 != "R" || Abajo2 != "A" || Abajo3 != "T" || Abajo4 != "N")
            {
                intentos = int.Parse(txtIntentos.Text);
                intentos += 1;
                txtIntentos.Text = intentos.ToString();
                if (txtIntentos.Text != "5")
                {
                    MessageBox.Show("No es correcto, vas en el intento: " + txtIntentos.Text);
                }else {
                    MessageBox.Show("Número de intentos superados");
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Has acertado");
                Application.Exit();
            }
        }
    }
}
