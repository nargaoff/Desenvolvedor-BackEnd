//Entrada de dados
Console.Write("Base do retangulo: ");
double baseR = double.Parse(Console.ReadLine());
Console.Write("Altura do retangulo: ");
double alturaR = double.Parse(Console.ReadLine());

//Processamento
Func<double, double, double> calc_area = (b, a) => baseR * alturaR;
Func<double, double, double> calc_perimetro = (b, a) => 2 * (baseR + alturaR);
Func<double, double, double> calc_diagonal = (b, a) => Math.Sqrt((baseR * baseR) + (alturaR * alturaR));

double area = calc_area(baseR, alturaR);
double perimetro = calc_perimetro(baseR, alturaR);
double diagonal = calc_diagonal(baseR, alturaR);

//Saida de dados
Console.Write($"Area = {area.ToString()}, Perimetro = {perimetro.ToString()}, Diagonal = {diagonal.ToString()}");

