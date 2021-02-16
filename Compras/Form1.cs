using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Opción Hamburguesa, papas y refresco
            txtHamburguesa.Enabled = false;
            txtPapas.Enabled = false;
            txtRefresco.Enabled = false;
            txtPizza.Enabled = false;
            txtNuggets.Enabled = false;
            txtEnsalada.Enabled = false;
            txtYogurt.Enabled = false;
            txtAgua.Enabled = false;
            txtHamburguesa.Text = 1.ToString();
            txtPapas.Text = 1.ToString();
            txtRefresco.Text = 1.ToString();
            txtPizza.Text = 0.ToString();
            txtNuggets.Text = 0.ToString();
            txtEnsalada.Text = 0.ToString();
            txtYogurt.Text = 0.ToString();
            txtAgua.Text = 0.ToString();
            decimal decSubTotal, decIVA, decTotal;
            decSubTotal = (int.Parse(txtHamburguesa.Text) * decimal.Parse(txtPrecioHamburguesa.Text)) +
                          (int.Parse(txtPapas.Text) * decimal.Parse(txtPrecioPapas.Text)) +
                          (int.Parse(txtRefresco.Text) * decimal.Parse(txtPrecioRefresco.Text)) +
                          (int.Parse(txtPizza.Text) * decimal.Parse(txtPrecioPizza.Text)) +
                          (int.Parse(txtNuggets.Text) * decimal.Parse(txtPrecioNuggets.Text)) +
                          (int.Parse(txtEnsalada.Text) * decimal.Parse(txtPrecioEnsalada.Text)) +
                          (int.Parse(txtYogurt.Text) * decimal.Parse(txtPrecioYogurt.Text)) +
                          (int.Parse(txtAgua.Text) * decimal.Parse(txtPrecioAgua.Text));
            decIVA = (decSubTotal * 21) / 100;
            decTotal = decSubTotal + decIVA;
            txtSub_Total.Text = decSubTotal.ToString("C2");
            txtIVA.Text = decIVA.ToString("C2");
            txtTotal_Pagar.Text = decTotal.ToString("C2");
            txtPago.Text = "";
            txtCambio.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Opción Pizza, nuggets y refresco
            txtHamburguesa.Enabled = false;
            txtPapas.Enabled = false;
            txtRefresco.Enabled = false;
            txtPizza.Enabled = false;
            txtNuggets.Enabled = false;
            txtEnsalada.Enabled = false;
            txtYogurt.Enabled = false;
            txtAgua.Enabled = false;
            txtHamburguesa.Text = 0.ToString();
            txtPapas.Text = 0.ToString();
            txtRefresco.Text = 1.ToString();
            txtPizza.Text = 1.ToString();
            txtNuggets.Text = 1.ToString();
            txtEnsalada.Text = 0.ToString();
            txtYogurt.Text = 0.ToString();
            txtAgua.Text = 0.ToString();
            decimal decSubTotal, decIVA, decTotal;
            decSubTotal = (int.Parse(txtHamburguesa.Text) * decimal.Parse(txtPrecioHamburguesa.Text)) +
                          (int.Parse(txtPapas.Text) * decimal.Parse(txtPrecioPapas.Text)) +
                          (int.Parse(txtRefresco.Text) * decimal.Parse(txtPrecioRefresco.Text)) +
                          (int.Parse(txtPizza.Text) * decimal.Parse(txtPrecioPizza.Text)) +
                          (int.Parse(txtNuggets.Text) * decimal.Parse(txtPrecioNuggets.Text)) +
                          (int.Parse(txtEnsalada.Text) * decimal.Parse(txtPrecioEnsalada.Text)) +
                          (int.Parse(txtYogurt.Text) * decimal.Parse(txtPrecioYogurt.Text)) +
                          (int.Parse(txtAgua.Text) * decimal.Parse(txtPrecioAgua.Text));
            decIVA = (decSubTotal * 21) / 100;
            decTotal = decSubTotal + decIVA;
            txtSub_Total.Text = decSubTotal.ToString("C2");
            txtIVA.Text = decIVA.ToString("C2");
            txtTotal_Pagar.Text = decTotal.ToString("C2");
            txtPago.Text = "";
            txtCambio.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Opción Ensalada, yogurt y agua
            txtHamburguesa.Enabled = false;
            txtPapas.Enabled = false;
            txtRefresco.Enabled = false;
            txtPizza.Enabled = false;
            txtNuggets.Enabled = false;
            txtEnsalada.Enabled = false;
            txtYogurt.Enabled = false;
            txtAgua.Enabled = false;
            txtHamburguesa.Text = 0.ToString();
            txtPapas.Text = 0.ToString();
            txtRefresco.Text = 0.ToString();
            txtPizza.Text = 0.ToString();
            txtNuggets.Text = 0.ToString();
            txtEnsalada.Text = 1.ToString();
            txtYogurt.Text = 1.ToString();
            txtAgua.Text = 1.ToString();
            decimal decSubTotal, decIVA, decTotal;
            decSubTotal = (int.Parse(txtHamburguesa.Text) * decimal.Parse(txtPrecioHamburguesa.Text)) +
                          (int.Parse(txtPapas.Text) * decimal.Parse(txtPrecioPapas.Text)) +
                          (int.Parse(txtRefresco.Text) * decimal.Parse(txtPrecioRefresco.Text)) +
                          (int.Parse(txtPizza.Text) * decimal.Parse(txtPrecioPizza.Text)) +
                          (int.Parse(txtNuggets.Text) * decimal.Parse(txtPrecioNuggets.Text)) +
                          (int.Parse(txtEnsalada.Text) * decimal.Parse(txtPrecioEnsalada.Text)) +
                          (int.Parse(txtYogurt.Text) * decimal.Parse(txtPrecioYogurt.Text)) +
                          (int.Parse(txtAgua.Text) * decimal.Parse(txtPrecioAgua.Text));
            decIVA = (decSubTotal * 21) / 100;
            decTotal = decSubTotal + decIVA;
            txtSub_Total.Text = decSubTotal.ToString("C2");
            txtIVA.Text = decIVA.ToString("C2");
            txtTotal_Pagar.Text = decTotal.ToString("C2");
            txtPago.Text = "";
            txtCambio.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Opción Otras opciones
            txtHamburguesa.Enabled = true;
            txtPapas.Enabled = true;
            txtRefresco.Enabled = true;
            txtPizza.Enabled = true;
            txtNuggets.Enabled = true;
            txtEnsalada.Enabled = true;
            txtYogurt.Enabled = true;
            txtAgua.Enabled = true;
            txtHamburguesa.Text = 0.ToString();
            txtPapas.Text = 0.ToString();
            txtRefresco.Text = 0.ToString();
            txtPizza.Text = 0.ToString();
            txtNuggets.Text = 0.ToString();
            txtEnsalada.Text = 0.ToString();
            txtYogurt.Text = 0.ToString();
            txtAgua.Text = 0.ToString();
            decimal decSubTotal, decIVA, decTotal;
            decSubTotal = (int.Parse(txtHamburguesa.Text) * decimal.Parse(txtPrecioHamburguesa.Text)) +
                          (int.Parse(txtPapas.Text) * decimal.Parse(txtPrecioPapas.Text)) +
                          (int.Parse(txtRefresco.Text) * decimal.Parse(txtPrecioRefresco.Text)) +
                          (int.Parse(txtPizza.Text) * decimal.Parse(txtPrecioPizza.Text)) +
                          (int.Parse(txtNuggets.Text) * decimal.Parse(txtPrecioNuggets.Text)) +
                          (int.Parse(txtEnsalada.Text) * decimal.Parse(txtPrecioEnsalada.Text)) +
                          (int.Parse(txtYogurt.Text) * decimal.Parse(txtPrecioYogurt.Text)) +
                          (int.Parse(txtAgua.Text) * decimal.Parse(txtPrecioAgua.Text));
            decIVA = (decSubTotal * 21) / 100;
            decTotal = decSubTotal + decIVA;
            txtSub_Total.Text = decSubTotal.ToString("C2");
            txtIVA.Text = decIVA.ToString("C2");
            txtTotal_Pagar.Text = decTotal.ToString("C2");
            txtPago.Text = "";
            txtCambio.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botón Pagar
            decimal decCambio, decPago;
            bool bolConvertir;
            string textoPago, textoTotal;
            decimal decSubTotal, decIVA, decTotal;
            decSubTotal = (int.Parse(txtHamburguesa.Text) * decimal.Parse(txtPrecioHamburguesa.Text)) +
                          (int.Parse(txtPapas.Text) * decimal.Parse(txtPrecioPapas.Text)) +
                          (int.Parse(txtRefresco.Text) * decimal.Parse(txtPrecioRefresco.Text)) +
                          (int.Parse(txtPizza.Text) * decimal.Parse(txtPrecioPizza.Text)) +
                          (int.Parse(txtNuggets.Text) * decimal.Parse(txtPrecioNuggets.Text)) +
                          (int.Parse(txtEnsalada.Text) * decimal.Parse(txtPrecioEnsalada.Text)) +
                          (int.Parse(txtYogurt.Text) * decimal.Parse(txtPrecioYogurt.Text)) +
                          (int.Parse(txtAgua.Text) * decimal.Parse(txtPrecioAgua.Text));
            decIVA = (decSubTotal * 21) / 100;
            decTotal = decSubTotal + decIVA;
            txtSub_Total.Text = decSubTotal.ToString("C2");
            txtIVA.Text = decIVA.ToString("C2");
            txtTotal_Pagar.Text = decTotal.ToString("C2");
            bolConvertir = decimal.TryParse(txtPago.Text, out decPago);
            if (!bolConvertir)
            {
                MessageBox.Show("Ingrese el pago");
            }
            else
            {
                txtPago.Text = decPago.ToString();
            }
            if (txtPago.Text != "" && txtTotal_Pagar.Text != "")
            {
                if (txtPago.Text.Contains(","))
                {
                    textoPago = txtPago.Text.Remove((txtPago.Text.Length) - 1);
                    textoTotal = txtTotal_Pagar.Text.Remove((txtTotal_Pagar.Text.Length) - 1);
                    decCambio = decimal.Parse(textoPago) - decimal.Parse(textoTotal);
                    txtCambio.Text = decCambio.ToString() + " €";
                }else { MessageBox.Show("Debe introducir los decimales"); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPago.Text = "";
            txtCambio.Text = "";
        }
    }
}
