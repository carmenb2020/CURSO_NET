using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente_Mayor
{
    //La clase Cliente hereda de la clase Persona
    class Cliente : Persona
    {
        decimal _decLimiteCredito;
        public decimal LimiteCredito
        {
            get { return _decLimiteCredito; }
            set { _decLimiteCredito = value; }
        }

        // Método público para determinar si es mayor de edad
        public bool EsMayorEdad()
        {
            // Variable local
            int intEdad;
            // Invoca el método CalcularEdad() de la clase base
            intEdad = base.CalcularEdad();
            if (intEdad >= 18) return (true);
            else return (false);
        }

    }
}
