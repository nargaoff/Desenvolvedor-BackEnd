namespace Estoque
{
    internal class Produto
    {
        //Campos
        string nome;
        int quantidade;
        double preco;
        private int field;

        //Construtor
        public Produto(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public void AdicionarProdutos(int qtd)
        {
            quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            quantidade -= qtd;
        }

        public double ValorTotal()
        {
            return preco * quantidade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Quantidade: {quantidade}");
            Console.WriteLine($"Preço: R$ {preco:c}");
            Console.WriteLine($"Valor Total em Estoque: R$ {ValorTotal():c}");
        }

    }
}
