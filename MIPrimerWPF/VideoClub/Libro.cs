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
        private string _strMIsbn;
        /// <summary>
        /// Propiedades
        /// </summary>
        /// <param name="Codigo"></param>
        /// <param name="Descripcion"></param>
        /// <param name="Precio"></param>
        /// <param name="Autor"></param>
        /// <param name="ISBN"></param>
        public Libro(string Codigo,double Precio, string Descripcion, string Autor, string ISBN): base(Codigo, Precio, Descripcion)
        {
            _strMAutor = Autor;
            _strMIsbn = ISBN;
        }
        public string MAutor
        {
            get { return _strMAutor; }
            set { _strMAutor = value; }
        }
        public string MISBN
        {
            get { return _strMIsbn; }
            set { _strMIsbn = value; }
        }
    }
}
