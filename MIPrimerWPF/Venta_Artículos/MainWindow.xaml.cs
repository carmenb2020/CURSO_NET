using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Venta_Artículos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int _intDescuento;
        public int _intIVA;
        public int _intPrecioUni;
        public int _intCantidad;
        public int _intPagado;
        public int _intRegistros = 0;

        public MainWindow()
        {
            InitializeComponent();
            dtmFecha.SelectedDate = DateTime.Today;

        }
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            dtmFecha.SelectedDate = DateTime.Today;
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtIVA.Text = "";
            txtCantidad.Text = "";
            txtPrecioUni.Text = "";
            txtPagado.Text = "";
            txtTotal.Text = "";
        }

        private void btSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btAgregar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dtmFecha.SelectedDate == null)
                {
                    dtmFecha.SelectedDate = DateTime.Today;
                }
                DateTime _dtmFecha = dtmFecha.SelectedDate.Value;
                string _txtDescripcion = txtDescripcion.Text;
                if (_txtDescripcion == "")
                {
                    MessageBox.Show("Debe ingresar la descripción");
                }
                else
                {
                    string _txtNombre = txtNombre.Text;
                    if (_txtNombre == "")
                    {
                        MessageBox.Show("Debe ingresar el nombre");
                    }
                    else if (cbDescuento.SelectedItem == null)
                    {
                        cbDescuento.SelectedIndex = 0;
                    }
                    ComboBoxItem cmbItem0 = cbDescuento.SelectedItem as ComboBoxItem;
                    string _strDescuento = cmbItem0.Content.ToString().Substring(0, 2);
                    _intDescuento = Int32.Parse(_strDescuento);
                    string _strIVA = txtIVA.Text;
                    if (!Int32.TryParse(_strIVA, out _intIVA))
                    {
                        MessageBox.Show("Debe ingresar un valor para el IVA");
                    }
                    else
                    {
                        _intIVA = Int32.Parse(_strIVA);
                        string _strCantidad = txtCantidad.Text;
                        if (!Int32.TryParse(_strCantidad, out _intCantidad))
                        {
                            MessageBox.Show("Debe ingresar un valor para la cantidad");
                        }
                        else
                        {
                            _intCantidad = Int32.Parse(_strDescuento);
                            string _strPrecioUni = txtPrecioUni.Text;
                            if (!Int32.TryParse(_strPrecioUni, out _intPrecioUni))
                            {
                                MessageBox.Show("Debe ingresar el precio unitario");
                            }
                            else
                            {
                                _intPrecioUni = Int32.Parse(_strPrecioUni);
                                string _strPagado = txtPagado.Text;
                                if (!Int32.TryParse(_strPagado, out _intPagado))
                                {
                                    MessageBox.Show("Debe ingresar el valor pagado");
                                }
                                else
                                {
                                    _intPagado = Int32.Parse(_strPagado);
                                    lvDatos.Items.Add(new { Nombre = txtNombre.Text, Venta = txtCantidad.Text, PecUni = txtPrecioUni.Text, Descuento = _strDescuento });
                                     _intRegistros += 1;
                                    txtTotalRegistros.Text = _intRegistros.ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch { MessageBox.Show("Faltan datos por ingresar"); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int _intTotal;
            if (cbDescuento.SelectedItem == null)
            {
                cbDescuento.SelectedIndex = 0;
            }
            ComboBoxItem cmbItem0 = cbDescuento.SelectedItem as ComboBoxItem;
            string _strDescuento = cmbItem0.Content.ToString().Substring(0, 2);
            _intDescuento = Int32.Parse(_strDescuento);
            string _strIVA = txtIVA.Text;
            if (!Int32.TryParse(_strIVA, out _intIVA))
            {
                MessageBox.Show("Debe ingresar un valor para el IVA");
            }
            else
            {
                _intIVA = Int32.Parse(_strIVA);
                string _strCantidad = txtCantidad.Text;
                if (!Int32.TryParse(_strCantidad, out _intCantidad))
                {
                    MessageBox.Show("Debe ingresar un valor para la cantidad");
                }
                else
                {
                    _intCantidad = Int32.Parse(_strDescuento);
                    string _strPrecioUni = txtPrecioUni.Text;
                    if (!Int32.TryParse(_strPrecioUni, out _intPrecioUni))
                    {
                        MessageBox.Show("Debe ingresar el precio unitario");
                    }
                    else
                    {
                        _intPrecioUni = Int32.Parse(_strPrecioUni);

                        _intTotal = (_intCantidad * _intPrecioUni) - ((_intCantidad * _intPrecioUni) * _intDescuento / 100) - ((_intCantidad * _intPrecioUni) * _intIVA / 100);
                        txtTotal.Text = _intTotal.ToString();
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PrintDialog pDialog = new PrintDialog();
            pDialog.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                lvDatos.Items.RemoveAt(lvDatos.SelectedIndex);
                lvDatos.Items.Refresh();
                _intRegistros -= 1;
                txtTotalRegistros.Text = _intRegistros.ToString();
            }
            catch { MessageBox.Show("Debe escoger la fila que desea borrar"); };
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PrintDialog pDialog = new PrintDialog();
            pDialog.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lvDatos.Items.Clear();
            txtTotalRegistros.Text = "0";
        }
    }
}