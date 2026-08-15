namespace Moeda
{
    internal class ConversorDeMoeda
    {
        public double Cotacao;
        public double Dolares;

        public double Converter()
        {
            double valorReais = Cotacao * Dolares;
            double iof = valorReais * 0.06;

            return valorReais + iof;
        }
    }

    internal class ConversorDeMoedas
    {
        static void Main()
        {
            ConversorDeMoeda conversor = new ConversorDeMoeda();

            Console.Write("Qual é a cotação do dolar?: ");
            conversor.Cotacao = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Quantos dolares voce vai comprar?: ");
            conversor.Dolares = double.Parse(Console.ReadLine()!);

            double valorFinal = conversor.Converter();

            Console.WriteLine("Valor a ser pago em reais = " + valorFinal.ToString("f2"));
        }
    }
}
