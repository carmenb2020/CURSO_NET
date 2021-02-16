using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelado_de_Clases
{
    public class Empresa
    {
        public string _NombreEmpresa;
        public string _NIF;

        public string PNombreEmpresa
        {
            get
            {
                return (_NombreEmpresa);
            }
            set
            {
                _NombreEmpresa = value;
            }
        }

        public string PNIF
        {
            get
            {
                return (_NIF);
            }
            set
            {
                _NIF = value;
            }
        }

        public string MostrarNombreEmpresa()
        {
            return ("Empresa: " + _NombreEmpresa);
        }

    }
}