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
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cmbItem = cbLugarSalida.SelectedItem as ComboBoxItem;
            string _strOrigen = cmbItem.Content.ToString();
            ComboBoxItem cmbItem1 = cbLugarLlegada.SelectedItem as ComboBoxItem;
            string _strDestino = cmbItem1.Content.ToString();
            string strIndex = "";
            var radioButton = sender as RadioButton;
            if (radioButton != null) { strIndex = radioButton.Content.ToString(); }
            MessageBox.Show("Estimado (a) " + txtNombre.Text + "\n" + 
                "Reserva realizada para el día " + dtmFechaSalida.SelectedDate.Value + "\n" + 
                "De " + _strOrigen + " a " + _strDestino + " para " + strIndex);
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
