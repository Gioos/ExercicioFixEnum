using ExerFixEnum.Entities;
using ExerFixEnum.Entities.Enums;
using System.Globalization;

namespace ExerFixEnum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do cliente");
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Email: ");
        string email = Console.ReadLine()!;
        Console.Write("Data nascimento (DD/MM/AAAA): ");
        DateTime nascimento = DateTime.Parse(Console.ReadLine()!);
        Console.WriteLine();
        Console.WriteLine("Insira os dados do pedido: ");
        Console.Write("Status: (Processando/Enviado/Entregue) ");
        StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine()!);

        Cliente cliente = new Cliente(nome, email, nascimento);
        Pedido pedido = new Pedido(status, cliente, DateTime.Now);

        Console.Write("Quantos itens tem em seu pedido? ");
        int itemPedido = int.Parse(Console.ReadLine()!);
        Console.WriteLine();

        for (int i = 1; i <= itemPedido; i++)
        {
            Console.WriteLine($"Insira os dados do pedido {i}: ");
            Console.Write("Nome do produto: ");
            string nomeProduto = Console.ReadLine()!;
            Console.Write("Preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Produto produto = new Produto(nomeProduto, precoProduto);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            ItensPedido itensPedido = new ItensPedido(quantidade, precoProduto, produto);
            pedido.AddItem(itensPedido);
        }
        Console.WriteLine();
        Console.WriteLine("RESUMO DO PEDIDO:");
        Console.WriteLine(pedido);
    }
}
