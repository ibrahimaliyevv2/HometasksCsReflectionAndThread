using System;
using Models;
namespace ShopTask
{
    class Program
    {


        static void Main(string[] args)
        {
            Shop shop1 = new Shop();

            Order order1 = new Order
            {
                TotalAmount = 5,
                ProductCount = 2,
                CreatedAt = DateTime.Parse("5/12/2020")
            };

            Order order2 = new Order
            {
                TotalAmount = 7,
                ProductCount = 3,
                CreatedAt = DateTime.Parse("10 / 12 / 2020")
            };

            shop1.AddOrder(order1);
            shop1.AddOrder(order2);

            DateTime dateTime = DateTime.Parse("4 /12/2019");
            Console.WriteLine(shop1.GetOrdersAvg(dateTime));
            Console.WriteLine(shop1.GetOrdersAvg());
        }
    }
}
