using Contrato.Classes.Contratos;

namespace Contrato.Classes.Entidades
{
    internal class Funcionarios
    {
		//Campos
		private string nome;
		private List<HoraContrato> contratos;

        //Propriedades
		protected string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		protected List<HoraContrato> Contratos
		{
			get { return contratos; }
			set { contratos = value; }
		}
       
		//Construtor
		public Funcionarios(string nome)
        {
            Nome = nome;
        }

		//Metodos
		public void AdicionarContrato(double valor, int horas)
		{
			HoraContrato contrato = new HoraContrato(horas, valor);
			Contratos.Add(contrato);
		}
	}
}
