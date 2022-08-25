using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int j = 1, tentativa;

            NumericUpDown numbox = new NumericUpDown();
            numbox.Location = new Point();


            for (i = 0; i < 9; i++)
            {
                tentativa = j + i;
                MessageBox.Show("Tentativa número: " + tentativa);
                tentativa = Convert.ToInt32(Console.ReadLine());

              

            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          
        }
    }
}
