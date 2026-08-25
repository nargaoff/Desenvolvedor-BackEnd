using Aluguel.Classes.Entidades;
using Aluguel.Interfaces;

namespace Aluguel.Classes.Servicos
{
    internal class ServAluguel
    {
		//Campos
		private double PrecoHora;
		private double PrecoDia;
		private ITaxaServ taxaServ;
		double pagamento, fatura, taxa;


        //Propriedades
        public double PrecoPorHora
		{
			get { return PrecoHora; }
			private set { PrecoHora = value; }
		}
		public  double PrecoPorDia
		{
			get { return PrecoDia; }
			private set { PrecoDia = value; }
		}
		public ITaxaServ TaxaDeServico
		{
			get { return taxaServ; }
			private set { taxaServ = value; }
		}

		//Construtor
        public ServAluguel(double precoPorHora, double precoPorDia, ITaxaServ taxaDeServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            TaxaDeServico = taxaDeServico;
        }
		//Metodos
		public void CalcularFatura(AluguelCarro aluguelDeCarro)
		{
			TimeSpan duracao;
			double pagamento;

			duracao = aluguelDeCarro.FimLocacao.Subtract(aluguelDeCarro.InicioLocacao);

			if (duracao.TotalHours <= 12.0)
			{
				 pagamento = PrecoPorHora * duracao.TotalHours;
			}
			else 
			{
				 pagamento = PrecoPorDia * duracao.TotalDays;
			}

			 taxa = taxaServ.taxa(pagamento);

			 fatura = pagamento + taxa;
		}

        public override string ToString()
        {
            return $"Pagamento sem taxa: {pagamento:c}" +
			$"\n Taxa: {taxa:c}" +
			$"\n Pagamento Total: {fatura:c}";
        }

	}
}
