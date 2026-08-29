using Abstracao.Enumeracoes;
using Abstracao.Interface;

namespace Abstracao.Classes.Entidades
{
    abstract internal class Forma : IGeometria
    {
        //Campo
        Cor cor;


        //Construtor
        protected Forma(Cor cor)
        {
            this.cor = cor;
        }

        //Metodo
        public abstract void Area();

        public string Cor()
        {
            return(cor.ToString());
        }
    }
}
