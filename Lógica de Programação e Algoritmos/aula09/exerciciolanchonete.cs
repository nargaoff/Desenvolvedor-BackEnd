using System.Reflection;

public class program
{
    public static async Task Main()
    {
        Dictionary<int, (string Nome, double Preco)> cardapio = new()
        {
            
        
        {1, ("Cachorro Quente", 4.50) },
        {2, ("X-Salada", 4.50) },
        {3, ("X-Bacon", 5.00) },
        {4, ("Torrada Simples", 2.00) },
        {5, ("Refrigerante", 1.50) }
        };
        bool continuar = true;

        while (continuar)
        {
            try
            {
                Console.Write("""

                2========================================
                        CARDÁPIO DA LANCHONETE       
                ========================================
                CÓDIGO | ITEM            | PREÇO       
                ----------------------------------------
                1    | Cachorro Quente | R$ 4,50     
                2    | X-Salada        | R$ 4,50     
                3    | X-Bacon         | R$ 5,00     
                4    | Torrada Simples | R$ 2,00     
                5    | Refrigerante    | R$ 1,50     
                ========================================
                
                
                """);

                Console.Write("========================================");
                Console.Write("\nDigite o codigo do produto (ou 0 para sair): ");
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == 0)
                {
                    continuar = false;
                    break;
                }

                if (!cardapio.ContainsKey(codigo))
                {
                    throw new Exception("Codigo de produto invalido! Tente novamente.");
                }
                Console.Write("Digite a quantidade desejada: ");
                int quantidade = int.Parse(Console.ReadLine());

                double total = cardapio[codigo].Preco * quantidade;

                Console.Write("\nProcessando pedido... (aguarde)");
                await Task.Delay(2000);

                Console.Write("\nItem selecionado: " + cardapio[codigo].Nome);
                Console.Write($"Total a pagar: R$ {total:F2}");
                Console.Write("----------------------------------------");
            }
            catch (FormatException)
            {
                Console.Write("[ERRO]: Digite apenas numeros.");
            }
            catch (Exception ex)
            {
                Console.Write("[ERRO]: " + ex.Message);
            }
            finally
            {
                Console.Write("[FINALLY]: Operação concluida.");
            }
            if (continuar)
            {
                Console.Write("\nDeseja fazer outro pedido? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta != "S")
                {
                    continuar = false;
                }
            }
        }
        Console.Write("\nSessão de pedidos encerrada.");
    }
}