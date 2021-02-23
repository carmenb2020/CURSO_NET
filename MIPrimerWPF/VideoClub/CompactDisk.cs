using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    /// <summary>
    /// Clase CompactDisk, subclase de Producto
    /// </summary>
    class CompactDisk:Producto
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private string _strMArtista;
        private string _strMDisco;

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="Codigo"></param>
        /// <param name="Descripcion"></param>
        /// <param name="Precio"></param>
        /// <param name="Artista"></param>
        /// <param name="Disco"></param>
        public CompactDisk(string Codigo, double Precio, string Descripcion, string Artista, string Disco) : base(Codigo, Precio, Descripcion)
        {
            _strMArtista = Artista;
            _strMDisco = Disco;
        }
        public string MArtista
        {
            get { return _strMArtista; }
            set { _strMArtista = value; }
        }
        public string MDisco
        {
            get { return _strMDisco; }
            set { _strMDisco = value; }
        }
    }
}
