using System;
using System.Collections.Generic;

namespace Models
{
    public class Shop
    {
        List<Order> Orders = new List<Order>();

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public double GetOrdersAvg()
        {
            double sum = 0;
            int count = 0;
            foreach (var item in Orders)
            {
                sum += item.TotalAmount;
                count++;
            }
            return sum / count;
        }

        public double GetOrdersAvg(DateTime dateTime)
        {
            double sum = 0;
            int count = 0;
            foreach (var item in Orders)
            {
                if (item.CreatedAt>dateTime)
                {
                    sum += item.TotalAmount;
                    count++;
                }
            }
            return sum / count;
        }

        public void RemoveOrderByNo(int no)
        {
            foreach (var item in Orders)
            {
                if (item.No == no)
                {
                    Orders.Remove(item);
                }
            }
        }

        public List<Order> FilterOrderByPrice(double minPrice, double maxPrice)
        {
            return Orders.FindAll(x => x.TotalAmount > minPrice && x.TotalAmount < maxPrice);
        }

    }
}
