using Banco.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Banco.Classes.Contextos
{
    internal class ContaContext : DbContext
    {
        //Propriedade - Representa as contas do banco de dados
        public DbSet<Conta> contas { get; set; }
        //Metodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string config = @"Server=ECFP507D1319374\SQLEXPRESS02;Database=BancoDBContas;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(config);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeContrucao)
        {
            modeloDeContrucao.Entity<Conta>(entidade =>
            {
                entidade.HasKey(e => e.Id );
                entidade.Property(e => e.NumeroDaConta);
                entidade.Property(e => e.TitularDaConta);
                entidade.Property(e => e.SaldoDaConta);
            });
        }
    }
}
