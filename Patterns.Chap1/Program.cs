using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Chap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                TotalCost = 101,
                WeightInKG = 7,
                DispatchAddress = new Address()
                {
                    CountryCode = "1001"
                }
            };

            OrderService orderService = new OrderService();
            orderService.Dispatch(order);
            Console.WriteLine(order.CourierTrackingId);
        }
    }
}
