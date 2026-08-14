
namespace Aplicativo01
{
    internal class Calculadora
    {
        //Membros
        //Primeiro - Campos
        double raio;
        public const double pi = 3.1415;

        //Segundo membro da classe - Construtor
        public Calculadora(double raio)
        {
            this.raio = raio;
        }
        //Terceiro - Métodos
        public double Circunferencia()
        {
            return 2 * pi * raio;
        }

        public double volume()
        {
            return (4 * pi * Math.Pow(raio, 3)) / 3;
        }

        public void PI()
        {
            Console.WriteLine(pi);
        }

    }
}
