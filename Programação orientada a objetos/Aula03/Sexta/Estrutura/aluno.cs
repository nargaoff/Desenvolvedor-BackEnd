using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura
{
    internal struct aluno
    {
        //Campos
        public string nome;
        public int cpf;
        public double altura;

        public aluno(string nome, int cpf) : this()
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public aluno(string nome, int cpf, double altura)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.altura = altura;
        }


        //Metodos
        public double Idade (int idade)
        {
            return idade / 365;
        }

    }
}
