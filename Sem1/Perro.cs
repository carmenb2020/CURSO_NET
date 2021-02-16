using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1 {
    abstract class Perro {
        decimal altura;
        public decimal peso;
        string color;
        public virtual string Ladrar() {
            return "GUAU";
        }
        public abstract string Dormir();
        public decimal PAltura {
            get {
                return altura;
            }
            set {
                altura = value; 
            }
        }

        public decimal PPeso {
            get {
                return peso;
            }
            set {
                peso = value;
            }
        }

        public string PColor {
            get {
                return color;
            }
            set {
                color = value;
            }
        }

    }
    class Chihuahua : Perro {
        public override string Dormir() {
            return "Chihuahua durmiendo";
        }

        public override string Ladrar() {
            return "Chihuahua ladrando";
        }
    }

    class Bulldog : Perro {
        public override string Dormir() {
            return "Bulldog durmiendo";
        }
        public override string Ladrar() {
            return "Bulldog ladrando";
        }
    }
}
