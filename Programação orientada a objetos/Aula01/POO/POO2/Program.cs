//Declaração de variaveis
using POO2;
//Produto p = new();
Produto p = new Produto();

//Entrada de dados
Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.preco = double.Parse(Console.ReadLine());
Console.Write("Quantidade: ");
p.quantidade = int.Parse(Console.ReadLine());

Console.Write("Dados do produto: ");
p.ExibirDados();

Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
int quantidade = int.Parse(Console.ReadLine());
p.AdicionarProdutos(quantidade);
Console.WriteLine("Dados atualizados");
p.ExibirDados();

Console.Write("Digite o numero de produtos a ser removido do estoque: ");
quantidade = int.Parse(Console.ReadLine());
p.RemoverProdutos(quantidade);
Console.WriteLine("Dados atualizados");
p.ExibirDados();