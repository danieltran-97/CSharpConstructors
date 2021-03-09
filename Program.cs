using System;

namespace CSharpConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
                var customer = new Customer();
                customer.Id = 1;
                customer.Name = "Jones";

                var order = new Order();
                customer.Orders.Add(order);
        }
    }
}
