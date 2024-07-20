using caasWebApp.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace caasWebApp
{
    public class AboutUsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public AboutUsModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }


    }
}
