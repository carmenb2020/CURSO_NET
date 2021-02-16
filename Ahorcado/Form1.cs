using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Ahorcado : Form
    {
        public Ahorcado()
        {
            InitializeComponent();
        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {
            int intIntentos;
            int intIndice;
            int numeroAleatorio = new Random().Next(0, 9);
            string strLetra;
            string strPalabra = txtPalabra.Text;
            var strTextboxes = new List<TextBox> { txtLetra1, txtLetra2, txtLetra3, txtLetra4, txtLetra5, txtLetra6, txtLetra7, txtLetra8 };
            string[] strLetras = {"", "", "", "", "", "","", ""};
            var strPicBoxes = new List<PictureBox> { picImage1, picImage2, picImage3, picImage4, picImage5};
            string[] strPalabras = { "CARNAVAL", "AMBIENTE", "ETIQUETA", "HISTORIA", "GOBIERNO", "POLITICA", "ANIMALES", "PROYECTO", 
                "CALIENTE", "JUSTICIA" };
            if (txtPalabra.Text == "")
            {
                strPalabra = strPalabras[numeroAleatorio];
                txtPalabra.Text = strPalabra;
            }
            strPalabra = txtPalabra.Text;
            for (intIndice = 0; intIndice < 8; intIndice++)
            {
                strLetras[intIndice] = strPalabra.Substring(intIndice, 1);
            }
            intIntentos = int.Parse(txtOportunidades.Text);
            strLetra = txtLetra.Text.ToUpper();
            if (txtLetra.Text == "" && txtOportunidades.Text != "0" && txtPalabra.Text != "") { intIntentos = int.Parse(txtOportunidades.Text) - 1; }
            if (txtOportunidades.Text != "0" || (txtLetra1.Text != "" && txtLetra2.Text != "" && txtLetra3.Text != "" && txtLetra4.Text != ""
                    && txtLetra5.Text != "" && txtLetra6.Text != "" && txtLetra7.Text != "" && txtLetra8.Text != ""))
            {
                if (Array.IndexOf(strLetras, strLetra) == -1 && strLetra != "")
                {
                    intIntentos -= 1;
                    txtOportunidades.Text = intIntentos.ToString();
                    if ((!picImage1.Visible || !picImage2.Visible || !picImage3.Visible || !picImage4.Visible || !picImage5.Visible) && txtLetra.Text != "")
                    {
                        for (intIndice = 0; intIndice < 5; intIndice++)
                        {
                            if (!strPicBoxes[intIndice].Visible)
                            {
                                strPicBoxes[intIndice].Visible = true;
                                intIndice = 5;
                            }
                        }

                    }
                }
                else
                {
                    for (intIndice = 0; intIndice < 8; intIndice++)
                    {
                        if (strLetras[intIndice] == strLetra) { strTextboxes[intIndice].Text = strLetra; }
                    }
                }    
            }
            else if (txtOportunidades.Text == "0")
            {
                MessageBox.Show("Upss!! Has completado el número de intentos posibles, mira debajo del ahorcado la palabra ==> ");
                txtPalabra.Visible = true;
                if (MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }else
                {
                    txtPalabra.Text = "";
                    txtOportunidades.Text = "5";
                    txtLetra.Text = "";
                    txtLetra1.Text = "";
                    txtLetra2.Text = "";
                    txtLetra3.Text = "";
                    txtLetra4.Text = "";
                    txtLetra5.Text = "";
                    txtLetra6.Text = "";
                    txtLetra7.Text = "";
                    txtLetra8.Text = "";
                    picImage1.Visible = false;
                    picImage2.Visible = false;
                    picImage3.Visible = false;
                    picImage4.Visible = false;
                    picImage5.Visible = false;
                    txtPalabra.Visible = false;
                }
            }
            if ((txtLetra1.Text != "" && txtLetra2.Text != "" && txtLetra3.Text != "" && txtLetra4.Text != "" && txtLetra5.Text != ""
                    && txtLetra6.Text != "" && txtLetra7.Text != "" && txtLetra8.Text != "") && (txtOportunidades.Text != "0"))
            {
                MessageBox.Show("Enhorabuena!! Has acertado!!");
                if (MessageBox.Show("Desea continuar?", "Continuar", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    txtPalabra.Text = "";
                    txtOportunidades.Text = "5";
                    txtLetra.Text = "";
                    txtLetra1.Text = "";
                    txtLetra2.Text = "";
                    txtLetra3.Text = "";
                    txtLetra4.Text = "";
                    txtLetra5.Text = "";
                    txtLetra6.Text = "";
                    txtLetra7.Text = "";
                    txtLetra8.Text = "";
                    picImage1.Visible = false;
                    picImage2.Visible = false;
                    picImage3.Visible = false;
                    picImage4.Visible = false;
                    picImage5.Visible = false;
                    txtPalabra.Visible = false;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void Ahorcado_Load(object sender, EventArgs e)
        {

        }
    }
}
