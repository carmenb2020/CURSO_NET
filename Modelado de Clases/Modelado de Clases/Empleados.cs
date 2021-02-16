using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelado_de_Clases
{
    public class Empleados : PersonasEmpresa
    {
        private int _Sueldo_base;
        public int PSueldo_base
        {
            get
            {
                return (_Sueldo_base);
            }
            set
            {
                _Sueldo_base = value;
            }
        }

        public string MostrarDatosEmpleados()
        {
            return ("\n Sueldo Base: " + _Sueldo_base);
        }
    }
}