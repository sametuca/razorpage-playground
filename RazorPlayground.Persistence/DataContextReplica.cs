using RazorPlayground.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPlayground.Persistence
{
   
    public class DataContextReplica
    {
        List<Customer> customers = new();
        public List<Customer> GetCustomers()
        {
            customers.Add(new Customer { Name = "samet" });
            customers.Add(new Customer { Name = "samet2" });
            return customers;
        }
    }
}
