using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private object _context;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string MovieGenre { get; private set; }
        public string SearchString { get; private set; }
        public SelectList Genres { get; private set; }
        public object Movie { get; private set; }

        public void OnGet()
        {

        }
    }
}
