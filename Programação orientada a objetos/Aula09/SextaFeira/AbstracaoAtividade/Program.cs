using System;
using System.Collections.Generic;
using AbstracaoAtividade.Entidades;
using AbstracaoAtividade.Servicos;
using AbstracaoAtividade.Enumeracoes;

namespace AbstracaoAtividade
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite a quantidade de contribuintes: ");
            int N = int.Parse(Console.ReadLine());

            List<Contribuinte> contribuintes = new List<Contribuinte>();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n===== CONTRIBUINTE " +
                    (i + 1) + " =====");

                Console.WriteLine("1 - Pessoa Fisica");
                Console.WriteLine("2 - Pessoa Juridica");

                Console.Write("Escolha: ");
                TipoContribuinte tipo = (TipoContribuinte)int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda anual: R$ ");
                double renda = double.Parse(Console.ReadLine());

                if (tipo == TipoContribuinte.Fisica)
                {
                    Console.WriteLine("Gastos com saude: R$ ");
                    double gastosSaude = double.Parse(Console.ReadLine());
                    contribuintes.Add(new PessoaFisica(nome,renda,gastosSaude));
                }
                else if (tipo == TipoContribuinte.Juridica)
                {
                    Console.WriteLine("Numero de funcionarios: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    contribuintes.Add(new Pessoajuridica(nome,renda,funcionarios));
                }
                else
                {
                    Console.WriteLine("Tipo invalido!");
                    i--;
                }
            }

            double totalImposto = 0;

            Console.WriteLine("\n========== RESULTADO ==========");

            foreach (Contribuinte contribuinte in contribuintes)
            {
                contribuinte.MostrarDados();
                totalImposto += CalculadoraImposto.Calcular(contribuinte);
            }
            Console.WriteLine("\n===============================");

            Console.WriteLine("TOTAL DE IMPOSTO ARRECADADO: R$ " +
                totalImposto.ToString("F2"));
        }
    }
}