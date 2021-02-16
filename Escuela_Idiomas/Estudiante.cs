using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_Idiomas
{
    public class Estudiante
    { 
        //Atributos protected por si se van a usar varios proyectos , privated si es un solo proyecto
        ///<param>
        ///Atributos de la clase
        ///</param>
        protected string nombre, curso;
        private int edad;
        private decimal nota;
        //Métodos de propiedades para obtener los datos de los atributos
        public string Nombre { get => nombre; set => nombre = value; }//SetNombre
        public int Edad { get => edad; set => edad = value; }//SetEdad
        public decimal Nota { get => nota; set => nota = value; }//SetNota
        //Método para leer y guardar los datos de los atributos
        public void Inicializar()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad: ");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
            string linea1;
            Console.Write("Ingrese la nota: ");
            linea1 = Console.ReadLine();
            nota = decimal.Parse(linea1);
            curso = AsignarCurso(nota);
            
        }
        
        //Método para asignar el curso correspondiente de acuerdo a la nota
        static string AsignarCurso(decimal nota)
        {
            string strCurso = "";
            if (nota <40){
                strCurso = "A2";
            }else if (nota >=40 && nota<=59){
                strCurso = "B1";
            }else if (nota>=60 && nota<=74)
            {
                strCurso = "B2";
            }else if (nota>=75 && nota<=89)
            {
                strCurso = "C1";
            }else if (nota>=90 && nota<=100)
            {
                strCurso = "C2";
            }
            return strCurso;
        }

        public void Imprimir()
        {
            Console.Write("Nombre: ");
            Console.WriteLine(nombre);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
            Console.Write("Nota: ");
            Console.WriteLine(nota);
            Console.Write("Curso: ");
            Console.WriteLine(curso);
            Console.ReadKey();
        }

    }
}

