using System;
using System.Collections.Generic;
using System.Linq;
namespace InterviewQAndA
{
    public class Program
    {
        static void Main()
        {
            //var customers = new List<Customer>
            //{
            //    new Customer { Id = 1, Name = "Alice" },
            //    new Customer { Id = 2, Name = "Bob" }
            //};

            //var orders = new List<Order>
            //{
            //    new Order { OrderId = 101, CustomerId = 1 },
            //    new Order { OrderId = 102, CustomerId = 2 }
            //};

            //var result = from customer in customers
            //             join order in orders on customer.Id equals order.CustomerId
            //             select new { CustomerName = customer.Name, OrderId = order.OrderId };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Customer: {item.CustomerName}, Order ID: {item.OrderId}");
            //}

            //Console.ReadKey();

            int[] intArray = new int[] { 9, 2, 4, 3, 1, 5 };
            Console.WriteLine("Original array");
            foreach (int i in intArray)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            // Sort array in ASC order
            Console.WriteLine("Sorted array in ASC order");
            Array.Sort(intArray);

            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Sorted array in DESC order");
            // Sort Array in DESC order
            Array.Reverse(intArray);
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
        
    }

    //public class Customer
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    //public class Order
    //{
    //    public int OrderId { get; set; }
    //    public int CustomerId { get; set; }
    //}
}