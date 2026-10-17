using APIPessoas.Models.Contextos;
using APIPessoas.Models.Entidades;

namespace APIPessoas.Repositorios
{
    public class RepositorioProdutos
    {
        //Campo
        ProdutosContexto contexto = new ProdutosContexto();
        private ProdutosContexto contexo;

        //Propriedades

        protected ProdutosContexto Contexto
        {
            get { return contexo; }
            set { contexo = value; }
        }


        //Métodos
        /// <summary>
        /// Método para listar produtos do banco de dados sqlite
        /// </summary>
        /// <returns></returns>
        public List<Produtos> ListaProdutos()
        {
            return contexto.produtos.ToList();
        }

        /// <summary>
        /// Pesquisa o Id no banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> Se encontrar o Id, retorna o produto, caso contrário, retorna null
        public Produtos PesquisarProdutosID(int id)
        {
            var pesquisar = contexto.produtos.FirstOrDefault(p => p.Id == id);
            return pesquisar;
        }

        /// <summary>
        /// Cria um produto na base de dados
        /// </summary>
        /// <param name="produto">PAssar para a api de um JSON</param>
        /// <example>
        /// {
        ///     "nome" : "TVK",
        ///     "preco" : 2000,
        ///     "descricao": "Toca Fita",
        ///     "quantidade": -10
        /// }
        /// </example>
        public void CriarProduto(Produtos produto)
        {
            contexto.produtos.Add(produto);
            contexto.SaveChanges();
        }

        public void EditarProduto(Produtos produtos)
        {
            Produtos p = PesquisarProdutosID(produtos.Id);
            p.Nome = produtos.Nome;
            p.Preco = produtos.Preco;
            p.Descricao = produtos.Descricao;
            p.Quantidade = produtos.Quantidade;
            contexto.Update(p);
            contexto.SaveChanges();
        }
    }
}
