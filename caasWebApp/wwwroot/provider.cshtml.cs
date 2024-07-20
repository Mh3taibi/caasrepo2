using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Numerics;
using System.Reflection;
using System;
using System.Reflection.PortableExecutable;

namespace caasWebApp.Pages
{
    public class ProviderModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
       // private readonly ApplicationDbContext _context;

        public ProviderModel(ILogger<IndexModel> logger )//, ApplicationDbContext context)
        {
            _logger = logger;
           // _context = context; 
        }
       
        public void OnGet()
        {

        }
    }
}