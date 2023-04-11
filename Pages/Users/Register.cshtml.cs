using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StayataNaTainite.Data;
using StayataNaTainite.Models;

namespace StayataNaTainite.Pages.Users
{
    public class RegisterModel : PageModel
    {
        private readonly StayataNaTainiteContext _context;

        public RegisterModel(StayataNaTainiteContext context)
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
            _context.User.Add(User);
            _context.SaveChanges();
            return RedirectToPage("/Users/ListUsers");
        }
    }
}
