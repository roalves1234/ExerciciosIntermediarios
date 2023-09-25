using System.ComponentModel.DataAnnotations;

namespace Exercicio_06
{
    public partial class Form1 : Form
    {
        int[,] listaAjuste = new int[11, 2];

        public Form1()
        {
            InitializeComponent();
            criarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal precoFinal, valorParcela, valorVeiculo;

            memo.Clear();
            valorVeiculo = Decimal.Parse(edtValorVeiculo.Text);

            for (int i = 0; i <= listaAjuste.GetLength(0) - 1; i++)
            {
                precoFinal = valorVeiculo + valorVeiculo * listaAjuste[i, 1] / 100;
                valorParcela = Math.Round(precoFinal / listaAjuste[i, 0], 2, MidpointRounding.AwayFromZero);

                memo.AppendText(getTexto("Preço final: ", precoFinal.ToString()) + "  | " + getTexto("Quantidade de parcelas: ", listaAjuste[i, 0].ToString()) + "  | " + getTexto("Valor da parcela: ", valorParcela.ToString()) + "\n");
            }
        }

        private string getTexto(in string descricao, in string valor)
        {
            return (descricao.PadRight(10) + " " + valor.ToString().PadLeft(7));
        }

        private void criarLista()
        {
            listaAjuste[0, 0] = 1;
            listaAjuste[0, 1] = -20;

            listaAjuste[1, 0] = 6;
            listaAjuste[1, 1] = 3;

            listaAjuste[2, 0] = 12;
            listaAjuste[2, 1] = 6;

            listaAjuste[3, 0] = 18;
            listaAjuste[3, 1] = 9;

            listaAjuste[4, 0] = 24;
            listaAjuste[4, 1] = 12;

            listaAjuste[5, 0] = 30;
            listaAjuste[5, 1] = 15;

            listaAjuste[6, 0] = 36;
            listaAjuste[6, 1] = 18;

            listaAjuste[7, 0] = 42;
            listaAjuste[7, 1] = 21;

            listaAjuste[8, 0] = 48;
            listaAjuste[8, 1] = 24;

            listaAjuste[9, 0] = 54;
            listaAjuste[9, 1] = 27;

            listaAjuste[10, 0] = 60;
            listaAjuste[10, 1] = 30;
        }
    }
}