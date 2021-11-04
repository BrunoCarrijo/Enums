using System;
using Enums.Entities;
using Enums.Entities.Enumms;

//     Enumerações
//• É um tipo especial que serve para especificar de forma literal um conjunto
//de constantes relacionadas
//• Palavra chave em C#: enum
//• Nota: enum é um tipo valor
//• Vantagem: melhor semântica, código mais legível e auxiliado pelo
//compilador
namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1050,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
