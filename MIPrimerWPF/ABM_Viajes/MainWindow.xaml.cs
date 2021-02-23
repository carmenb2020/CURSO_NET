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


namespace ABM_Viajes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string _strPersonas;
        public MainWindow()
        {
            InitializeComponent();
            dtmFechaSalida.SelectedDate = DateTime.Today;
            dtmFechaLlegada.SelectedDate = DateTime.Today;
        }
                
        private void ClearTextBoxes(DependencyObject parentDependencyObject)
        {
            int visualChildrenCount = VisualTreeHelper.GetChildrenCount(parentDependencyObject);
            for (int i = 0; i < visualChildrenCount; i++)
            {
                // Retrieve child visual 
                DependencyObject dependencyObject = VisualTreeHelper.GetChild(parentDependencyObject, i);

                TextBox textBox = dependencyObject as TextBox;
                if (textBox != null)
                {
                    textBox.Clear();
                }
                else
                {
                    ClearTextBoxes(dependencyObject);
                }
            }
        }
        public void AsignaValor(object sender, RoutedEventArgs e)
        {
            var li = (RadioButton)sender;
            _strPersonas = li.Content.ToString();
        }
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            try {
                string strNombre = txtNombre.Text;
                string strCorreo = txtCorreo.Text;
                if (cbEmpresa.SelectedItem == null)
                {
                    cbEmpresa.SelectedIndex = 0;
                }
                ComboBoxItem cmbItem0 = cbEmpresa.SelectedItem as ComboBoxItem;
                string strEmpresa = cmbItem0.Content.ToString();
                if (cbLugarSalida.SelectedItem == null)
                {
                    cbLugarSalida.SelectedIndex = 0;
                }
                ComboBoxItem cmbItem1 = cbLugarSalida.SelectedItem as ComboBoxItem;
                string _strOrigen = cmbItem1.Content.ToString();
                if (cbLugarLlegada.SelectedItem == null)
                {
                    cbLugarLlegada.SelectedIndex = 0;
                }
                ComboBoxItem cmbItem2 = cbLugarLlegada.SelectedItem as ComboBoxItem;
                string _strDestino = cmbItem2.Content.ToString();
                if (dtmFechaSalida.SelectedDate==null)
                {
                    dtmFechaSalida.SelectedDate = DateTime.Today;
                }
                DateTime _dtmFechaSalida = dtmFechaSalida.SelectedDate.Value;
                if (dtmFechaLlegada.SelectedDate == null)
                {
                    dtmFechaLlegada.SelectedDate = DateTime.Today;
                }
                DateTime _dtmFechaLlegada = dtmFechaLlegada.SelectedDate.Value;
                
                if (strEmpresa == null ||strEmpresa=="")
                {
                    MessageBox.Show("Debe ingresar la empresa");
                }else if (_dtmFechaLlegada == null)
                {
                    MessageBox.Show("Debe ingresar la fecha de salida");
                }else if (_dtmFechaSalida == null)
                {
                    MessageBox.Show("Debe ingresar la fecha de llegada");
                }else if (_strOrigen==null || _strOrigen=="") {
                    MessageBox.Show("Debe ingresar el lugar de salida");
                } else if (_strDestino==null ||_strDestino=="")
                {
                    MessageBox.Show("Debe ingresar el lugar de llegada");
                }if (_dtmFechaSalida==null) {
                    MessageBox.Show("Debe ingresar la fecha de salida");
                }else if (_dtmFechaLlegada == null)
                {
                    MessageBox.Show("Debe ingresar la fecha de llegada");
                }else if (_strPersonas == null)
                {
                    MessageBox.Show("Debe ingresar el número de personas");
                }else if (strNombre == null || strNombre=="")
                {
                    MessageBox.Show("Debe ingresar el nombre");
                }
                else if (strCorreo == null || strCorreo=="")
                {
                    MessageBox.Show("Debe ingresar el correo");
                }
                else if (_strOrigen == _strDestino)
                {
                    MessageBox.Show("Los lugares de salida y llegada deben ser diferentes");
                }else if (_dtmFechaLlegada < _dtmFechaSalida)
                {
                    MessageBox.Show("La fecha de llegada debe ser posterior a la de salida");
                }else if (_dtmFechaSalida < DateTime.Today)
                {
                    MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de hoy");
                }else 
                {
                    MessageBox.Show("Estimado (a) " + txtNombre.Text + "\n" +
                       "Reserva realizada para el día " + _dtmFechaSalida.ToString("dd/MM/yyyy") + "\n" +
                       "De " + _strOrigen + " a " + _strDestino + " para " + _strPersonas);
                        ClearTextBoxes(this);
                    dtmFechaSalida.SelectedDate = DateTime.Today;
                    dtmFechaLlegada.SelectedDate = DateTime.Today;

                }
            }
           catch (NullReferenceException) {MessageBox.Show("Debe ingresar todos datos"); }
           catch { MessageBox.Show("Debe ingresar las fechas"); }

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Resultado = MessageBox.Show("Desea salir?","Salir",MessageBoxButton.YesNo);
            if (Resultado == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}