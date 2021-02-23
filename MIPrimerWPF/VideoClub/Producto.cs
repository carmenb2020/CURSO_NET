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
        private double _dblMPrecio;
        private string _strMDescripcion;
        
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="Codigo"></param>
        /// <param name="Descripcion"></param>
        /// <param name="Precio"></param>
        public Producto(string Codigo, double Precio, string Descripcion)
        {
            _strMCodigo = Codigo;
            _dblMPrecio = Precio;
            _strMDescripcion = Descripcion;
        }

        /// <summary>
        /// Propiedades
        /// </summary>
        public string MCodigo
        {
            get { return _strMCodigo; }
            set { _strMCodigo = value; }
        }
        public string MDescripcion
        {
            get { return _strMDescripcion; }
            set { _strMDescripcion = value; }
        }
        public double MPrecio
        {
            get { return _dblMPrecio; }
            set { _dblMPrecio = value; }
        }
    }
}
