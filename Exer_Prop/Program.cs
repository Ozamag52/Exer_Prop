using System;
using Exer_Prop.Entities.Class;
using Exer_Prop.Entities.Enums;
namespace Exer_Prop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

                Client client = new Client(clientName, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status (PendindPayment / Processing / Shipped / Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

                Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order?");
            int qtdItems = int.Parse(Console.ReadLine());

      
            for (int i = 1; i <= qtdItems; i++)
            {
                Console.WriteLine("Enter #" + i + " item data");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double producPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int qtd = int.Parse(Console.ReadLine());

                     Product product = new Product(productName, producPrice);

                     OrderItem orderItem = new OrderItem(qtd, producPrice, product);

                order.AddItem(orderItem);
            }

    

        }
    }
}
