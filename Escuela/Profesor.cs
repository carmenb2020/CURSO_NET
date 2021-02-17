using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    class Profesor : Persona
    {
        private double dblSueldo;
        public double Sueldo{get;set;}

        public string Enseñar()
        {
            string strEnseñar;
            strEnseñar = "está enseñando";
            return strEnseñar;
        }
    }
}
