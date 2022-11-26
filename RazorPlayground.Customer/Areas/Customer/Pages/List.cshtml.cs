using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPlayground.Services.Abstract;

namespace RazorPlayground.Customer.Areas.Customer.Pages
{
    public class ListModel : PageModel
    {
        private readonly ICustomerService _customerService;
        public ListModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IList<Services.Models.Customer>? Customers { get; set; }
        public async Task<IActionResult> OnGet(CancellationToken token)
        {
            Customers = await _customerService.GetCustomersAsync();
            return Page();
        }
    }
}
