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
        }
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            string strNombre = txtNombre.Text;
            string strCorreo = txtCorreo.Text;
            try {
                ComboBoxItem cmbItem = cbLugarSalida.SelectedItem as ComboBoxItem;
                string _strOrigen = cmbItem.Content.ToString();
                ComboBoxItem cmbItem1 = cbLugarLlegada.SelectedItem as ComboBoxItem;
                string _strDestino = cmbItem1.Content.ToString();
                DateTime _dtmFechaSalida = dtmFechaSalida.SelectedDate.Value;
                DateTime _dtmFechaLlegada = dtmFechaLlegada.SelectedDate.Value;
                if (radio1.IsChecked == true)
                {
                    _strPersonas = radio1.Content.ToString();
                }
                else if (radio2.IsChecked == true)
                {
                    _strPersonas = radio2.Content.ToString();
                }
                else if (radio3.IsChecked == true)
                {
                    _strPersonas = radio3.Content.ToString();
                }else if (radio4.IsChecked == true)
                {
                    _strPersonas = radio4.Content.ToString();
                } 
                
                if (_strPersonas == null)
                {
                    MessageBox.Show("Debe ingresar el número de personas");
                }else if (strNombre == "")
                {
                    MessageBox.Show("Debe ingresar el nombre");
                }
                else if (strCorreo == "")
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
                }
            }
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
