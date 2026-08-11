
namespace POO2
{
    internal class Produto
    {
        //Campos
        public string Nome;
        public double preco;
        public int quantidade;

        //Metodos
        public void ExibirDados()
        {
            Console.WriteLine($"Nome do produto: {Nome}\n" +
                $"Valor de cómpra: {preco:c}\n" +
                $"Quantidade em estoque: {quantidade}\n" +
                $"Valor total em estoque: {ValorEmEstoque():c}");
        }

        public void AdicionarProdutos(int q)
        {
            quantidade += q;
        }

        public void RemoverProdutos(int q)
        {
            quantidade -= q;
        }

        public double ValorEmEstoque()
        {
            return preco;
        }
    }
}