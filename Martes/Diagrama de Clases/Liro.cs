using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrama_de_Clases
{
    public class Liro
    {
        private int IS;
        private int TITULO;
        private int ESCRITOR;

        public string Alquilar()
        {
            return("Alquilado");
        }

        public void Veder()
        {
            throw new System.NotImplementedException();
        }

        public void Leer()
        {
            throw new System.NotImplementedException();
        }
    }
}