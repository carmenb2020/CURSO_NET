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

namespace VideoClub
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string _strTipo;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public void AsignarValor(object sender, RoutedEventArgs e)
        {
            var li = (RadioButton)sender;
            _strTipo = li.Content.ToString();
        }

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {
            if (_strTipo == "CompactDisk")
            {
                CompactDisk myCompactDisk = new CompactDisk(txtCodigo.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text), txtArtista.Text, txtDisco.Text);
                lvDatos.Items.Add(new { Codigo = myCompactDisk.strMCodigo, Precio = myCompactDisk.strMPrecio, Descripcion = myCompactDisk.strMDescripcion, Autor_Artista = myCompactDisk.strMArtista, Libro_Compact = _strTipo });
            }
            else
            {
                Libro myLibro = new Libro(txtCodigo.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text), txtAutor.Text, txtISBN.Text);
                lvDatos.Items.Add(new { Codigo = myLibro.strMCodigo, Precio = myLibro.strMPrecio, Descripcion = myLibro.strMDescripcion, Autor_Artista = myLibro.strMAutor, Libro_Compact = _strTipo });
            }
            
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
