using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejemploPerro();
            //ejercicio1Persona();
            ejercicioEstuProf();
        }

        private static void ejercicioEstuProf()
        {
            Estudiante e1=new Estudiante();
            //e1.Edad = 15;
            //e1.Nombre = "Paco";
            //e1.Apellidos = "Suárez Fernández";
            e1.Inicializar();
            e1.Saludar();
            e1.Imprimir();
            e1.VerEdad();
            e1.Estudiar();

            Console.WriteLine("\n");

            Profesor p1 = new Profesor();
            //p1.Edad = 37;
            //p1.Nombre = "Ana";
            //p1.Apellidos = "Marina García";
            p1.Inicializar();
            p1.Saludar();
            Console.WriteLine("Soy " + p1.Nombre + " " + p1.Apellidos);
            p1.Explicar();

            Console.ReadKey();
        }

        private static void ejercicio1Persona()
        {
            Persona per1 = new Persona();
            per1.Inicializar();
            per1.Imprimir();
            per1.EsMayorEdad();
        }

        static void ejemploPerro() {

            Perro fido = new Chihuahua();//cambiamos de tipo Perro a hijos al hacer esa clase abstracta
            Perro arturo = new Bulldog();
            Perro lola = new Bulldog();
            
            Console.WriteLine("Fido dice " + fido.Ladrar());
            Console.WriteLine("Arturo dice " + arturo.Ladrar());
            Console.WriteLine("Lola dice " + lola.Ladrar());

            fido.PColor = "ROJO";
            fido.PAltura = 5.2m;//OJO: se pone la m al final para indicar que es decimal, es necesario
            fido.peso = 12;

            Console.WriteLine("\nFido es de color " + fido.PColor);
            Console.WriteLine("Fido mide " + fido.PAltura);
            Console.WriteLine("Fido pesa " + fido.PPeso+"\n");

            Chihuahua chui = new Chihuahua();
            Chihuahua chiwaka = new Chihuahua();
            Bulldog bull = new Bulldog();
            Bulldog bowl = new Bulldog();

            Perro[] Perrera = {chui, chiwaka, bull, bowl};
            foreach (Perro item in Perrera) {
                Console.WriteLine(item.Ladrar());
                Console.WriteLine(item.Dormir()+"\n");
            }

            //Ponemos al final para mantener consola abierta
            Console.ReadLine();

        }
    }
}
