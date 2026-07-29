async Task Principal()
{
    Console.WriteLine("Pedido anotado");

    await Task.WhenAll(PrepararHamburguer(), PrepararBatata(), PrepararMilkshake());
    Console.WriteLine("Pedido entregue");
}

async Task PrepararHamburguer()
{
    Console.WriteLine("Preparando hamburguer...");
    await Task.Delay(3000);
    Console.WriteLine("Hamburguer pronto!");
}

async Task PrepararBatata()
{
    Console.WriteLine("Preparando batata frita...");
    await Task.Delay(2500);
    Console.WriteLine("Batata Frita pronta!");
}

async Task PrepararMilkshake()
{
    Console.WriteLine("Preparar Milkshake...");
    await Task.Delay(4000);
    Console.WriteLine("MilkShake pronto!");
}

await Principal(); 