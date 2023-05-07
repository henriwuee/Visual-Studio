using System.Diagnostics.Eventing.Reader;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private float valor1=0;
        private float valor2=0;
        public bool IsValor1 = true;
        private char op;
        private float result;
        private bool Termina = false;

        private void Verifica(Button button)
        {
            if (IsValor1)
            {
                valor1 = valor1 * 10 + float.Parse(button.Text);
                richtb1.Text = valor1.ToString();
            }
            else
            {
                valor2 = valor2 * 10 + float.Parse(button.Text);
                richtb1.Text = valor1.ToString() + " " + op.ToString() + " " + valor2.ToString();
            }
        }

        private void Terminou(Button button)
        {
            if (Termina == true)
            {
                richtb1.Clear();
                Termina = false;
            }
        }

        private void altvalor()
        {
            if (IsValor1 == true)
            {
                IsValor1 = false;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            Terminou(btn1);
            Verifica(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Terminou(btn2);
            Verifica(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Terminou(btn3);
            Verifica(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Terminou(btn4);
            Verifica(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Terminou(btn5);
            Verifica(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Terminou(btn6);
            Verifica(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Terminou(btn7);
            Verifica(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Terminou(btn8);
            Verifica(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Terminou(btn9);
            Verifica(btn9);
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            altvalor();
            op = '+';
            richtb1.Text += btnSoma.Text;
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            altvalor();
            op = '-';
            richtb1.Text += btnSubtrai.Text;
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            altvalor();
            op = '*';
            richtb1.Text += btnMultiplica.Text;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            altvalor();
            op = '/';
            richtb1.Text += btnDivide.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case '+':
                    result = valor1 + valor2;
                    break;
                case '-':
                    result = valor1 - valor2;
                    break;
                case '*':
                    result = valor1 * valor2;
                    break;
                case '/':
                    result = valor1 / valor2;
                    break;

            }
            richtb1.Text = valor1.ToString() + " " + op.ToString() + " " + valor2.ToString() + " = " + result.ToString();
            IsValor1 = true;
            valor1 = 0;
            valor2 = 0;
            Termina = true; 
        }
    }
}