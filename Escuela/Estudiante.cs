using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    class Estudiante:Persona
    {
        private int intCalificacion;
        
        public int Calificacion { get; set; }

        public string Estudiar()
        {
            string strEstudiar;
            strEstudiar = "está estudiando";
            return strEstudiar;
        }
    }
}
