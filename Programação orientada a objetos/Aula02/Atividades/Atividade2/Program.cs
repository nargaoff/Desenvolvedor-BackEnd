internal class Atividade2salario
{


    //Declaração de variáveis
    double SalarioLiquido;
    double AumentarPorcentagem;
    double porcentagemaumentada;

    //Entrada de dados
    public static void Main()

    {

        Console.Write("Digite o nome do funcionario: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o salário bruto do funcionario: ");
        double salarioBruto = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do imposto do funcionario: ");
        double imposto = double.Parse(Console.ReadLine());

        //Processamento de dados 

        double SalarioLiquido = salarioBruto - imposto;

        Console.Write("Dados do funcionario:");
        Console.Write("Nome: " + nome);
        Console.Write("Salario Liquido R$ " + SalarioLiquido);

        Console.WriteLine("Digite a porcentagem de aumento do salario do funcionario: ");
        double AumentarPorcentagem = double.Parse(Console.ReadLine());
        AumentarPorcentagem = SalarioLiquido * (AumentarPorcentagem / 100);

        //Saida de dados
        Console.WriteLine("Dados do funcionario atualizado:");
        Console.WriteLine("Nome do funcionario: " + nome);
        Console.WriteLine("salario Liquido: R$ " + ((salarioBruto - imposto) + AumentarPorcentagem));
    }
}