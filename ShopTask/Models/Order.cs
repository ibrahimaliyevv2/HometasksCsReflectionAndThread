using System;
namespace Models
{
    public class Order
    {
        private static int _no;

        public Order()
        {
            _no++;
            No = _no;
        }

        public int No { get; set; }
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
