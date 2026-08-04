//Declaração de variaveis

string movimento = "";
int turistas = 0;
int veiculos = 0;

//Entrada de dados

while (movimento != "sair")
{
    Console.Write("Digite o movimento (entrando, voltando ou sair): ");
    movimento = Console.ReadLine()!;

    if (movimento != "sair")
    try
    {
    Console.Write("Quantidade de turistas: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        if (movimento == "entrando")
        {
            turistas += quantidade;
            veiculos++;
        }
        else if (movimento == "voltando")
        {
            turistas -= quantidade;
            veiculos--;
        }
        else
        {
            Console.WriteLine("Movimento invalido!");
        }
    }
    catch
    {
        Console.WriteLine("Digite um numero valido.");
    }

    Console.WriteLine("Turistas no parque: " + turistas);
    Console.WriteLine("Veiculos no parque: " + veiculos);
}
    
Console.WriteLine("\nExpediente encerrado!");