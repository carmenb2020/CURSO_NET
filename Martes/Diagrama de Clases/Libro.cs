using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrama_de_Clases
{
    public class Libro
    {
        private string ISBN;
        private string TITULO;
        private string ESCRITOR;

        public string Alquilar()
        {
            return("Alquilado");
        }

        public void Vender()
        {
            throw new System.NotImplementedException();
        }

        public void Leer()
        {
            throw new System.NotImplementedException();
        }
    }
}