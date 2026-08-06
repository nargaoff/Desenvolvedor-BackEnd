//Declaração de variaveis
List<int> numeros = new List<int>();
int n, valor;

try
{
    //Entrada de dados
    Console.Write("Quantos numeros voce vai digitar? ");
    n = int.Parse(Console.ReadLine());

    //Loop determinado
    for (int i = 0; i < n; i++)
    {
        Console.Write("Digite um numero: ");
        valor = int.Parse(Console.ReadLine());
        numeros.Add(valor);
    }
    Console.WriteLine("Numeros negativos: ");
    foreach (var item in numeros)
    {
        if (item < 0)
        {
            Console.WriteLine(item);
        }

    }
}
catch (Exception e)
{
    Console.WriteLine("Valor invalido, erro: " + e);
}


















