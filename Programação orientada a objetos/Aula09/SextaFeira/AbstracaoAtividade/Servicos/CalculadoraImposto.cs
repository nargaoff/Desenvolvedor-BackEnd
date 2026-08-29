using AbstracaoAtividade.Entidades;

namespace AbstracaoAtividade.Servicos
{
    public class CalculadoraImposto
    {
        public static double Calcular(Contribuinte contribuinte)
        {
            return contribuinte.CalcularImposto();
        }
    }
}
