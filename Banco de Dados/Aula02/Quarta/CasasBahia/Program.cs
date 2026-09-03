using CasasBahia.Classes.Contextos;
using CasasBahia.Classes.Entidades;

ProdutoContexto contexto = new ProdutoContexto();

contexto.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("Menu do almoxarifado:");
    Console.WriteLine("\n1 - Consultar item no estoque");
    Console.WriteLine("\n2 - Cadastrar novo produto");
    Console.WriteLine("\n3 - Sair");
    Console.Write("\nEscolha uma opção: ");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            //Consulta ao item no estoque
            Console.Write("Digite o codigo do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
            if (codigoProduto != null)
            {
                codigoProduto.ExibirDados();
            }
            else
            {
                Console.WriteLine($"Codigo do produto não encontrado, codigo: {codigo}");
            }
            break;
        case 2:
            //Cadastro do item no estoque
            CadastroDeItem(contexto);
            break;
        case 3:
            //Sair
            continuar = false;
            Console.WriteLine("Encerrando sistema...");
            break;
        case 4:
            //Sair
            continuar = false;
            Console.WriteLine("Encerrando sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

void CadastroDeItem(ProdutoContexto produto)
{
    Console.WriteLine("== Cadastro de Item ==");
    Console.Write("Digite o nome do produto: ");
    string nome = Console.ReadLine();
    if (string.IsNullOrEmpty(nome) & string.IsNullOrWhiteSpace(nome)) 
    {
        Console.WriteLine("Não permitido cadastro de produto sem nome");
        return;
    }
    Console.Write("Digite a quantidade de produto: ");
    int qtd = int.Parse(Console.ReadLine());
    if (qtd < 0)
    {
        Console.WriteLine("Não permitido valores negativos de itens");
    }
    Console.Write("Digite o custo do produto: ");
    decimal valor = decimal.Parse(Console.ReadLine());
    if (valor < 0)
    {
        Console.WriteLine("Não permitido cadastrar valores negativos de custo de produto");
    }

    Produto produto1 = new Produto(nome, qtd, valor);
    contexto.Produtos.Add(produto1);
    contexto.SaveChanges();
    produto1.ExibirDados();
}

void DeletarItem(ProdutoContexto contexto)
{
    Console.Write("Digite o codigo do produto:");
    int codigo = int.Parse(Console.ReadLine());
    var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);

    if (codigoProduto != null)
    {
        Console.WriteLine("Deseja realmente realizar essa operação? (S/N)");
        char escolha = char.Parse(Console.ReadLine().ToLower());
        if (escolha.Equals('s'))
        {
            contexto.Produtos.Remove(codigoProduto);
            contexto.SaveChanges();
            Console.WriteLine("Operação realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Operação cancelada!");
            return;
        }
    }
}