namespace ProyectoCalculadora
{
    public partial class Form1 : Form
    {

        private double valor1;
        private double valor2;

        private double resultado;

        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text += "9";
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {
            //este es el textbox donde se vera lo seleccionado
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            //boton Clear
            tbDisplay.Text = "";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //boton de igual
            valor2 = Convert.ToDouble(tbDisplay.Text);

            switch (operacion)
            {
                case 1: resultado = valor1 + valor2;
                       break;
                    case 2: resultado = valor1 - valor2;
                        break;
            }
            
            tbDisplay.Text = resultado.ToString();


        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //suma
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //boton resta
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }
    }
}
