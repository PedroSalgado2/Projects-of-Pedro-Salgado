using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora2;
using WinFormsApp1;
using Lista_Compras;


namespace Tarefa5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 F1 = new Form1();
            F1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculadora C1 = new Calculadora();
            C1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 W1 = new Form4();
            W1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 W2 = new Form5();
            W2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

           Escolha E1 = new Escolha();
           E1.Show();
        }
    }
}
