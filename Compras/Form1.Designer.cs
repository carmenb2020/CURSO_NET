
namespace Compras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPaquetes = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHamburguesa = new System.Windows.Forms.TextBox();
            this.txtPrecioAgua = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrecioYogurt = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrecioEnsalada = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecioNuggets = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioPizza = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioRefresco = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioPapas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.txtYogurt = new System.Windows.Forms.TextBox();
            this.txtEnsalada = new System.Windows.Forms.TextBox();
            this.txtNuggets = new System.Windows.Forms.TextBox();
            this.txtPizza = new System.Windows.Forms.TextBox();
            this.txtRefresco = new System.Windows.Forms.TextBox();
            this.txtPapas = new System.Windows.Forms.TextBox();
            this.txtPrecioHamburguesa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTotal_Pagar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtSub_Total = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPaquetes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPaquetes
            // 
            this.txtPaquetes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPaquetes.Controls.Add(this.radioButton4);
            this.txtPaquetes.Controls.Add(this.radioButton3);
            this.txtPaquetes.Controls.Add(this.radioButton2);
            this.txtPaquetes.Controls.Add(this.radioButton1);
            this.txtPaquetes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPaquetes.Location = new System.Drawing.Point(23, 49);
            this.txtPaquetes.Name = "txtPaquetes";
            this.txtPaquetes.Size = new System.Drawing.Size(353, 242);
            this.txtPaquetes.TabIndex = 0;
            this.txtPaquetes.TabStop = false;
            this.txtPaquetes.Text = "Paquetes";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(30, 186);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(132, 25);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Otras opciones";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(26, 138);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(192, 25);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ensalada, yogurt y agua";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(26, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(198, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pizza, nuggets y refresco";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(24, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(246, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hamburguesa, papas y refresco";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtHamburguesa);
            this.groupBox1.Controls.Add(this.txtPrecioAgua);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtPrecioYogurt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtPrecioEnsalada);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPrecioNuggets);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPrecioPizza);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPrecioRefresco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecioPapas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAgua);
            this.groupBox1.Controls.Add(this.txtYogurt);
            this.groupBox1.Controls.Add(this.txtEnsalada);
            this.groupBox1.Controls.Add(this.txtNuggets);
            this.groupBox1.Controls.Add(this.txtPizza);
            this.groupBox1.Controls.Add(this.txtRefresco);
            this.groupBox1.Controls.Add(this.txtPapas);
            this.groupBox1.Controls.Add(this.txtPrecioHamburguesa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(399, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 387);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // txtHamburguesa
            // 
            this.txtHamburguesa.Enabled = false;
            this.txtHamburguesa.Location = new System.Drawing.Point(27, 43);
            this.txtHamburguesa.MaxLength = 2;
            this.txtHamburguesa.Name = "txtHamburguesa";
            this.txtHamburguesa.Size = new System.Drawing.Size(27, 33);
            this.txtHamburguesa.TabIndex = 24;
            this.txtHamburguesa.Text = "0";
            this.txtHamburguesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecioAgua
            // 
            this.txtPrecioAgua.AutoSize = true;
            this.txtPrecioAgua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioAgua.Location = new System.Drawing.Point(200, 323);
            this.txtPrecioAgua.Name = "txtPrecioAgua";
            this.txtPrecioAgua.Size = new System.Drawing.Size(49, 21);
            this.txtPrecioAgua.TabIndex = 23;
            this.txtPrecioAgua.Text = "12,00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(60, 323);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 21);
            this.label16.TabIndex = 22;
            this.label16.Text = "Agua";
            // 
            // txtPrecioYogurt
            // 
            this.txtPrecioYogurt.AutoSize = true;
            this.txtPrecioYogurt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioYogurt.Location = new System.Drawing.Point(200, 283);
            this.txtPrecioYogurt.Name = "txtPrecioYogurt";
            this.txtPrecioYogurt.Size = new System.Drawing.Size(49, 21);
            this.txtPrecioYogurt.TabIndex = 21;
            this.txtPrecioYogurt.Text = "15,00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(59, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "Yogurt";
            // 
            // txtPrecioEnsalada
            // 
            this.txtPrecioEnsalada.AutoSize = true;
            this.txtPrecioEnsalada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioEnsalada.Location = new System.Drawing.Point(200, 244);
            this.txtPrecioEnsalada.Name = "txtPrecioEnsalada";
            this.txtPrecioEnsalada.Size = new System.Drawing.Size(49, 21);
            this.txtPrecioEnsalada.TabIndex = 19;
            this.txtPrecioEnsalada.Text = "30,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(59, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "Ensalada";
            // 
            // txtPrecioNuggets
            // 
            this.txtPrecioNuggets.AutoSize = true;
            this.txtPrecioNuggets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioNuggets.Location = new System.Drawing.Point(200, 210);
            this.txtPrecioNuggets.Name = "txtPrecioNuggets";
            this.txtPrecioNuggets.Size = new System.Drawing.Size(49, 21);
            this.txtPrecioNuggets.TabIndex = 17;
            this.txtPrecioNuggets.Text = "25,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(60, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nuggets";
            // 
            // txtPrecioPizza
            // 
            this.txtPrecioPizza.AutoSize = true;
            this.txtPrecioPizza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioPizza.Location = new System.Drawing.Point(200, 166);
            this.txtPrecioPizza.Name = "txtPrecioPizza";
            this.txtPrecioPizza.Size = new System.Drawing.Size(49, 21);
            this.txtPrecioPizza.TabIndex = 15;
            this.txtPrecioPizza.Text = "70,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(60, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pizza";
            // 
            // txtPrecioRefresco
            // 
            this.txtPrecioRefresco.AutoSize = true;
            this.txtPrecioRefresco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioRefresco.Location = new System.Drawing.Point(200, 128);
            this.txtPrecioRefresco.Name = "txtPrecioRefresco";
            this.txtPrecioRefresco.Size = new System.Drawing.Size(49, 21);
            this.txtPrecioRefresco.TabIndex = 13;
            this.txtPrecioRefresco.Text = "12,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(60, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Refresco";
            // 
            // txtPrecioPapas
            // 
            this.txtPrecioPapas.AutoSize = true;
            this.txtPrecioPapas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioPapas.Location = new System.Drawing.Point(200, 88);
            this.txtPrecioPapas.Name = "txtPrecioPapas";
            this.txtPrecioPapas.Size = new System.Drawing.Size(49, 21);
            this.txtPrecioPapas.TabIndex = 11;
            this.txtPrecioPapas.Text = "15,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Papas";
            // 
            // txtAgua
            // 
            this.txtAgua.Enabled = false;
            this.txtAgua.Location = new System.Drawing.Point(28, 317);
            this.txtAgua.MaxLength = 2;
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(26, 33);
            this.txtAgua.TabIndex = 9;
            this.txtAgua.Text = "0";
            this.txtAgua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYogurt
            // 
            this.txtYogurt.Enabled = false;
            this.txtYogurt.Location = new System.Drawing.Point(28, 277);
            this.txtYogurt.MaxLength = 2;
            this.txtYogurt.Name = "txtYogurt";
            this.txtYogurt.Size = new System.Drawing.Size(26, 33);
            this.txtYogurt.TabIndex = 8;
            this.txtYogurt.Text = "0";
            this.txtYogurt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEnsalada
            // 
            this.txtEnsalada.Enabled = false;
            this.txtEnsalada.Location = new System.Drawing.Point(28, 238);
            this.txtEnsalada.MaxLength = 2;
            this.txtEnsalada.Name = "txtEnsalada";
            this.txtEnsalada.Size = new System.Drawing.Size(26, 33);
            this.txtEnsalada.TabIndex = 7;
            this.txtEnsalada.Text = "0";
            this.txtEnsalada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNuggets
            // 
            this.txtNuggets.Enabled = false;
            this.txtNuggets.Location = new System.Drawing.Point(28, 199);
            this.txtNuggets.MaxLength = 2;
            this.txtNuggets.Name = "txtNuggets";
            this.txtNuggets.Size = new System.Drawing.Size(26, 33);
            this.txtNuggets.TabIndex = 6;
            this.txtNuggets.Text = "0";
            this.txtNuggets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPizza
            // 
            this.txtPizza.Enabled = false;
            this.txtPizza.Location = new System.Drawing.Point(28, 160);
            this.txtPizza.MaxLength = 2;
            this.txtPizza.Name = "txtPizza";
            this.txtPizza.Size = new System.Drawing.Size(26, 33);
            this.txtPizza.TabIndex = 5;
            this.txtPizza.Text = "0";
            this.txtPizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRefresco
            // 
            this.txtRefresco.Enabled = false;
            this.txtRefresco.Location = new System.Drawing.Point(28, 121);
            this.txtRefresco.MaxLength = 2;
            this.txtRefresco.Name = "txtRefresco";
            this.txtRefresco.Size = new System.Drawing.Size(26, 33);
            this.txtRefresco.TabIndex = 4;
            this.txtRefresco.Text = "0";
            this.txtRefresco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPapas
            // 
            this.txtPapas.Enabled = false;
            this.txtPapas.Location = new System.Drawing.Point(28, 82);
            this.txtPapas.MaxLength = 2;
            this.txtPapas.Name = "txtPapas";
            this.txtPapas.Size = new System.Drawing.Size(26, 33);
            this.txtPapas.TabIndex = 3;
            this.txtPapas.Text = "0";
            this.txtPapas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecioHamburguesa
            // 
            this.txtPrecioHamburguesa.AutoSize = true;
            this.txtPrecioHamburguesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioHamburguesa.Location = new System.Drawing.Point(200, 49);
            this.txtPrecioHamburguesa.Name = "txtPrecioHamburguesa";
            this.txtPrecioHamburguesa.Size = new System.Drawing.Size(49, 21);
            this.txtPrecioHamburguesa.TabIndex = 2;
            this.txtPrecioHamburguesa.Text = "35,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hamburguesa";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtCambio);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtPago);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtTotal_Pagar);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtIVA);
            this.groupBox2.Controls.Add(this.txtSub_Total);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(36, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(423, 119);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(184, 33);
            this.txtCambio.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(335, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 21);
            this.label21.TabIndex = 8;
            this.label21.Text = "Cambio";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(423, 71);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(184, 33);
            this.txtPago.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(349, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 21);
            this.label20.TabIndex = 6;
            this.label20.Text = "Pago";
            // 
            // txtTotal_Pagar
            // 
            this.txtTotal_Pagar.Enabled = false;
            this.txtTotal_Pagar.Location = new System.Drawing.Point(421, 26);
            this.txtTotal_Pagar.Name = "txtTotal_Pagar";
            this.txtTotal_Pagar.Size = new System.Drawing.Size(186, 33);
            this.txtTotal_Pagar.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(290, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 21);
            this.label19.TabIndex = 4;
            this.label19.Text = "Total a pagar";
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(121, 73);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(163, 33);
            this.txtIVA.TabIndex = 3;
            // 
            // txtSub_Total
            // 
            this.txtSub_Total.Enabled = false;
            this.txtSub_Total.Location = new System.Drawing.Point(121, 28);
            this.txtSub_Total.Name = "txtSub_Total";
            this.txtSub_Total.Size = new System.Drawing.Size(163, 33);
            this.txtSub_Total.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(22, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 21);
            this.label18.TabIndex = 1;
            this.label18.Text = "IVA 21%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(22, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "Sub Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPaquetes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Opciones";
            this.txtPaquetes.ResumeLayout(false);
            this.txtPaquetes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtPaquetes;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtPrecioPapas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.TextBox txtYogurt;
        private System.Windows.Forms.TextBox txtEnsalada;
        private System.Windows.Forms.TextBox txtNuggets;
        private System.Windows.Forms.TextBox txtPizza;
        private System.Windows.Forms.TextBox txtRefresco;
        private System.Windows.Forms.TextBox txtPapas;
        private System.Windows.Forms.Label txtPrecioHamburguesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtPrecioRefresco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtPrecioPizza;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtPrecioAgua;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txtPrecioYogurt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtPrecioEnsalada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtPrecioNuggets;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtSub_Total;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtHamburguesa;
        private System.Windows.Forms.TextBox txtTotal_Pagar;
        private System.Windows.Forms.Button button2;
    }
}

