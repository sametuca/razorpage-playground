using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using RazorPlayground.Persistence.Entities;

namespace RazorPlayground.Identity.Areas.Identity.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ReturnUrl { get; set; }

        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public LoginModel(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult OnGet()
        {
            if (User?.Identity?.IsAuthenticated == true)
            {
                return Redirect("/application/common/welcome");
            }
            //Response.Cookies.Delete(Constants.CookieName, new CookieOptions { Path = "/", Expires = DateTime.Now.AddDays(1) });
            return Page();
        }

        public async Task<RedirectToPageResult> OnPost(CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.FindByNameAsync(Username).Result;
                if (user != null)
                {
                    var result = _signInManager.PasswordSignInAsync(user, Password, false, false).Result;
                    if (result.Succeeded)
                    {
                        return RedirectToPage("/Application/Common/Welcome");
                    }
                }
            }
            return RedirectToPage("/Application/Common/Welcome");
        }
    }
}
