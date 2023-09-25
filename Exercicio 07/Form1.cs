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

            int numero = 0;
            int resultado = 0;
            Boolean primeiraVez = true;

            for (int i = int.Parse(edtNumero.Text); i >= 1; i--)
            {
                if (primeiraVez)
                    resultado = i;
                else
                    resultado = resultado * i;

                primeiraVez = false;    
            }

            MessageBox.Show("O fatorial de " + edtNumero.Text + " é " + resultado);


        }
    }
}