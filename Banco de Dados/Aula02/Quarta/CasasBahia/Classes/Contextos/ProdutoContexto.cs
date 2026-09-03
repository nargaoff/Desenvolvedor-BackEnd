using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasasBahia.Classes.Contextos
{
    internal class ProdutoContexto : DbContext
    {
        //Propiedades
        public DbSet<Entidades.Produto> Produtos { get; set; }

        //Metodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcaoDeConstrucao)
        {
            string config = @"Server=ECFP507D1319374\SQLEXPRESS02;Database=ProdutoCasaBahia;Trusted_Connection=True;TrustServerCertificate=True;";
            opcaoDeConstrucao.UseSqlServer(config);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Entidades.Produto>(entidade =>
            {
                entidade.HasKey(e => e.CodigoDoProduto);
                entidade.Property(e => e.NomeDoProduto);
                entidade.Property(e => e.QuantidadeDeProduto);
                entidade.Property(e => e.ValorDoProduto);
            });
        }
    }
}
