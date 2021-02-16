using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelado_de_Clases
{
    public abstract class PersonasEmpresa : Empresa
    {
        public DateTime _Fecha_nacimiento;
        public string _Nombre;

        public DateTime PFecha_nacimiento
        {
            get
            {
                return (_Fecha_nacimiento);
            }
            set
            {
                _Fecha_nacimiento = value;
            }
        }

        public string PNombre
        {
            get
            {
                return (_Nombre);
            }
            set
            {
                _Nombre = value;
            }
        }

        /*public DateTime CalcularEdad()
        {
            return _Fecha_nacimiento;
        }*/

        public string MostrarDatosPersonas()
        {
            return ("\n Nombre: " + _Nombre + "\n Fecha de Nacimiento: " + _Fecha_nacimiento);
        }
    }
}