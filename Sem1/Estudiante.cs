using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sem1
{
    public class Estudiante : Persona  {

        public void Estudiar(){
            Console.WriteLine("Estoy estudiando");
        }

        public void VerEdad(){
            Console.WriteLine("Mi edad es "+ this.Edad+" años");
        }
    }
}