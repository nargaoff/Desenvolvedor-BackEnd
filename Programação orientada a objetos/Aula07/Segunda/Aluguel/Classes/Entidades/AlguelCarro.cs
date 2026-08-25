namespace Aluguel.Classes.Entidades
{
    internal class AluguelCarro
    {
		//Campos
		private DateTime inicio;
		private DateTime fim;
		private string modelo;


        //Propriedades
        public  DateTime InicioLocacao
		{
			get { return inicio; }
			set { inicio = value; }
		}

		public DateTime FimLocacao
		{
			get { return FimLocacao; }
			set { FimLocacao = value; }
		}

		public string ModeloDoVeiculo
		{
			get { return ModeloDoVeiculo; }
			set { ModeloDoVeiculo = value; }
		}
		//Construtor
        public AluguelCarro(DateTime inicioLocacao, DateTime fimLocacao, string modeloDoVeiculo)
        {
            InicioLocacao = inicioLocacao;
            FimLocacao = fimLocacao;
            ModeloDoVeiculo = modeloDoVeiculo;
        }

	}
}
