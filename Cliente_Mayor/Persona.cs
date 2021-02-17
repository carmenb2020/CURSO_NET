using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente_Mayor
{
    ///<summary>
    ///Clase principal
    ///</summary>
    class Persona
    {
        // Atributos privados 
        private string _strNombre;
        private DateTime _dtmFechaNacimiento;
        // Propiedades públicas
        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }
        // Método público para calcular la edad
        public int CalcularEdad()
        {
            int intEdad; TimeSpan intervalo;
            intervalo = DateTime.Now - this.FechaNacimiento;
            intEdad = (int)(intervalo.Days / 365.25);
            return (intEdad);
        }
    }
}
