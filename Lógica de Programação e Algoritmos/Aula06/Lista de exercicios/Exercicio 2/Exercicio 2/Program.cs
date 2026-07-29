//Declaração de variaveis

using System.Linq.Expressions;

double salario, aumento, percentual;

try
{
    //Entrada de dados

    Console.Write("Qual seu salario?");
    salario = double.Parse(Console.ReadLine());
    if (salario < 280)
    {
        percentual = 20;
    }
    else if (salario >= 280 & salario <= 700)
    {
        percentual = 15;
    }
    else if (salario >= 700 & salario <= 1500)
    {
        percentual = 10;
    }
    else 
    {
        percentual = 5;
    }
    //Saida de dados
    Calcularaumento(percentual);
    Console.Write($"Salario antes do reajuste: {salario}");
    Console.Write($"Porcentual de aumento aplicado: {percentual}");
    Console.Write($"O valor do aumento: {aumento}");
    Console.Write($"O novo salario, apos o aumento: {salario + aumento}");
}

catch
{

}

double Calcularaumento(double percentual)
{
    aumento = salario * percentual / 100; 
    return aumento;
}