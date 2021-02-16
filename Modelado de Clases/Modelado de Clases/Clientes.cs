using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelado_de_Clases
{
    public class Clientes : PersonasEmpresa
    {
        public int _Telefono; 
        public int PTelefono
        {
            get
            {
                return (_Telefono);
            }
            set
            {
                _Telefono = value;
            }
        }
        public string MostrarDatosClientes()
        {
            return ("\n Teléfono: " + _Telefono);
        }
    }
}