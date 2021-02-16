using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelado_de_Clases
{
    public class Directivos : Empleados
    {
        private int _Categoria;
        public int PCategoria
        {
            get
            {
                return (_Categoria);
            }
            set
            {
                _Categoria = value;
            }
        }
        
        public string MostrarDatosDirectivos()
        {
            return ("\n Categoria: " + _Categoria);
        }
    }
}