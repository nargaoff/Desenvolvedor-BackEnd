using AbstracaoAtividade.Enumeracoes;

namespace AbstracaoAtividade.Entidades
{
    public class PessoaFisica : Contribuinte
    {
        private double gastosSaude;

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual,TipoContribuinte.Fisica)
        {
            this.gastosSaude = gastosSaude;
        }

        public override double CalcularImposto()
        {
            double imposto;
            if (GetRendaAnual() < 20000)
            {
                imposto = GetRendaAnual() * 0.15;
            }
            else
            {
                imposto = GetRendaAnual() * 0.25;
            }

            imposto -= gastosSaude * 0.50;
            if (imposto < 0)
            {
                imposto = 0;
            }
            return imposto;
        }

        public override void MostrarDados()
        {
            Console.WriteLine("\n--- Pessoa Fisica ---");
            Console.WriteLine("Nome: " + GetNome());
            Console.WriteLine("Renda anual: R$ " +
                GetRendaAnual().ToString("F2"));

            Console.WriteLine("Gastos com saude: R$ " +
                gastosSaude.ToString("F2"));

            Console.WriteLine("Imposto: R$ " +
                CalcularImposto().ToString("F2"));
        }

    }
}
