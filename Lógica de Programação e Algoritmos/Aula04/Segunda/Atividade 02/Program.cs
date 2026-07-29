//Declaração de variaveis
double a, b, c;
double triangulo, bAse, altura, area, perimetro, perimetrotra;

try
{
    //Entrada de dados
    Console.Write("Digite o primeiro valor:");
    a = double.Parse(Console.ReadLine());
    Console.Write("Digite o segundo valor: ");
    b = double.Parse(Console.ReadLine());
    Console.Write("Digite o terceiro valor");
    c = double.Parse(Console.ReadLine());

    //Processamento de dados
    if (a + b > c)
    {
        Console.Write($"Perimetro = {perimetro:f1}");
    }
    else
    {
        Console.WriteLine($"Area =`{perimetrotra}");
    }
}

catch
{
    Console.Write("Digite valores válidos");
}

double Perimetro()
{
    perimetro = a + b + c;
    return perimetro;

    perimetrotra = a + b * c / 2;
    return perimetrotra;
    
}