namespace CasasBahia.Classes.Entidades
{
    internal class Produto
    {

        //Propiedades
        public int CodigoDoProduto { get; set; }
        public string NomeDoProduto { get; set; }
        public int QuantidadeDeProduto { get; set; }
        public decimal ValorDoProduto { get; set; }

        //Construtor
        public Produto(string nomeDoProduto, int quantidadeDeProduto, decimal valorDoProduto)
        {
            NomeDoProduto = nomeDoProduto;
            QuantidadeDeProduto = quantidadeDeProduto;
            ValorDoProduto = valorDoProduto;
        }

        //Metodos
        public void ExibirDados()
        {
            Console.WriteLine("Dados do Produto:");
            Console.WriteLine($"\nCódigo do Produto: {CodigoDoProduto}");
            Console.WriteLine($"\nNome do Produto: {NomeDoProduto}");
            Console.WriteLine($"\nQuantidade do Produto: {QuantidadeDeProduto}");
            Console.WriteLine($"\nValor do Produto: {ValorDoProduto:c}");
        }
        
    }
}
