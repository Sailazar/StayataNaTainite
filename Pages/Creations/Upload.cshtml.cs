using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StayataNaTainite.Data;
using StayataNaTainite.Models;

namespace StayataNaTainite.Pages.Creations
{
    public class UploadModel : PageModel
    {
        private readonly StayataNaTainiteContext _context;

        public UploadModel(StayataNaTainiteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Creation Creation { get; set; } = default!;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _context.Creation.Add(Creation);
            _context.SaveChanges();
            return Redirect("~/");
        }
    }
}
