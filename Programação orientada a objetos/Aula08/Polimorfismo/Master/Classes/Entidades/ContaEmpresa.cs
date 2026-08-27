using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Classes.Entidades
{
    internal class ContaEmpresa : Conta
    {
        //Campos
        private double limite;

       //Propriedades
        protected double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }
        public ContaEmpresa(string titularDaConta, int numeroDaConta, double limite) : base(titularDaConta, numeroDaConta)
        {
            LimiteEmprestimo = limite;
        }

        public ContaEmpresa(int numeroDaConta, string titularDaConta, double saldoDaConta, double limite) : base(titularDaConta, numeroDaConta, saldoDaConta)
        {
            LimiteEmprestimo = limite;
        }

        //Metodo
        public void Emprestimo(double qtd)
        {
            LimiteEmprestimo -= qtd;
            SaldoDaConta += qtd;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Limite para emprestimo: {LimiteEmprestimo:c}");
        }
    }
}
