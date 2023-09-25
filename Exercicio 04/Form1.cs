using System.Runtime.Serialization;

namespace Exercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal soma;
        private void button1_Click(object sender, EventArgs e)
        {
            soma = 0;
            
            for (decimal i = 1; i <= int.Parse(edtNumero.Text); i++)
                soma += 1 / i;

            MessageBox.Show("Resultado: " + soma);
        }
    }
}