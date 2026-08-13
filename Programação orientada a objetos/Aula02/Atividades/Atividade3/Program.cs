// Entrada de dados

using System.ComponentModel.Design;

try
{


    Console.Write("Nome do aluno: ");
    string nome = Console.ReadLine();

    Console.Write("Digite a nota 1: ");
    double nota1 = double.Parse(Console.ReadLine());

    Console.Write("Digite a nota 2: ");
    double nota2 = double.Parse(Console.ReadLine());

    Console.Write("Digite a nota 3: ");
    double nota3 = double.Parse(Console.ReadLine());

    //Processamento de dados
    double Notafinal = (nota1 + nota2 + nota3);

    if (Notafinal >= 60)
    {
        Console.Write("Nota final do aluno: " + Notafinal);
        Console.Write("Aluno aprovado!");
    }
    else
    {
        Console.Write("Nota final do aluno: " + Notafinal);
        Console.Write("Aluno reprovado, faltaram " + (60 - Notafinal));
    }
}
catch
{
    Console.Write("Erro na digitação de dados: ");
}