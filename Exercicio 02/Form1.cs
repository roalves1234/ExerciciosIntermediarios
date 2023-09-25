namespace Exercicio_02
{
    public partial class Form1 : Form
    {
        decimal primeiroNumero;
        decimal segundoNumero;
        decimal terceiroNumero;
        int vezes = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            vezes++;

            if (vezes == 1)
            {
                primeiroNumero = Decimal.Parse(txtNumero.Text);
                Limpar();
                lblPrimeiro.ForeColor = Color.Blue;
            }
            else if (vezes == 2)
            {
                segundoNumero = Decimal.Parse(txtNumero.Text);
                lblSegundo.ForeColor = Color.Blue;
            }
            else if (vezes == 3)
            {
                terceiroNumero = Decimal.Parse(txtNumero.Text);
                lblTerceiro.ForeColor = Color.Blue;
                doResposta();
            }

            txtNumero.Focus();
            txtNumero.SelectAll();
        }

        private void doResposta()
        {
            decimal respostaPrimeiroNumero = 0;
            decimal respostaSegundoNumero = 0;
            decimal respostaTerceiroNumero = 0;

            if (primeiroNumero < segundoNumero && primeiroNumero < terceiroNumero)
                respostaPrimeiroNumero = primeiroNumero;
            else if (segundoNumero < primeiroNumero && segundoNumero < terceiroNumero)
                respostaPrimeiroNumero = segundoNumero;
            else if (terceiroNumero < primeiroNumero && terceiroNumero < segundoNumero)
                respostaPrimeiroNumero = terceiroNumero;

            if (primeiroNumero > segundoNumero && primeiroNumero < terceiroNumero || primeiroNumero > terceiroNumero && primeiroNumero < segundoNumero)
                respostaSegundoNumero = primeiroNumero;
            else if (segundoNumero > primeiroNumero && segundoNumero < terceiroNumero || segundoNumero > terceiroNumero && segundoNumero < primeiroNumero)
                respostaSegundoNumero = segundoNumero;
            else if (terceiroNumero > primeiroNumero && terceiroNumero < segundoNumero || terceiroNumero > segundoNumero && terceiroNumero < primeiroNumero)
                respostaSegundoNumero = terceiroNumero;

            if (primeiroNumero > segundoNumero && primeiroNumero > terceiroNumero)
                respostaTerceiroNumero = primeiroNumero;
            else if (segundoNumero > primeiroNumero && segundoNumero > terceiroNumero)
                respostaTerceiroNumero = segundoNumero;
            else if (terceiroNumero > primeiroNumero && terceiroNumero > segundoNumero)
                respostaTerceiroNumero = terceiroNumero;

            lblPrimeiroNumero.Text = respostaPrimeiroNumero.ToString();
            lblSegundoNumero.Text = respostaSegundoNumero.ToString();
            lblTerceiroNumero.Text = respostaTerceiroNumero.ToString();

            vezes = 0;
        }

        private void Limpar()
        {
            lblPrimeiro.ForeColor = Color.Black;
            lblSegundo.ForeColor = Color.Black;
            lblTerceiro.ForeColor = Color.Black;

            lblPrimeiroNumero.Text = string.Empty;
            lblSegundoNumero.Text = string.Empty;
            lblTerceiroNumero.Text = string.Empty;
        }
    }
}