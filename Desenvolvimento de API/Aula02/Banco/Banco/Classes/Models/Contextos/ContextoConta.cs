using Banco.Classes.Models.Entidades;
using Microsoft.EntityFrameworkCore;
namespace Banco.Classes.Models.Contextos
{
    public class ContextoConta : DbContext
    {
        public DbSet<ContaBancaria> contas { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = "Data Source =Contas.db";
            opcoesDeConstrucao.UseSqlite(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
          modeloDeConstrucao.Entity<ContaBancaria>(entidade =>
          {
              entidade.HasKey(c => c.NumeroConta);
              entidade.Property(c => c.TitularConta);
              entidade.Property(c => c.Saldo);
          });
        }
    }
}
