namespace Exercicio_03
{
    using System.Configuration;
    using System.Text;
    public partial class Form1 : Form
    {
        decimal salarioBruto;
        decimal descontoIR;
        decimal valorDescontoIR;
        decimal valorDescontoSindicato;
        decimal valorFGTS;
        const decimal descontoSindicato = 3;
        const decimal percentualFGTS = 11;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salarioBruto = decimal.Parse(txtValorHora.Text) * decimal.Parse(txtHoras.Text);

            if (salarioBruto <= 900)
                descontoIR = 0;
            else if (salarioBruto <= 1500)
                descontoIR = 5;
            else if (salarioBruto <= 2500)
                descontoIR = 10;
            else
                descontoIR = 20;

            valorDescontoIR = salarioBruto * descontoIR / 100;
            valorDescontoSindicato = salarioBruto * descontoSindicato / 100;
            valorFGTS = salarioBruto * percentualFGTS / 100;

            memResultado.Clear();
            inserirTexto("Salário Bruto (" + txtHoras.Text + " * " + txtValorHora.Text + ")", salarioBruto);
            inserirTexto("( – ) IR (" + descontoIR.ToString() + "%)", valorDescontoIR);
            inserirTexto("( – ) Sindicato (" + descontoSindicato.ToString() + "%)", valorDescontoSindicato);
            inserirTexto("FGTS (" + percentualFGTS.ToString() + "%)", valorFGTS);
            inserirTexto("Total de descontos", valorDescontoIR + valorDescontoSindicato);
            inserirTexto("Salário Líquido", salarioBruto - valorDescontoIR - valorDescontoSindicato - valorFGTS);
        }

        private void inserirTexto(in string descricao, in decimal valor)
        {
            memResultado.AppendText(descricao.PadRight(30) + ": R$ " + valor.ToString().PadLeft(10) + "\n");
        }
    }
}