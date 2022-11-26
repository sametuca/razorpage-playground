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
        public Task<List<Customer>> GetCustomerByCriteria(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetCustomersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
