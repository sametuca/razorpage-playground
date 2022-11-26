using RazorPlayground.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPlayground.Services.Abstract
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomersAsync();
        Task<List<Customer>> GetCustomerByCriteria(Customer customer);
    }
}
