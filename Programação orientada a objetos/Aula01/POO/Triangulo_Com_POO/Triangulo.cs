namespace Triangulo_Com_POO
{
    internal class Triangulo
    {
        //Membros
        //Primeiro membro -> Campos
        public double a, b, c;

        //Segundo membro -> Métodos
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
