using AbstracaoAtividade.Enumeracoes;
using AbstracaoAtividade.Interfaces;

namespace AbstracaoAtividade.Entidades
{
    public abstract class Contribuinte : IImposto
    {
        private string nome;
        private double rendaAnual;

        public TipoContribuinte Tipo {  get; protected set; }

        public Contribuinte(string nome, double rendaAnual, TipoContribuinte tipo)
        {
            this.nome = nome;
            this.rendaAnual = rendaAnual;
            Tipo = tipo;
        }

        public string GetNome()
        {
            return nome;
        }

        public double GetRendaAnual()
        {
            return rendaAnual;
        }

        public abstract double CalcularImposto();
        public abstract void MostrarDados();
    }
}
