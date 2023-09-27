namespace Exercicio_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int resultado = 1;

            for (int i = int.Parse(edtNumero.Text); i >= 1; i--)
            {
                resultado *= i;
            }

            MessageBox.Show("O fatorial de " + edtNumero.Text + " é " + resultado);


        }
    }
}