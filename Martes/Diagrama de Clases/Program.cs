using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_de_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Liro Quijote = new Liro();
            Console.WriteLine("Quijote " + Quijote.Alquilar());
            Console.ReadLine();
        }
    }
}
