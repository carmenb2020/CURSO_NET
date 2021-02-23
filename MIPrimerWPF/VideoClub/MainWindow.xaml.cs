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
        public void AsignarValor(object sender, RoutedEventArgs e)
        {
            var li = (RadioButton)sender;
            _strTipo = li.Content.ToString();
        }

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ///<summary
                ///Declaración de variables locales
                ///<summary>
                string strCodigo = txtCodigo.Text;
                double dblPrecio = double.Parse(txtPrecio.Text);
                string strDescripcion = txtDescripcion.Text;
                string strArtista = txtArtista.Text;
                string strDisco = txtDisco.Text;
                string strAutor = txtAutor.Text;
                string strIsbn = txtISBN.Text;

                if (strCodigo == "")
                {
                    MessageBox.Show("Debe ingresar el código");
                }
                else if (strDescripcion == "")
                {
                    MessageBox.Show("Debe ingresar la descripción");
                }
                else if (_strTipo == null)
                {
                    MessageBox.Show("Debe indicar si es CompactDisc o Libro");
                }
                else if (_strTipo == "CompactDisc" && strArtista == "")
                {
                    MessageBox.Show("Debe ingresar el artista");
                }
                else if (_strTipo == "CompactDisc" && strDisco == "")
                {
                    MessageBox.Show("Debe ingresar el disco");
                }
                else if (_strTipo=="Libro" && strAutor == "")
                {
                    MessageBox.Show("Debe ingresar el autor");
                }
                else if (_strTipo == "Libro" && strIsbn == "")
                { 
                    MessageBox.Show("Debe ingresar el ISBN");
                }
                else if (_strTipo == "CompactDisc")
                {
                    CompactDisk myCompactDisk = new CompactDisk(strCodigo, dblPrecio, strDescripcion, strArtista, strDisco);
                    lvDatos.Items.Add(new { Codigo = myCompactDisk.MCodigo, Precio = myCompactDisk.MPrecio, Descripcion = myCompactDisk.MDescripcion, Autor_Artista = myCompactDisk.MArtista, Libro_Compact = _strTipo });
                    ClearTextBoxes(this);
                }
                else
                {
                    Libro myLibro = new Libro(strCodigo, dblPrecio, strDescripcion, strAutor, strIsbn);
                    lvDatos.Items.Add(new { Codigo = myLibro.MCodigo, Precio = myLibro.MPrecio, Descripcion = myLibro.MDescripcion, Autor_Artista = myLibro.MAutor, Libro_Compact = _strTipo });
                    ClearTextBoxes(this);
                }
            }
            catch(FormatException){ MessageBox.Show( "Debe ingresar un valor para el precio" ); }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Resultado = MessageBox.Show("Desea salir?", "Salir", MessageBoxButton.YesNo);
            if (Resultado == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
