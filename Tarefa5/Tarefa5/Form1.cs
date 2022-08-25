namespace Tarefa5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           

            if (textBox1.Text == "")
            {
                MessageBox.Show("Type the PIN (123456)");
            }
            else if (textBox1.Text == "123456")
            {
                this.Hide();
                Form2 x = new Form2();
                x.Show();
                
            }
            else
            {
                 MessageBox.Show("Wrong PIN, try again.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 6;
            textBox1.PasswordChar = '*';
        }
    }
}