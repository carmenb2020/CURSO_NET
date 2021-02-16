
namespace Password
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVertical1 = new System.Windows.Forms.TextBox();
            this.txtVertical2 = new System.Windows.Forms.TextBox();
            this.txtVertical3 = new System.Windows.Forms.TextBox();
            this.txtVertical4 = new System.Windows.Forms.TextBox();
            this.txtVertical5 = new System.Windows.Forms.TextBox();
            this.txtArriba1 = new System.Windows.Forms.TextBox();
            this.txtArriba2 = new System.Windows.Forms.TextBox();
            this.txtAbajo4 = new System.Windows.Forms.TextBox();
            this.txtAbajo1 = new System.Windows.Forms.TextBox();
            this.txtAbajo2 = new System.Windows.Forms.TextBox();
            this.txtAbajo3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIntentos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVertical1
            // 
            this.txtVertical1.Location = new System.Drawing.Point(391, 60);
            this.txtVertical1.Name = "txtVertical1";
            this.txtVertical1.Size = new System.Drawing.Size(45, 22);
            this.txtVertical1.TabIndex = 0;
            this.txtVertical1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtVertical2
            // 
            this.txtVertical2.Location = new System.Drawing.Point(391, 118);
            this.txtVertical2.Name = "txtVertical2";
            this.txtVertical2.Size = new System.Drawing.Size(45, 22);
            this.txtVertical2.TabIndex = 1;
            // 
            // txtVertical3
            // 
            this.txtVertical3.Location = new System.Drawing.Point(391, 179);
            this.txtVertical3.Name = "txtVertical3";
            this.txtVertical3.Size = new System.Drawing.Size(45, 22);
            this.txtVertical3.TabIndex = 2;
            // 
            // txtVertical4
            // 
            this.txtVertical4.Location = new System.Drawing.Point(391, 248);
            this.txtVertical4.Name = "txtVertical4";
            this.txtVertical4.Size = new System.Drawing.Size(45, 22);
            this.txtVertical4.TabIndex = 3;
            // 
            // txtVertical5
            // 
            this.txtVertical5.Location = new System.Drawing.Point(391, 312);
            this.txtVertical5.Name = "txtVertical5";
            this.txtVertical5.Size = new System.Drawing.Size(45, 22);
            this.txtVertical5.TabIndex = 4;
            // 
            // txtArriba1
            // 
            this.txtArriba1.Location = new System.Drawing.Point(479, 118);
            this.txtArriba1.Name = "txtArriba1";
            this.txtArriba1.Size = new System.Drawing.Size(40, 22);
            this.txtArriba1.TabIndex = 5;
            // 
            // txtArriba2
            // 
            this.txtArriba2.Location = new System.Drawing.Point(561, 118);
            this.txtArriba2.Name = "txtArriba2";
            this.txtArriba2.Size = new System.Drawing.Size(43, 22);
            this.txtArriba2.TabIndex = 6;
            // 
            // txtAbajo4
            // 
            this.txtAbajo4.Location = new System.Drawing.Point(472, 248);
            this.txtAbajo4.Name = "txtAbajo4";
            this.txtAbajo4.Size = new System.Drawing.Size(47, 22);
            this.txtAbajo4.TabIndex = 7;
            // 
            // txtAbajo1
            // 
            this.txtAbajo1.Location = new System.Drawing.Point(148, 251);
            this.txtAbajo1.Name = "txtAbajo1";
            this.txtAbajo1.Size = new System.Drawing.Size(54, 22);
            this.txtAbajo1.TabIndex = 8;
            // 
            // txtAbajo2
            // 
            this.txtAbajo2.Location = new System.Drawing.Point(234, 251);
            this.txtAbajo2.Name = "txtAbajo2";
            this.txtAbajo2.Size = new System.Drawing.Size(57, 22);
            this.txtAbajo2.TabIndex = 9;
            // 
            // txtAbajo3
            // 
            this.txtAbajo3.Location = new System.Drawing.Point(322, 248);
            this.txtAbajo3.Name = "txtAbajo3";
            this.txtAbajo3.Size = new System.Drawing.Size(48, 22);
            this.txtAbajo3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Comprobar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 27);
            this.button2.TabIndex = 12;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Intentos";
            // 
            // txtIntentos
            // 
            this.txtIntentos.Location = new System.Drawing.Point(677, 20);
            this.txtIntentos.Name = "txtIntentos";
            this.txtIntentos.Size = new System.Drawing.Size(41, 22);
            this.txtIntentos.TabIndex = 14;
            this.txtIntentos.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIntentos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAbajo3);
            this.Controls.Add(this.txtAbajo2);
            this.Controls.Add(this.txtAbajo1);
            this.Controls.Add(this.txtAbajo4);
            this.Controls.Add(this.txtArriba2);
            this.Controls.Add(this.txtArriba1);
            this.Controls.Add(this.txtVertical5);
            this.Controls.Add(this.txtVertical4);
            this.Controls.Add(this.txtVertical3);
            this.Controls.Add(this.txtVertical2);
            this.Controls.Add(this.txtVertical1);
            this.Name = "Form2";
            this.Text = "Crucigrama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVertical1;
        private System.Windows.Forms.TextBox txtVertical2;
        private System.Windows.Forms.TextBox txtVertical3;
        private System.Windows.Forms.TextBox txtVertical4;
        private System.Windows.Forms.TextBox txtVertical5;
        private System.Windows.Forms.TextBox txtArriba1;
        private System.Windows.Forms.TextBox txtArriba2;
        private System.Windows.Forms.TextBox txtAbajo4;
        private System.Windows.Forms.TextBox txtAbajo1;
        private System.Windows.Forms.TextBox txtAbajo2;
        private System.Windows.Forms.TextBox txtAbajo3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIntentos;
    }
}