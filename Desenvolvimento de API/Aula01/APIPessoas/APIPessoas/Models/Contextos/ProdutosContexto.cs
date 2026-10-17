using APIPessoas.Models.Entidades;
using Microsoft.EntityFrameworkCore;
namespace APIPessoas.Models.Contextos
{
    public class ProdutosContexto : DbContext
    {
        public DbSet<Produtos> produtos { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = "Data Source=produtos.db";
            opcoesDeConstrucao.UseSqlite(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modelDeConstrucao)
        {
            modelDeConstrucao.Entity<Produtos>(entidade =>
            {
                entidade.HasKey(p => p.Id);
                entidade.Property(p => p.Nome);
                entidade.Property(p => p.Descricao);
                entidade.Property(p => p.Preco);
                entidade.Property(p => p.Quantidade);
            });
        }

    }
}
