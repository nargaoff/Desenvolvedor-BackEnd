
namespace Banco.Classes.Entidade
{
    internal sealed class ContaEmpresa : Conta
    {
		//Campos
		private double limite;


        //Propriedades
        protected double LimiteDeEmprestimo
		{
			get { return limite; }
			set { limite = value; }
		}
		//Construtores
        public ContaEmpresa(int numeroDaConta, string titularDaConta, double limite) : base(numeroDaConta, titularDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        public ContaEmpresa(int numeroDaConta, string titularDaConta, double saldoDaConta, double limite) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        //Emprestimo
        public void Emprestimo(double quantia)
        {
            if (quantia <= LimiteDeEmprestimo)
            {
                SaldoDaConta += quantia;
            }
            else
            {
                Console.WriteLine("Valor do emprestimo ultrapassa o limite.");
            }
        }
        


	}
}
