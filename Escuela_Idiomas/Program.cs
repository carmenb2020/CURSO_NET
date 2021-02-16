using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_Idiomas
{
    class Program
    {
         static void Main(string[] args)
         {
            Estudiante e1 = new Estudiante();
        
            e1.Inicializar();
            e1.Imprimir();
            
            Console.WriteLine("\n");
        }
    }
}
