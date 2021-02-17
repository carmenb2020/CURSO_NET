using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    
    public partial class Form1 : Form
    {
        //Variables globales
        //Inicializamos las clases sin instanciar aún
        Profesor miProfesor;
        Estudiante miEstudiante;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void radEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            textSueldo.Enabled = false;
            textCalificacion.Enabled = true;
            textSueldo.Clear();
        }

        private void buttonCapturarDatos_Click(object sender, EventArgs e)
        {
            if (radProfesor.Checked)
            {
                //Instanciamos un objeto de la clase profesor y le asignamos los valores a los atributos
                miProfesor = new Profesor();
                miProfesor.Nombre = textNombre.Text;
                miProfesor.Sueldo = Convert.ToDouble(textSueldo.Text);
            }
            else
            {
                //Instanciamos un nuevo estudiante y le asignamos los valores a los atributos
                miEstudiante = new Estudiante();
                miEstudiante.Nombre = textNombre.Text;
                miEstudiante.Calificacion = Convert.ToInt32(textCalificacion.Text);
            }
            MessageBox.Show("Datos ingresados");
        }

        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {
            if (radProfesor.Checked)
            {
                MessageBox.Show("Nombre: "+ miProfesor.Nombre +"\n"+
                    "Sueldo: " + miProfesor.Sueldo + "\n"+
                    miProfesor.Nombre + " "+ miProfesor.Asistir()+"\n"+
                    miProfesor.Nombre + " " + miProfesor.Enseñar());
            }
            else
            {
                MessageBox.Show("Nombre: " + miEstudiante.Nombre + "\n" +
                    "Calificación: " + miEstudiante.Calificacion + "\n" +
                    miEstudiante.Nombre + " " + miEstudiante.Asistir() + "\n" +
                    miEstudiante.Nombre + " " + miEstudiante.Estudiar());
            }
        }

        private void radProfesor_CheckedChanged_1(object sender, EventArgs e)
        {
            textCalificacion.Enabled = false;
            textSueldo.Enabled = true;
            textCalificacion.Clear();
        }
    }
}

