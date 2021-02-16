using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class Form1 : Form
    {
        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        bool validarTextBoxs()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        //Codigo comprobacion  de textbox
                        if (item.Text == "")
                        {
                            MessageBox.Show("Hay campos vacios");
                            item.Focus();
                            return false;
                        }
                    }
                    else if (item is RichTextBox)
                    {
                        //codigo comprobacion de richtextbox
                        if (item.Text == "")
                        {
                            MessageBox.Show("Hay campos vacios");
                            item.Focus();
                            return false;
                        }
                    }
                    else if (item is ComboBox)
                    {
                        if (item.Text == "")
                        {
                            MessageBox.Show("Debes seleccionar un item");
                            item.Focus();
                            return false;
                        }
                    }
                }
                catch { }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bolConvertir;
            int intSalarioDia, intDiasLaborados;
            bolConvertir = Int32.TryParse(txtSalarioDia.Text, out intSalarioDia);

            if (validarTextBoxs())
            {
                if (!bolConvertir)
                {
                    MessageBox.Show("Ingrese el salario diario");
                }
                else
                {
                    bolConvertir = Int32.TryParse(txtDiasLaborados.Text, out intDiasLaborados);
                    if (!bolConvertir)
                    {
                        MessageBox.Show("Ingrese los días laborados");
                    }
                    else
                    {
                        myEmpleado.Nombre = txtNombre.Text;
                        myEmpleado.Identificacion = txtIdentificacion.Text;
                        myEmpleado.AsignacionDia = intSalarioDia; ;
                        myNomina.DiasLaborados = intDiasLaborados;
                        MessageBox.Show("Se guardó el registro correctamente");
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool bolConvertir;
            int intSalarioDia, intDiasLaborados;
            bolConvertir = Int32.TryParse(txtSalarioDia.Text, out intSalarioDia);

            if (validarTextBoxs())
            {
                if (!bolConvertir)
                {
                    MessageBox.Show("Ingrese el salario diario");
                }
                else
                {
                    bolConvertir = Int32.TryParse(txtDiasLaborados.Text, out intDiasLaborados);
                    if (!bolConvertir)
                    {
                        MessageBox.Show("Ingrese los días laborados");
                    }
                    else
                    {
                        txtTotalDevengado.Text = myNomina.CalcularNomina(Convert.ToInt32(myNomina.DiasLaborados),
                        Convert.ToDecimal(myEmpleado.AsignacionDia)).ToString();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Text = String.Empty);
            txtNombre.Focus();
            txtTotalDevengado.Text = "0";
        }
    }
}
