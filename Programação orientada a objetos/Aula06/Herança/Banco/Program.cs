using Banco.Classes.Entidade;

bool sair = false;
while (!sair)
{

    Console.WriteLine("Selecione qual tipo de conta deseja abrir: \n +" +
        "\t 1 - Conta normal\n +" +
        "\t 2 - Conta Poupança\n +" +
        "\t 3 - Conta Empresa\n" +
        "\t 4 - Sair");
    int selecao = int.Parse(Console.ReadLine());
    switch (selecao)
    {
        case 1:
            Console.WriteLine("Selecionado conta normal");
            break;
        case 2:
            Console.WriteLine("Selecionado conta poupança");

            Console.Write("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Taxa de juros:");
            double taxa = double.Parse(Console.ReadLine());
            ContaPoupanca conta = new ContaPoupanca(numero, titular, taxa);
            Console.WriteLine("Deseja faze deposito inicial ? (s/n)");
            char op = char.Parse(Console.ReadLine().ToLower());
            if (op == 'n')
            {

            }
            break;
        case 3:
            Console.WriteLine("Selecionado conta empresa");
            break;
        case 4:
            sair = true;
            break;
        default:
            Console.WriteLine("selecionado nenhuma opção, tente novamente");
            break;
            
            Console.Write("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Taxa de juros: ");
            double taxa = double.Parse(Console.ReadLine());
            ContaPoupanca conta = new ContaPoupanca(numero, titular, taxa);


            Console.WriteLine("Deseja fazer deposito inicial ? (s/n)");
            char op = char.Parse(Console.ReadLine().ToLower());
            if (op == 'n')
            {
                Console.Write("Qual valor do deposito inicial? ");
                double valor = double.Parse(Console.ReadLine());

                conta.Deposito(valor);
            }
    }
}
