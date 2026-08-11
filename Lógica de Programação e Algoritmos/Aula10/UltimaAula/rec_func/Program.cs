//Entrada de dados
Console.Write("Base do retangulo: ");
double baseR = double.Parse(Console.ReadLine());
Console.Write("Altura do retangulo: ");
double alturaR = double.Parse(Console.ReadLine());

//Processamento
double area = Area(baseR, alturaR);
double perimetro = Perimetro(baseR, alturaR);
double diagonal = Diagonal(baseR, alturaR);

//Saida de dados
Console.Write($"Area = {area}, Perimetro = {perimetro}, Diagonal = {diagonal}");

//Funções
double Area(double b, double a)
{
    return b * a;
}

double Perimetro(double b, double a)
{
    return 2 * (b + a);
}

double Diagonal(double b, double a)
{
    return Math.Sqrt((b * b) + (a * a));
}