using RazorPlayground.Persistence;
using RazorPlayground.Services.Abstract;
using RazorPlayground.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPlayground.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        DataContextReplica dataContext = new();
        public Task<List<Customer>> GetCustomerByCriteria(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            var customerServiceData = new List<Customer>();
            foreach (var item in dataContext.GetCustomers())
            {
                customerServiceData.Add(new Customer { Id = item.Id, Name = item.Name });
            }
            return await Task.FromResult(customerServiceData);
        }
    }
}
