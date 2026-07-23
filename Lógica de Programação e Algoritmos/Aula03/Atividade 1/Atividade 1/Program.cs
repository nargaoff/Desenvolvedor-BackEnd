//Declaração de variaveis
int x;
int y;
int z;
bool pergunta1;
bool pergunta2;
bool pergunta3;
bool pergunta4;
bool logica1;
bool logica2;
bool logica3;

//Entrada de dados
Console.Write("Digite o primeiro valor");
x = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor");
y = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro valor");
z = int.Parse(Console.ReadLine());

//Processamento de dados
pergunta1 = x == z;
pergunta2 = x != y;
pergunta3 = y >  x;
pergunta4 = y <= z;

logica1 = pergunta1 & pergunta3;
logica2 = pergunta2 | pergunta4;
logica3 = !pergunta1;

Console.WriteLine($"O primeiro valor é igual ao terceiro valor? {(pergunta1 ? "Verdadeiro" : "Falso")}");
Console.WriteLine(x == z);

Console.WriteLine($"o primeiro valor é diferente do segundo valor? {(pergunta2 ? "Verdadeiro" : "Falso")}");

Console.WriteLine(x != y);

Console.WriteLine($"O segundo valor é maior que o primeiro valor? {(pergunta3 ? "Verdadeiro" : "Falso")}");
Console.WriteLine(y  > x);

Console.WriteLine($"O segundo valor é menor ou igual que o terceiro valor? {(pergunta4 ? "Verdadeiro" : "Falso")}");

//Saida de dados
Console.WriteLine("--Comparações--");
Console.WriteLine($"O primeiro valor é igual ao terceiro valor ? R: {(pergunta1 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O primeiro valor é diferente do segundo valor ? R: {(pergunta2 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O segundo valor é maior que o primeiro valor ? R: {(pergunta3 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O segundo valor é menor ou igual que o terceiro valor ? R: {(pergunta4 ? "Verdadeiro" : "Falso")}");
Console.WriteLine("--Lógicas--");
Console.WriteLine($"Se a pergunta 1 e pergunta 3 são verdadeiras, R: {(logica1 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"Se a pergunta 2 ou pergunta 4 são verdadeiras, R:{(logica2 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"Se a pergunta 1 não é verdadeira, R:{(logica3 ? "Verdadeiro" : "Falso")}");
