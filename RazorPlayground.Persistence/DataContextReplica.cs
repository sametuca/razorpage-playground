using RazorPlayground.Persistence.Entities;

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
