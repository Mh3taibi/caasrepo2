using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace caasWebApp.Pages
{
    public class ProivederModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public ProivederModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context; 
        }
        [BindProperty]
        public Users NewUser { get; set; }

        public async Task<IActionResult> OnPostAsync(string userType)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            NewUser.UserType = userType;

            _context.Users.Add(NewUser);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index"); // or wherever you want to redirect after signup
        }
        public void OnGet()
        {

        }
    }
}
