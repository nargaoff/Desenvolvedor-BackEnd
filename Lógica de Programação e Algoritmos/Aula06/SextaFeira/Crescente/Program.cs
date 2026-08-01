//Declaração de variaveis
int x, y;

do
{
    Console.WriteLine("Digite dois numeros: ");
    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());
    if (x < y)
    {
        Console.WriteLine("Crescente");
    }
    else if (x > y)
    {
        Console.WriteLine("Decrescente");
    }
} while (x != y);