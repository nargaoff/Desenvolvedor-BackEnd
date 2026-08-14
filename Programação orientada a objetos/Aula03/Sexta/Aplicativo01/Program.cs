using Aplicativo01;
//Declaração de variaveis
double raio;


//Entrada de dados
Console.Write("Entre com o valor do raio da circunferencia: ");
raio = double.Parse(Console.ReadLine());

//Processamento de dados

//Saida de dados
Console.Write($"Circunferencia: {Calculadora.Circunferencia(raio):f2}" +
    $"Volume: {Calculadora.volume(raio):f2}");
Calculadora.PI();