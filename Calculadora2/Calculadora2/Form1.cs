namespace Calculadora2
{
    public partial class Calculadora : Form
    {
        double num1;
        string OP;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null) //empurra o zero para um lado
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            OP = "+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            num1 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            OP = "/";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            OP = "-";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            OP = "x";
        }

        private void ponto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            double num2;
            double resultado;

            num2 = Convert.ToDouble(textBox1.Text);

            if (OP == "+")
            {
                resultado = (num1 + num2);
                textBox1.Text= Convert.ToString(resultado); 
                num1 = resultado;
            }

            if (OP == "-")
            {
                resultado = (num1 - num2);
                textBox1.Text = Convert.ToString(resultado);
                num1 = resultado;
            }

            if (OP == "x")
            {
                resultado = (num1 * num2);
                textBox1.Text = Convert.ToString(resultado);
                num1 = resultado;
            }

            if (OP == "/")
            {
                if (num2 == 0)
                {
                    textBox1.Text = "Não é possível dividir por 0";
                }

                else
                {
                    resultado = (num1 / num2);
                    textBox1.Text = Convert.ToString(resultado);
                    num1 = resultado;
                }
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + num1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}