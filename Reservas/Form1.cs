using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reservas
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
           
        }

        bool validarTextBoxs()
        {
            foreach (Control item in groupBox1.Controls)
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
                            groupBox1.Controls.OfType<Label>().ToList().ForEach(tb => tb.Visible = true);
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
                            groupBox1.Controls.OfType<Label>().ToList().ForEach(tb => tb.Visible = true);
                            return false;
                        }
                    }
                    else if (item is ComboBox)
                    {
                        if (item.Text == "")
                        {
                            MessageBox.Show("Debes seleccionar un item");
                            item.Focus();
                            groupBox1.Controls.OfType<Label>().ToList().ForEach(tb => tb.Visible = true);
                            return false;
                        }
                    }
                }
                catch { }
            }
            return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool bolConvertir;
            decimal decCosto;
            bolConvertir = decimal.TryParse(txtCosto.Text, out decCosto);

            if (validarTextBoxs())
            {
                if (dateTimeFechaReserva.Value > DateTime.Now)
                {
                    MessageBox.Show("La fecha de reserva no puede ser futura");
                }
                else if (dateTimeFechaIngreso.Value < DateTime.Today)
                {
                    MessageBox.Show("La fecha de ingreso no puede ser anterior a la fecha actual");
                }
                else if (dateTimeFechaSalida.Value <= dateTimeFechaIngreso.Value)
                {
                    MessageBox.Show("La fecha de salida debe ser posterior a la de ingreso");
                }
                else if (!bolConvertir)
                {
                    MessageBox.Show("Ingrese el costo de alojamiento");
                }
                else
                {
                    dataGridView1.Rows.Add(txtHabitacion.Text, txtCliente.Text, txtTrabajador.Text, comboBoxTipo.Text, dateTimeFechaReserva.Text,
                    dateTimeFechaIngreso.Text, dateTimeFechaSalida.Text, txtCosto.Text, txtObservacion.Text, comboBoxEstado.Text);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Text = String.Empty);
            groupBox1.Controls.OfType<ComboBox>().ToList().ForEach(tb => tb.Text = String.Empty);
            groupBox1.Controls.OfType<DateTimePicker>().ToList().ForEach(tb => tb.Value = DateTime.Today);
            groupBox1.Controls.OfType<Label>().ToList().ForEach(tb => tb.Visible = false);
            txtHabitacion.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            using (var writetext = new StreamWriter("write.txt"))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    writetext.WriteLine($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value}," +
                        $"{row.Cells[3].Value},{row.Cells[4].Value},{row.Cells[5].Value},{row.Cells[6].Value},{row.Cells[7].Value}" +
                        $"{row.Cells[8].Value},{row.Cells[9].Value}");
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
