using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StayataNaTainite.Data;
using StayataNaTainite.Models;

// TODO: delete this page because it is not needed in the final product
namespace StayataNaTainite.Pages
{
    public class ListUsersModel : PageModel
    {
        private readonly StayataNaTainiteContext _context;

        public ListUsersModel(StayataNaTainiteContext context)
        {
            _context = context;
        }

        public IList<User> Users { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                Users = await _context.User.ToListAsync();
            }
        }
    }
}
