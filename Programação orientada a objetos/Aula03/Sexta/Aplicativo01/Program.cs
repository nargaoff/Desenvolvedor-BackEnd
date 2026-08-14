using Aplicativo01;
//Declaração de variaveis
Calculadora calculadora;
double raio;


//Entrada de dados
Console.Write("Entre com o valor do raio da circunferencia: ");
raio = double.Parse(Console.ReadLine());

//Instanciação do objeto
calculadora = new Calculadora(raio);

//Processamento de dados

//Saida de dados
Console.Write($"Circunferencia: {calculadora.Circunferencia():f2}" +
    $"Volume: {calculadora.volume:f2}");
calculadora.PI();