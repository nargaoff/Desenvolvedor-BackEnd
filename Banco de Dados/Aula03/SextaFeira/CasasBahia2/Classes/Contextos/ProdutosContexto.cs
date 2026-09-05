using CasasBahia2.Classes.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasasBahia2.Classes.Contextos
{


    internal class ProdutosContexto : DbContext
    {
        //Propriedades
        public DbSet<Produtos> Produtos { get; set; }

        //Metodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319374\SQLEXPRESS02;DataBaseProdutosCasaBahia;Trusted_Connection=True;TrustServerCertificate=true;";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Produtos>(entidade =>
            {
                entidade.HasKey(e => e.CodigoDoProduto);
                entidade.Property(e => e.NomeDoProduto);
                entidade.Property(e => e.QuantidadeDeProduto);
                entidade.Property(e => e.ValorDoProduto);
            });

        }
    }

}

