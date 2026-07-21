//Declaração de variáveis
double largura;
double comprimento;
double area;
double valor;
double preco;

//Entrada de dados
Console.WriteLine("Digite a largura do terreno: ");
largura = double.Parse(Console.ReadLine());
Console.Write("Digite o comprimento do terreno: ");
comprimento = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do metro quadrado do terreno: ");
valor = double.Parse(Console.ReadLine());

//Processamento de dados
area = largura * comprimento;
preco = area * valor;

//Saida de dados
Console.WriteLine($"A área do terreno: {area:n}\nPreço do terreno: R$ {preco:n}"); //:n é usado para formatar o número com separador de milhar e duas casas decimais