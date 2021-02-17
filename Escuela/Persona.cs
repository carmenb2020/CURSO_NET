using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    class Persona
    {
        //Atributo
        private string strNombre;
        //Propiedades de nombre
        public string Nombre { get; set; }

        //Método para acción de asistir
        public string Asistir()
        {
            string strAsistir;
            strAsistir = "asiste a la escuela";
            return strAsistir;
        }

    }
}
