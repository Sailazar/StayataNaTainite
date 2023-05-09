using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StayataNaTainite.Data;
using StayataNaTainite.Models;

namespace StayataNaTainite.Pages.Users
{
    public class LoginModel : PageModel
    {
        private readonly StayataNaTainiteContext _context;

        public LoginModel(StayataNaTainiteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; } = default!;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var user = _context.User.Where(u =>
                u.Email.Equals(User.Email) &&
                u.PasswordHash.Equals(User.PasswordHash)
            ).FirstOrDefault();
            if (user != null)
            {
                HttpContext.Session.SetString("Email", User.Email.ToString());
                return Redirect("~/");
            }
            else
            {
                return RedirectToPage("/Users/Login");
            }
        }
    }
}
