using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    /// <summary>
    /// Clase Producto - Superclase
    /// </summary>
    public abstract class Producto
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        private string _strMCodigo;
        private string _strMDescripcion;
        private double _dblMPrecio;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="Codigo"></param>
        /// <param name="Descripcion"></param>
        /// <param name="Precio"></param>
        public Producto(string Codigo, string Descripcion, double Precio)
        {
            _strMCodigo = Codigo;
            _strMDescripcion = Descripcion;
            _dblMPrecio = Precio;
        }

        /// <summary>
        /// Propiedades
        /// </summary>
        public string strMCodigo
        {
            get { return _strMCodigo; }
            set { _strMCodigo = value; }
        }
        public string strMDescripcion
        {
            get { return _strMDescripcion; }
            set { _strMDescripcion = value; }
        }
        public double strMPrecio
        {
            get { return _dblMPrecio; }
            set { _dblMPrecio = value; }
        }
    }
}
