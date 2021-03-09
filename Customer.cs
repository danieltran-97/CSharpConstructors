using System;
using System.Collections.Generic;

namespace CSharpConstructors
{
    class Customer
    {
        public int Id;
        public string Name;
        //List of Orders
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name)
        {   
            this.Id = id;
            this.Name = name; 
        }
    }
}