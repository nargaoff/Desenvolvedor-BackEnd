using Banco.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Classes.Entidade
{
    internal class Conta : IOperacoes
    {
		//Campos
		private int numero;
		private string titular;
		private double saldo;



        //Propriedades
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


		protected double SaldoDaConta
		{
			get { return saldo; }
			set { saldo = value; }
		}

		//Construtor
       public Conta(int numeroDaConta, string titularDaConta)
		{
			NumeroDaConta = numeroDaConta;
			TitularDaConta = titularDaConta;
			SaldoDaConta = 0;
		}
		public Conta(int numeroDaConta, string titularDaConta, double saldoDaConta)
        {
            NumeroDaConta = numeroDaConta;
			TitularDaConta = titularDaConta;
			SaldoDaConta = saldoDaConta;
        }

        //Saque
		public virtual void Saque(double quantia)
        {
            SaldoDaConta -= quantia + 5.00;
        }

        //Deposito
		public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }
    }
}
