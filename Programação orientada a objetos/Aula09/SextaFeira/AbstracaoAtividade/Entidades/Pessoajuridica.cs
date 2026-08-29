namespace AbstracaoAtividade.Entidades
{
    public class Pessoajuridica : Contribuinte
    {
        private int numeroFuncionarios;

        public Pessoajuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual, Enumeracoes.TipoContribuinte.Juridica)
        {
            this.numeroFuncionarios = numeroFuncionarios;
        }

        public override double CalcularImposto()
        {
            double imposto;
            if (numeroFuncionarios > 10)
            {
                imposto = GetRendaAnual() * 0.14;
            }
            else
            {
                imposto = GetRendaAnual() * 0.16;
            }
            return imposto;
        }

        public override void MostrarDados()
        {
            Console.WriteLine("\n--- Pessoa Juridica ---");
            Console.WriteLine("Nome; " + GetNome());
            Console.WriteLine("Renda anual: R$ " +
                GetRendaAnual().ToString("F2"));
            Console.WriteLine("Numero de funcionarios: " +
                numeroFuncionarios);
            Console.WriteLine("Imposto: R$ " +
                CalcularImposto().ToString("F2"));
        }
    }
}
