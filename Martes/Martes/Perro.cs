using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martes
{
    //Clase perro

    public abstract class Perro
    {
        public decimal altura;
        public decimal peso;
        public string color;
        
        public decimal PAltura
        {
            get
            {
                return (altura);
            }
            set
            {
                altura = value;
            }
        }

        public decimal PPeso
        {
            get
            {
                return (peso);
            }
        }

        public string PColor
        {
            get
            {
                return (color);
            }
            set
            {
                color = value;
            }
        }

        //Método ladrar
        public virtual string Ladrar()
        {
            return ("Perro Ladrando");
        }
        public abstract string Dormir();
        
    }
    public class Chihuahua : Perro
    {
        public override string Ladrar()
        {
            return "Chihuahua ladrando";
        }
        public override string Dormir()
        {
            return "Chihuahua durmiendo";
        }
    }
    public class Ulldog : Perro
    {
        public override string Ladrar()
        {
            return "Ulldog ladrando";
        }
        public override string Dormir()
        {
            return "Ulldog durmiendo";
        }
    }
}
