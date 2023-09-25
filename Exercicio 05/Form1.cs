namespace Exercicio_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tamanho = int.Parse(edtTamanho.Text);
            string texto = string.Empty;

            memo.Clear();

            for (int i = 1; i <= tamanho; i++)
                texto += '*';

            for (int i = 1; i <= tamanho; i++)
                memo.AppendText(texto + "\n");
        }
    }
}