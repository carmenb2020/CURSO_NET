using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    /// <summary>
    /// Clase Libro, subclase de Producto
    /// </summary>
    class Libro:Producto
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private string _strMAutor;
        private string _strMISBN;
        /// <summary>
        /// Propiedades
        /// </summary>
        /// <param name="Codigo"></param>
        /// <param name="Descripcion"></param>
        /// <param name="Precio"></param>
        /// <param name="Autor"></param>
        /// <param name="ISBN"></param>
        public Libro(string Codigo, string Descripcion, double Precio, string Autor, string ISBN): base(Codigo, Descripcion, Precio)
        {
            _strMAutor = Autor;
            _strMISBN = ISBN;
        }
        public string strMAutor
        {
            get { return _strMAutor; }
            set { _strMAutor = value; }
        }
        public string strMISBN
        {
            get { return _strMISBN; }
            set { _strMISBN = value; }
        }
    }
}
