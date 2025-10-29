using System.Data;
using System.Data.SqlClient;

namespace ProyectoCalculadora
{
    public partial class Form1 : Form
    {

        private double valor1;
        private double valor2;

        private double resultado;

        private int operacion;

        private void GuardarHistorial(string operacion, double valor1, double valor2, double resultado)
        {
            string conexion = @"Server=localhost\SQLEXPRESS;Database=CalculadoraDB;Trusted_Connection=True;";

            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            string query = "INSERT INTO HistorialCalculos (Operacion, Valor1, Valor2, Resultado) " +
                           "VALUES (@Operacion, @Valor1, @Valor2, @Resultado)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Operacion", operacion);
            cmd.Parameters.AddWithValue("@Valor1", valor1);
            cmd.Parameters.AddWithValue("@Valor2", valor2);
            cmd.Parameters.AddWithValue("@Resultado", resultado);

            cmd.ExecuteNonQuery();
            con.Close();
        }

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
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
            operacion = 0;

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //boton de igual
            valor2 = Convert.ToDouble(tbDisplay.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    GuardarHistorial("Suma", valor1, valor2, resultado);
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    GuardarHistorial("Resta", valor1, valor2, resultado);
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    GuardarHistorial("Multiplicación", valor1, valor2, resultado);
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    GuardarHistorial("División", valor1, valor2, resultado);
                    break;

                case 5:
                    resultado = Math.Pow(valor1, valor2);
                    GuardarHistorial("Potencia", valor1, valor2, resultado);
                    break;

                case 6:
                    resultado = (valor1 * valor2) / 100;
                    GuardarHistorial("Porcentaje", valor1, valor2, resultado);
                    break;
            }

            tbDisplay.Text = resultado.ToString();


        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //suma
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text); //convierte los caracteres a double 
            tbDisplay.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //boton resta
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //boton multiplicacion
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //boton division
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            //boton punto decimal
            tbDisplay.Text = tbDisplay.Text = ".";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            //raiz
            double valor;
            double resultado;

            valor = Convert.ToDouble(tbDisplay.Text);
            resultado = Math.Sqrt(valor);
            GuardarHistorial("Raiz", valor, 0, resultado);
            tbDisplay.Text = resultado.ToString();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            //potencia
            operacion = 5;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            double valor;

            valor = Convert.ToDouble(tbDisplay.Text);
            valor = valor * -1;

            tbDisplay.Text = valor.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            // boton CE (borra solo la entrada actual)
            tbDisplay.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // boton borrar ultimo digito
            if (tbDisplay.Text.Length > 0)
            {
                tbDisplay.Text = tbDisplay.Text.Substring(0, tbDisplay.Text.Length - 1);
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            //porcentaje
            operacion = 6;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form2 historialForm = new Form2();
            historialForm.ShowDialog(); //  ventana de historial
        }
    }
}
