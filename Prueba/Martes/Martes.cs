using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martes
{
    class Martes
    {
        static void Main(string[] args)
        {
            int numero = 5, numeroproducto, numerosuma, numeroresta;
            numeroproducto = numero * 7;
            numerosuma = numero + 7;
            numeroresta = numero - 7;
            Console.WriteLine("El producto es: " + numeroproducto);
            Console.WriteLine("La suma es: " + numerosuma);
            Console.WriteLine("La resta es: " + numeroresta);
            Console.ReadLine();
        }
    }
}
