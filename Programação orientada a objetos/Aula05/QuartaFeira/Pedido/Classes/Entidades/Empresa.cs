
namespace Pedido.Classes.Entidades
{
    internal class Empresa
    {
		//Primeiro Membro - Campos
		private string nome;
		private List<Funcionario> funcionarios;


        //Segundo Membro - Propriedades
        protected List<Funcionario> ListaFuncionarios
		{
			get { return funcionarios;; }
			set { funcionarios = value; }
		}
		protected string NomeDaEmpresa
		{
			get { return nome; }
			set { nome = value; }
		}
		
		//Terceiro - Construtor
        public Empresa(string nomeDaEmpresa)
        {
            NomeDaEmpresa = nomeDaEmpresa;
			ListaFuncionarios = new List<Funcionario>();
        }

		//Quarto - Metodos
		
		public void AdicionarFuncionarios(Funcionario funcionario)
		{
			ListaFuncionarios.Add(funcionario);
		}


	}
}
