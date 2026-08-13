//Entrada de dados
double AreaRetangulo;
double PerimetroRetangulo;
double DiagonalRetangulo;

Console.Write("Digite a largura do retângulo: ");
double largura = double.Parse(Console.ReadLine());

Console.Write("Digite a altura do retângulo: ");
double altura = double.Parse(Console.ReadLine());

Console.Write($"Valores digitados foram: Largura = {largura} e Altura = {altura}");

//Processamento de dados
AreaRetangulo = largura * altura;
PerimetroRetangulo = 2 * (largura + altura);
DiagonalRetangulo = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));

Console.Write($"\nÁrea do retângulo: {AreaRetangulo:f2}");
Console.Write($"\nPerímetro do retângulo: {PerimetroRetangulo:f2}");
Console.Write($"\nDiagonal do retângulo: {DiagonalRetangulo:f2}");