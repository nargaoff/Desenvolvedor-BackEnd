//Problema "Idades"

//Declaração de variáveis
var nome1 = "SENAI";
var nome2 = "SENAI";
var idade1 = 1;
var idade2 = 2;
var media = 1.73;

var variaveis = DateTime.Now;


//Entrada de dados
Console.WriteLine("Dados da primeira pessoa:");
Console.WriteLine("Nome: ");
nome1 = Console.ReadLine();
Console.WriteLine("Idade: ");
idade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dados da segunda pessoa:");
Console.WriteLine("Nome: ");
nome2 = Console.ReadLine();
Console.WriteLine("Idade: ");
idade2 = int.Parse(Console.ReadLine());

//Processamento de dados
media = (idade1 + idade2) / 2;

//Saida de dados
Console.WriteLine($"A media das idades de {nome1} e {nome2} é: {media:f1}");