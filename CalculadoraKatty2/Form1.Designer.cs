namespace CalculadoraKatty2
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
            pnlEscritorio = new Panel();
            btnOperacionSuma = new Button();
            btnSignoIgual = new Button();
            btnNumeroCero = new Button();
            button12 = new Button();
            btnOpecionResta = new Button();
            btnNumeroTres = new Button();
            btnNumeroOcho = new Button();
            btnNumeroNueve = new Button();
            btnOperacionDivision = new Button();
            btnNumeroCuatro = new Button();
            btnNumeroCinco = new Button();
            Seis = new Button();
            btnOperacionMultiplicacion = new Button();
            btnNumeroSiete = new Button();
            btnNumeroDos = new Button();
            btnNumeroUno = new Button();
            txtDisplay = new TextBox();
            btnPunto = new Button();
            pnlEscritorio.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEscritorio
            // 
            pnlEscritorio.BackColor = Color.Fuchsia;
            pnlEscritorio.Controls.Add(btnPunto);
            pnlEscritorio.Controls.Add(btnOperacionSuma);
            pnlEscritorio.Controls.Add(btnSignoIgual);
            pnlEscritorio.Controls.Add(btnNumeroCero);
            pnlEscritorio.Controls.Add(button12);
            pnlEscritorio.Controls.Add(btnOpecionResta);
            pnlEscritorio.Controls.Add(btnNumeroTres);
            pnlEscritorio.Controls.Add(btnNumeroOcho);
            pnlEscritorio.Controls.Add(btnNumeroNueve);
            pnlEscritorio.Controls.Add(btnOperacionDivision);
            pnlEscritorio.Controls.Add(btnNumeroCuatro);
            pnlEscritorio.Controls.Add(btnNumeroCinco);
            pnlEscritorio.Controls.Add(Seis);
            pnlEscritorio.Controls.Add(btnOperacionMultiplicacion);
            pnlEscritorio.Controls.Add(btnNumeroSiete);
            pnlEscritorio.Controls.Add(btnNumeroDos);
            pnlEscritorio.Controls.Add(btnNumeroUno);
            pnlEscritorio.Controls.Add(txtDisplay);
            pnlEscritorio.Location = new Point(0, 0);
            pnlEscritorio.Name = "pnlEscritorio";
            pnlEscritorio.Size = new Size(800, 450);
            pnlEscritorio.TabIndex = 0;
            // 
            // btnOperacionSuma
            // 
            btnOperacionSuma.BackColor = Color.FromArgb(255, 128, 0);
            btnOperacionSuma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOperacionSuma.Location = new Point(383, 388);
            btnOperacionSuma.Name = "btnOperacionSuma";
            btnOperacionSuma.Size = new Size(50, 50);
            btnOperacionSuma.TabIndex = 16;
            btnOperacionSuma.Text = "+";
            btnOperacionSuma.UseVisualStyleBackColor = false;
            btnOperacionSuma.Click += btnOperacionSuma_Click;
            // 
            // btnSignoIgual
            // 
            btnSignoIgual.BackColor = Color.Lime;
            btnSignoIgual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignoIgual.Location = new Point(301, 388);
            btnSignoIgual.Name = "btnSignoIgual";
            btnSignoIgual.Size = new Size(50, 50);
            btnSignoIgual.TabIndex = 15;
            btnSignoIgual.Text = "=";
            btnSignoIgual.UseVisualStyleBackColor = false;
            btnSignoIgual.Click += btnSignoIgual_Click;
            // 
            // btnNumeroCero
            // 
            btnNumeroCero.BackColor = Color.FromArgb(255, 255, 128);
            btnNumeroCero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumeroCero.Location = new Point(127, 388);
            btnNumeroCero.Name = "btnNumeroCero";
            btnNumeroCero.Size = new Size(50, 50);
            btnNumeroCero.TabIndex = 14;
            btnNumeroCero.Text = "0";
            btnNumeroCero.UseVisualStyleBackColor = false;
            btnNumeroCero.Click += btnNumeroCero_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Silver;
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(217, 388);
            button12.Name = "button12";
            button12.Size = new Size(50, 50);
            button12.TabIndex = 13;
            button12.Text = "C";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // btnOpecionResta
            // 
            btnOpecionResta.BackColor = Color.FromArgb(255, 128, 0);
            btnOpecionResta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpecionResta.Location = new Point(383, 307);
            btnOpecionResta.Name = "btnOpecionResta";
            btnOpecionResta.Size = new Size(50, 50);
            btnOpecionResta.TabIndex = 12;
            btnOpecionResta.Text = "-";
            btnOpecionResta.UseVisualStyleBackColor = false;
            btnOpecionResta.Click += btnOpecionResta_Click;
            // 
            // btnNumeroTres
            // 
            btnNumeroTres.BackColor = Color.FromArgb(255, 255, 128);
            btnNumeroTres.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumeroTres.Location = new Point(301, 307);
            btnNumeroTres.Name = "btnNumeroTres";
            btnNumeroTres.Size = new Size(50, 50);
            btnNumeroTres.TabIndex = 11;
            btnNumeroTres.Text = "3";
            btnNumeroTres.UseVisualStyleBackColor = false;
            btnNumeroTres.Click += btnNumeroTres_Click;
            // 
            // btnNumeroOcho
            // 
            btnNumeroOcho.BackColor = Color.FromArgb(255, 255, 128);
            btnNumeroOcho.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumeroOcho.Location = new Point(217, 136);
            btnNumeroOcho.Name = "btnNumeroOcho";
            btnNumeroOcho.Size = new Size(50, 50);
            btnNumeroOcho.TabIndex = 10;
            btnNumeroOcho.Text = "8";
            btnNumeroOcho.UseVisualStyleBackColor = false;
            btnNumeroOcho.Click += btnNumeroOcho_Click;
            // 
            // btnNumeroNueve
            // 
            btnNumeroNueve.BackColor = Color.FromArgb(255, 255, 128);
            btnNumeroNueve.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumeroNueve.Location = new Point(301, 136);
            btnNumeroNueve.Name = "btnNumeroNueve";
            btnNumeroNueve.Size = new Size(50, 50);
            btnNumeroNueve.TabIndex = 9;
            btnNumeroNueve.Text = "9";
            btnNumeroNueve.UseVisualStyleBackColor = false;
            btnNumeroNueve.Click += btnNumeroNueve_Click;
            // 
            // btnOperacionDivision
            // 
            btnOperacionDivision.BackColor = Color.FromArgb(255, 128, 0);
            btnOperacionDivision.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOperacionDivision.Location = new Point(383, 136);
            btnOperacionDivision.Name = "btnOperacionDivision";
            btnOperacionDivision.Size = new Size(50, 50);
            btnOperacionDivision.TabIndex = 8;
            btnOperacionDivision.Text = "/";
            btnOperacionDivision.UseVisualStyleBackColor = false;
            btnOperacionDivision.Click += btnOperacionDivision_Click;
            // 
            // btnNumeroCuatro
            // 
            btnNumeroCuatro.BackColor = Color.FromArgb(255, 255, 128);
            btnNumeroCuatro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumeroCuatro.Location = new Point(127, 222);
            btnNumeroCuatro.Name = "btnNumeroCuatro";
            btnNumeroCuatro.Size = new Size(50, 50);
            btnNumeroCuatro.TabIndex = 7;
            btnNumeroCuatro.Text = "4";
            btnNumeroCuatro.UseVisualStyleBackColor = false;
            btnNumeroCuatro.Click += btnNumeroCuatro_Click;
            // 
            // btnNumeroCinco
            // 
            btnNumeroCinco.BackColor = Color.FromArgb(255, 255, 128);
            btnNumeroCinco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumeroCinco.Location = new Point(217, 222);
            btnNumeroCinco.Name = "btnNumeroCinco";
            btnNumeroCinco.Size = new Size(50, 50);
            btnNumeroCinco.TabIndex = 6;
            btnNumeroCinco.Text = "5";
            btnNumeroCinco.UseVisualStyleBackColor = false;
            btnNumeroCinco.Click += btnNumeroCinco_Click;
            // 
            // Seis
            // 
            Seis.BackColor = Color.FromArgb(255, 255, 128);
            Seis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Seis.Location = new Point(301, 222);
            Seis.Name = "Seis";
            Seis.Size = new Size(50, 50);
            Seis.TabIndex = 5;
            Seis.Text = "6";
            Seis.UseVisualStyleBackColor = false;
            Seis.Click += Seis_Click;
            // 
            // btnOperacionMultiplicacion
            // 
            btnOperacionMultiplicacion.BackColor = Color.FromArgb(255, 128, 0);
            btnOperacionMultiplicacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOperacionMultiplicacion.Location = new Point(383, 222);
            btnOperacionMultiplicacion.Name = "btnOperacionMultiplicacion";
            btnOperacionMultiplicacion.Size = new Size(50, 50);
            btnOperacionMultiplicacion.TabIndex = 4;
            btnOperacionMultiplicacion.Text = "X";
            btnOperacionMultiplicacion.UseVisualStyleBackColor = false;
            btnOperacionMultiplicacion.Click += btnOperacionMultiplicacion_Click;
            // 
            // btnNumeroSiete
            // 
            btnNumeroSiete.BackColor = Color.FromArgb(255, 255, 128);
            btnNumeroSiete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumeroSiete.Location = new Point(127, 136);
            btnNumeroSiete.Name = "btnNumeroSiete";
            btnNumeroSiete.Size = new Size(50, 50);
            btnNumeroSiete.TabIndex = 3;
            btnNumeroSiete.Text = "7";
            btnNumeroSiete.UseVisualStyleBackColor = false;
            btnNumeroSiete.Click += btnNumeroSiete_Click;
            // 
            // btnNumeroDos
            // 
            btnNumeroDos.BackColor = Color.FromArgb(255, 255, 128);
            btnNumeroDos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumeroDos.Location = new Point(217, 307);
            btnNumeroDos.Name = "btnNumeroDos";
            btnNumeroDos.Size = new Size(50, 50);
            btnNumeroDos.TabIndex = 2;
            btnNumeroDos.Text = "2";
            btnNumeroDos.UseVisualStyleBackColor = false;
            btnNumeroDos.Click += btnNumeroDos_Click;
            // 
            // btnNumeroUno
            // 
            btnNumeroUno.BackColor = Color.FromArgb(255, 255, 128);
            btnNumeroUno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNumeroUno.Location = new Point(127, 307);
            btnNumeroUno.Name = "btnNumeroUno";
            btnNumeroUno.Size = new Size(50, 50);
            btnNumeroUno.TabIndex = 1;
            btnNumeroUno.Text = "1";
            btnNumeroUno.UseVisualStyleBackColor = false;
            btnNumeroUno.Click += btnNumeroUno_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.FromArgb(128, 255, 255);
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(127, 58);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(224, 39);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPunto
            // 
            btnPunto.BackColor = Color.FromArgb(255, 128, 0);
            btnPunto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPunto.Location = new Point(383, 58);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(50, 50);
            btnPunto.TabIndex = 17;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = false;
            btnPunto.Click += btnPunto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlEscritorio);
            Name = "Form1";
            Text = "Form1";
            pnlEscritorio.ResumeLayout(false);
            pnlEscritorio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEscritorio;
        private TextBox txtDisplay;
        private Button btnNumeroUno;
        private Button btnOpecionResta;
        private Button btnNumeroTres;
        private Button btnNumeroOcho;
        private Button btnNumeroNueve;
        private Button btnOperacionDivision;
        private Button btnNumeroCuatro;
        private Button btnNumeroCinco;
        private Button Seis;
        private Button btnOperacionMultiplicacion;
        private Button btnNumeroSiete;
        private Button btnNumeroDos;
        private Button btnOperacionSuma;
        private Button btnSignoIgual;
        private Button btnNumeroCero;
        private Button button12;
        private Button btnPunto;
    }
}
