using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martes
{
   
    //Clase principal
    class Program
    {
        //Método inicial
        static void Main(string[] args)
        {
        //Crear los ojetos
            /*Perro Fido = new Perro(); //Constructor
            Perro Arturo = new Perro();
            Perro Lola = new Perro();*/
            Chihuahua _Chihuahua1 = new Chihuahua();
            Chihuahua _Chihuahua2 = new Chihuahua();
            Ulldog _Ulldog1 = new Ulldog();
            Ulldog _Ulldog2 = new Ulldog();
            Perro[] _Perrera = { _Chihuahua1, _Chihuahua2, _Ulldog1, _Ulldog2 };
            foreach (Perro item in _Perrera)
            {
                Console.WriteLine(item.Ladrar());
                Console.WriteLine(item.Dormir());
            }
            /*Console.WriteLine("Fido dice " + Fido.Ladrar());
            Console.WriteLine("Arturo dice " + Arturo.Ladrar());
            Console.WriteLine("Lola dice " + Lola.Ladrar());
            Fido.color = "Rojo";
            Fido.altura = 5.2m;
            Fido.peso = 12;
            Console.WriteLine("El peso de Fido es "+ Fido.peso);
            Console.WriteLine("La altura de Fido es " + Fido.altura);
            Console.WriteLine("El color de Fido es " + Fido.color);*/
            //Detener la ejecución hasta leer una tecla
            Console.ReadLine();
        }
    }
}
