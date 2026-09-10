using Microsoft.EntityFrameworkCore;
using System.Security;
using Vendas.Classes.Entidades;
namespace Vendas.Classes.Contextos
{
    internal class VendasContexto : DbContext
    {
        //Propriedades
        public DbSet<Vendas1> Vendas { get; set; }

        //Metodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319374\SQLEXPRESS02;Database=CamisasSENAI;Trusted_Connection = True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Vendas1>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.DataCompra).IsRequired();
                entidade.Property(e => e.Tipo).IsRequired();
                entidade.Property(e => e.Marca).IsRequired();
                entidade.Property(e => e.Faturamento);
                entidade.Property(e => e.Lucro);
            });
        }
    }
}
