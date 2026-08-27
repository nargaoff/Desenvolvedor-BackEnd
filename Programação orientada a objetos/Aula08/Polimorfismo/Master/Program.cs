using Master.Classes.Entidades;
using Master.Enumeracoes;

//Conta contaCesar = new Conta("Cesar", 12345, 1000);
//Conta contaClodoaldo = new ContaPoupanca("Clodoaldo", 123456, 10);
//Conta senai = new ContaEmpresa("Mange", 123456, 1000);

//Declaração de variaveis
Conta conta;
string titular;
int numero;
double saldo, limite, taxa;

//Entrada de dados
Console.WriteLine("Deseja abrir qual tipo de conta: " +
    "\n 1 - Conta pessoa fisica" +
    "\n 2 - Conta poupança" +
    "\n 3 - Conta Empresa");
int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Normal}");
        AbrirConta();
        break;
    case 2:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Poupanca}");
        AbrirPoupanca();
        break;
    case 3:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Empresa}");
        AbrirEmpresa();
        break;
    default:
        Console.WriteLine("Nenhuma opção selecionada");
        conta = null;
        break;
}

Console.WriteLine(conta);

void AbrirConta()
{
    Console.Write("Titular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta: {numero} ");
    Console.Write("Deseja fazer deposito inicial ? (s/n)");
    char opcion = char.Parse(Console.ReadLine().ToLower());
    if ( opcion == 's')
    {
        Console.Write("Qual valor do deposito inicial: ");
        saldo = double.Parse(Console.ReadLine());
        conta = new Conta(titular, numero, saldo);
    }
    else
    {
        conta = new Conta(titular, numero);
    }
}
void AbrirPoupanca()
{
    Console.Write("Titular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta: {numero} ");
    Console.Write($"Limite da conta: ");
    taxa = double.Parse(Console.ReadLine());
    Console.Write("Deseja fazer deposito inicial ? (s/n)");
    char opcion = char.Parse(Console.ReadLine().ToLower());
    if (opcion == 's')
    {
        Console.Write("Qual valor do deposito inicial: ");
        saldo = double.Parse(Console.ReadLine());
        conta = new ContaPoupanca(titular, numero, saldo, taxa);
    }
    else
    {
        conta = new ContaPoupanca(titular, numero, taxa);
    }

}

void AbrirEmpresa()
{
    Console.Write("Titular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta: {numero} ");
    Console.Write($"Limite da conta: ");
    limite = double.Parse(Console.ReadLine());
    Console.Write("Deseja fazer deposito inicial ? (s/n)");
    char opcion = char.Parse(Console.ReadLine().ToLower());
    if (opcion == 's')
    {
        Console.Write("Qual valor do deposito inicial: ");
        saldo = double.Parse(Console.ReadLine());
        conta = new ContaEmpresa(titular, numero, limite);
    }
    else
    {
        conta = new ContaEmpresa(titular, numero, limite);
    }
}
