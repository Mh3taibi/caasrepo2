using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace caasWebApp.Pages
{
    public class SupportModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public SupportModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
