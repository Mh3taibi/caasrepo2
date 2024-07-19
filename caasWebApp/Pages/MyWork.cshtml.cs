using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace caasWebApp.Pages
{
    public class MyWorkModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public MyWorkModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
