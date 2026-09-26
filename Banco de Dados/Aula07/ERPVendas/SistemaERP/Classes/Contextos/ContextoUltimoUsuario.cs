using Microsoft.EntityFrameworkCore;
using SistemaERP.Classes.Entidades;
using System.Data.Common;

namespace SistemaERP.Classes.Contextos
{
    internal class ContextoUltimoUsuario : DbContext
    {
        //Propriedades
        public DbSet<UltimoUsuario> ultimoUsuarios { get; set; }
    

    //Metodos

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Data Source=UltimoUsuarioLogado.db";
            opcoesDeConstrucao.UseSqlite(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<UltimoUsuario>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Nome);

                entidade.Property(e => e.Senha);

                entidade.Property(e => e.EsqueceuSenha);

            }

        );
        }


    }
}
