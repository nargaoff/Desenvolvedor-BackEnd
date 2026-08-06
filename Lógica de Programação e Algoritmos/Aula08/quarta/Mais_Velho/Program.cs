//Declaração de variavel
using System.Runtime.CompilerServices;

Dictionary<string, int> pessoas = new Dictionary<string, int>();
string nome;
int idade, n;
int valor;

try
{
    //Entrada de dados
    Console.Write("Quantas pessoas voce vai digitar: ");
    n = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Dados da {i+1}ª pessoa:");
        Console.Write("Nome: ");
        nome = Console.ReadLine()!;
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine()!);
        pessoas.Add(nome, idade);
    }
    Console.Write("Pessoas mais velha: ");


    foreach (var item in pessoas)
    {    
       if (item.Value == pessoas.Values.Max())
        {
            Console.WriteLine(item.Key);
        }
    }
}
catch (Exception e)
{
    Console.WriteLine("Valor invalido, erro: " + e);
}