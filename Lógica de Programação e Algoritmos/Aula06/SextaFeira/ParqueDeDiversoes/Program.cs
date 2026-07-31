//Declaraçoes de variaveis

try
{
    int visitantes, podem = 0;
    double alturaMin, alturaMax, altura;

    //Entrada de dados

    Console.Write("Quantidade de visitantes: ");
    visitantes = int.Parse(Console.ReadLine());

    Console.Write("Altura minima: ");
    alturaMin = double.Parse(Console.ReadLine());

    Console.Write("Altura maxima: ");
    alturaMax = double.Parse(Console.ReadLine());

    for (int i = 1; i <= visitantes; i++)
    {
        Console.Write("Altura dos visitantes" + i + ": ");
        altura = double.Parse(Console.ReadLine());

        if (altura >= alturaMin && altura <= alturaMax)
        {
            podem++;
        }
    }
    Console.WriteLine("Quantidade de pessoas que podem andar: " + podem);
}
catch
{
    Console.Write("Erro: Digite apenas numeros.");
}
