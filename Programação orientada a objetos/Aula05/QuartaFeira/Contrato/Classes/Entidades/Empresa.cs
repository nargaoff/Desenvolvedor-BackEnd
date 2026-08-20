namespace Contrato.Classes.Entidades
{
    internal class Empresa
    {	
		//Campos
		private string nome;
		private Funcionarios funcionarios;

        //Propriedades
        protected string NomeDaEmpresa
		{
			get { return nome; }
			set { nome = value; }
		}
		protected Funcionarios Funcionarios
		{
			get { return funcionarios; }
			set { funcionarios = value; }
		}
        
		//Construtor
		public Empresa(string nomeDaEmpresa, string nomeFuncionario)
        {
            NomeDaEmpresa = nomeDaEmpresa;
			Funcionarios = new Funcionarios(nomeFuncionario);
		
		}
		//Metodos
		public void RegistrarContratoFuncionario(double valor, int horas)
		{
			Funcionarios.AdicionarContrato(valor, horas);
		}


	}
}
