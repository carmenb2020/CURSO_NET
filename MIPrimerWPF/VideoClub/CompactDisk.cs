using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    class CompactDisk:Producto
    {
        private string _strMArtista;
        private string _strMDisco;

        public CompactDisk(string Codigo, string Descripcion, double Precio, string Artista, string Disco) : base(Codigo, Descripcion, Precio)
        {
            _strMArtista = Artista;
            _strMDisco = Disco;
        }
        public string strMArtista
        {
            get { return _strMArtista; }
            set { _strMArtista = value; }
        }
        public string strMDisco
        {
            get { return _strMDisco; }
            set { _strMDisco = value; }
        }
    }
}
