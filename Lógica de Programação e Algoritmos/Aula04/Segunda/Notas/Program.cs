//Declaração de variaveis
double nota1, nota2, notafinal;

try
{
    //Entrada de dados
    Console.Write("Digite a primeira nota: ");
    nota1 = double.Parse(Console.ReadLine());
    Console.Write("Digite a segunda nota: ");
    nota2 = double.Parse(Console.ReadLine());
    //Processamento de dados
    Nota();
    //Saida de dados
    Console.WriteLine($"Nota final = {notafinal:f1}");
    if (notafinal < 60)
    {
        Console.WriteLine("Reprovado");
    }

}

catch
{
    Console.WriteLine("Digite valores validos");
}

double Nota()
{
    notafinal = nota1 + nota2;
    return notafinal;
}