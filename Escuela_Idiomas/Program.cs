﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_Idiomas
{
    class Program
    {
        ///<summary>
        /// Clase principal
        /// </summary>
         static void Main(string[] args)
         {
            Estudiante e1 = new Estudiante();
            
            ///<para>
            ///Pedir datos
            ///</para>
            e1.Inicializar();
            ///<para>
            ///Mostrar datos
            ///</para>
            e1.Imprimir();
            Console.WriteLine("\n");
         }
 
    }
}
