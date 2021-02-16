using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1
{
    public class Persona
    {
        protected string nombre;
        protected int edad;
        protected string apellidos;

        public string Nombre { get => nombre; set => nombre = value; }//SetNombre
        public int Edad { get => edad; set => edad = value; }//SetEdad
        public string Apellidos { get => apellidos; set => apellidos = value; }//SetApellido

        public void Inicializar() {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese los apellidos: ");
            apellidos = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad: ");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir() {
            Console.Write("Nombre: ");
            Console.WriteLine(nombre);
            Console.Write("Apellidos: ");
            Console.WriteLine(apellidos);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
        }

        public void EsMayorEdad() {
            if (edad>=18) {
                Console.Write("Es mayor de edad");
            }
            else {
                Console.Write("No es mayor de edad");
            }
            Console.ReadKey();
        }

        public void Saludar() {
            Console.WriteLine("Hola");
        }

        public void ModificarDatos(string nombre, int edad)
        {
            this.nombre=nombre;
            this.edad = edad;
        }
    }
}
