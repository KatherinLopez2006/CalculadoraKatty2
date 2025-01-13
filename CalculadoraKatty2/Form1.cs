namespace CalculadoraKatty2
{
    public partial class Form1 : Form
    {
        private double Valor1;
        private double Valor2;
        private double resultado;
        private int operacion;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumeroCero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btnNumeroUno_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btnNumeroDos_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btnNumeroTres_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }


        private void btnNumeroCuatro_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btnNumeroCinco_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }


        private void btnNumeroSiete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btnNumeroOcho_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btnNumeroNueve_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }


        private void btnSignoIgual_Click(object sender, EventArgs e)
        {


            Valor2 = Convert.ToDouble(txtDisplay.Text);
            switch (operacion)
            {
                case 1:
                    resultado = Valor1 + Valor2;
                    break;

                case 2:
                    resultado = Valor1 - Valor2;
                    break;

                case 3:
                    resultado = Valor1 * Valor2;
                    break;
                case 4:
                    resultado = Valor1 / Valor2;
                    break;


            }

            txtDisplay.Text = resultado.ToString();

        }

        
        private void btnOperacionSuma_Click(object sender, EventArgs e)
        {
            operacion = 1;
            Valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnOpecionResta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            Valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnOperacionMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            Valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnOperacionDivision_Click(object sender, EventArgs e)
        {
            operacion = 4;
            Valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = ""; // Limpiar el TextBox para el siguiente número
        }


        private void button12_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
           
        }

       
    }
}
