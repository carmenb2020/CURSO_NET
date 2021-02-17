
namespace Escuela
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEstudiante = new System.Windows.Forms.RadioButton();
            this.radProfesor = new System.Windows.Forms.RadioButton();
            this.buttonCapturarDatos = new System.Windows.Forms.Button();
            this.buttonMostrarDatos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textCalificacion = new System.Windows.Forms.TextBox();
            this.textSueldo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEstudiante);
            this.groupBox1.Controls.Add(this.radProfesor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(88, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de persona";
            // 
            // radEstudiante
            // 
            this.radEstudiante.AutoSize = true;
            this.radEstudiante.Location = new System.Drawing.Point(47, 104);
            this.radEstudiante.Name = "radEstudiante";
            this.radEstudiante.Size = new System.Drawing.Size(125, 29);
            this.radEstudiante.TabIndex = 1;
            this.radEstudiante.Text = "Estudiante";
            this.radEstudiante.UseVisualStyleBackColor = true;
            this.radEstudiante.CheckedChanged += new System.EventHandler(this.radEstudiante_CheckedChanged);
            // 
            // radProfesor
            // 
            this.radProfesor.AutoSize = true;
            this.radProfesor.Checked = true;
            this.radProfesor.Location = new System.Drawing.Point(47, 60);
            this.radProfesor.Name = "radProfesor";
            this.radProfesor.Size = new System.Drawing.Size(106, 29);
            this.radProfesor.TabIndex = 0;
            this.radProfesor.TabStop = true;
            this.radProfesor.Text = "Profesor";
            this.radProfesor.UseVisualStyleBackColor = true;
            this.radProfesor.CheckedChanged += new System.EventHandler(this.radProfesor_CheckedChanged_1);
            // 
            // buttonCapturarDatos
            // 
            this.buttonCapturarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapturarDatos.Location = new System.Drawing.Point(453, 43);
            this.buttonCapturarDatos.Name = "buttonCapturarDatos";
            this.buttonCapturarDatos.Size = new System.Drawing.Size(186, 72);
            this.buttonCapturarDatos.TabIndex = 1;
            this.buttonCapturarDatos.Text = "Capturar datos";
            this.buttonCapturarDatos.UseVisualStyleBackColor = true;
            this.buttonCapturarDatos.Click += new System.EventHandler(this.buttonCapturarDatos_Click);
            // 
            // buttonMostrarDatos
            // 
            this.buttonMostrarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarDatos.Location = new System.Drawing.Point(453, 130);
            this.buttonMostrarDatos.Name = "buttonMostrarDatos";
            this.buttonMostrarDatos.Size = new System.Drawing.Size(186, 65);
            this.buttonMostrarDatos.TabIndex = 2;
            this.buttonMostrarDatos.Text = "Mostrar datos";
            this.buttonMostrarDatos.UseVisualStyleBackColor = true;
            this.buttonMostrarDatos.Click += new System.EventHandler(this.buttonMostrarDatos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textCalificacion);
            this.groupBox2.Controls.Add(this.textSueldo);
            this.groupBox2.Controls.Add(this.textNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(77, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 164);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la persona";
            // 
            // textCalificacion
            // 
            this.textCalificacion.Location = new System.Drawing.Point(141, 112);
            this.textCalificacion.MaxLength = 4;
            this.textCalificacion.Name = "textCalificacion";
            this.textCalificacion.Size = new System.Drawing.Size(71, 30);
            this.textCalificacion.TabIndex = 5;
            this.textCalificacion.Text = "0";
            // 
            // textSueldo
            // 
            this.textSueldo.Location = new System.Drawing.Point(141, 76);
            this.textSueldo.MaxLength = 8;
            this.textSueldo.Name = "textSueldo";
            this.textSueldo.Size = new System.Drawing.Size(164, 30);
            this.textSueldo.TabIndex = 4;
            this.textSueldo.Text = "0";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(141, 40);
            this.textNombre.MaxLength = 60;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(469, 30);
            this.textNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonMostrarDatos);
            this.Controls.Add(this.buttonCapturarDatos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PERSONAS DE UNA ESCUELA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radEstudiante;
        private System.Windows.Forms.RadioButton radProfesor;
        private System.Windows.Forms.Button buttonCapturarDatos;
        private System.Windows.Forms.Button buttonMostrarDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textCalificacion;
        private System.Windows.Forms.TextBox textSueldo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

