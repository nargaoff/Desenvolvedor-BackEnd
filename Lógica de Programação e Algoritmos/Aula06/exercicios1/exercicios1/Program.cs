//Declaração de variaveis 

char turno;

try
{
    //Entrada de dados

    Console.Write("Boa noite!, em que turno voce estuda ?");
    Console.Write("\nDigite o turno em que voce estuda: M - Matutino, V - Vesperino, N - Noturno ");
    turno = char.Parse(Console.ReadLine());
    if (turno == 'M')
    {
        Console.Write("Bom dia");
    }
    else if (turno == 'V')
    {
        Console.Write("Boa Tarde");
    }
    else if (turno == 'N')
    {
        Console.Write("Boa Noite");
    }
    else
    {
        Console.Write("Valor invalido");
    }
}
catch
{
    Console.Write("Valor invalido, digite um caracter valido");
}

