using Master.Interfaces;
namespace Master.Classes.Entidades
{
    internal class Conta : IOperacoes
    {
        //Campos
        private string titular;
        private int numero;
        private double Saldo;


        //Propriedades
        public double SaldoDaConta
        {
            get { return Saldo; }
            set { Saldo = value; }
        }


        protected int NumeroDaConta
        {
            get { return numero; }
            set { numero = value; }
        }


        protected string TitularDaConta
        {
            get { return titular; }
            set { titular = value; }
        }

        //Construtor
        public Conta(string titularDaConta, int numeroDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
            SaldoDaConta = 0;
        }

        public Conta(string titularDaConta, int numeroDaConta, double saldoDaConta) : this(titularDaConta, numeroDaConta)
        {
            SaldoDaConta = saldoDaConta;

        }

        public virtual void Saque(double qtd)
        {
            SaldoDaConta += qtd;
        }

        public void Deposito(double qtd)
        {
            SaldoDaConta -= qtd;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Titular da conta: {TitularDaConta}\n" +
                $"Numero da conta {NumeroDaConta}\n" +
                $"Saldo da conta: {SaldoDaConta:c}");
        }
    }
}
