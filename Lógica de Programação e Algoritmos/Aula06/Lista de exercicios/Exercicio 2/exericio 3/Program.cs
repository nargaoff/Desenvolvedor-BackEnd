//Declaração de variaveis

double IR, INSS, FGTS, salario, percentual, ValorHora, HorasTrabalhadas;
double SalarioBruto, TotalDesconto, PercentualIR, SalarioLiquido;

try
{
    //Entrada de dados

    Console.Write("Digite o valor da hora: ");
    ValorHora = double.Parse(Console.ReadLine());
    Console.Write("Digite a quantidade de horas trabalhadas: ");
    HorasTrabalhadas = double.Parse(Console.ReadLine());
    SalarioBruto = ValorHora * HorasTrabalhadas;

    if (SalarioBruto <= 900)
    {
        PercentualIR = 0;
    }
    else if (SalarioBruto <= 1500)
    {
        PercentualIR = 5;
    }
    else if (SalarioBruto <= 2500)
    {
        PercentualIR = 10;
    }
    else
    {
        PercentualIR = 20;
    }

    //Saida de dados
    IR = SalarioBruto * PercentualIR / 100;
    INSS = SalarioBruto * 0.10;
    FGTS = SalarioBruto * 0.11;
    TotalDesconto = IR + INSS;
    SalarioLiquido = SalarioBruto - TotalDesconto;

    Console.Write("Folha de pagamento");
    Console.Write("Salário bruto R$: " + SalarioBruto.ToString("F2"));
    Console.Write("IR (" + PercentualIR + "%): R$ " + IR.ToString("F2"));
    Console.Write("INSS (10%): R$ " + INSS.ToString("F2"));
    Console.Write("FGTS (11%): R$ " + FGTS.ToString("F2"));
    Console.Write("Total de descontos: R$ " + TotalDesconto.ToString("F2"));
    Console.Write("Salario Liquido: R$ " + SalarioLiquido.ToString("F2"));
}
catch
{
    Console.Write("Erro:Digite apenas numeros.");
}