namespace Banco
{
    public class ContaBancaria
    {
        // Primeiro campo
        private string titular;
        private int numero;
        private double saldo;

        //Terceiro membro - Construtor
        public ContaBancaria(string titularDaConta, int numeroDaConta, double saldoDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = saldoDaConta;
        }


        // Segundo membro - Propriedades

        protected string TitularDaConta
        {
            get { return titular; }
            set
            {
                if (value != null | value != "")
                {
                    titular = value;
                }
                else
                {
                    Console.WriteLine("Valor de campo invalido");
                }
            }
        }

      protected int NumeroDaConta
        {
            get { return numero; }
            private set { numero = value; }
        }

       protected  double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public ContaBancaria(string titularDaConta, int numeroDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = 0;
        }

        //Quarto membro - Métodos
        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }

        public void Saque(double quantia)
        {
            if (quantia <= 0)
            {
                Console.WriteLine("Valor invalido, insira o valor positivo ou diferente de zero");
            }
            else
            {
                SaldoDaConta -= quantia + 5.00;
            }
        }

        public string ExibirDados()
        {
            return $"Dados da Conta:\n" +
                $"\tTitular da conta: {TitularDaConta}\n" +
                $"\tNumero da conta: {NumeroDaConta}\n" +
                $"\tSaldo da conta: {SaldoDaConta}";
        }


    }
}
