using Pedido.Classes.Entidades;
using Pedido.Classes.Enumeracoes;

Funcionario dev = new Funcionario("Clodoaldo");
Funcionario gerente = new Funcionario("Elma");

Empresa SENAI = new Empresa("João Baptista Salles");
Empresa Suzano = new Empresa("Suzano");

Suzano.AdicionarFuncionarios(gerente);
Suzano.AdicionarFuncionarios(dev);
Console.WriteLine(Suzano);

Suzano = null;

Console.WriteLine(Suzano);
Console.WriteLine(dev);