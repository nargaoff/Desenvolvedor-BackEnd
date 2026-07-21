//Declaração de variáveis
double bAse;
double altura;
double area;
double perimetro;
double diagonal;

//Entrada de dados
Console.Write("Digite a base do retângulo: ");
bAse = double.Parse(Console.ReadLine());
Console.Write("digite a altura do retângulo: ");
altura = double.Parse(Console.ReadLine());

//Processamento de dados
area = bAse * altura;
perimetro = bAse + altura + bAse + altura;
diagonal = Math.Sqrt(Math.Pow(bAse, 2) + Math.Pow(altura, 2));

//Saida de dados
Console.WriteLine($"--Dados do retangulo--\n" + 
    $"area = {area:f2}\n" +
    $"perimetro = {perimetro:n}\n" +
    $"diagonal = {diagonal:n}\n");
