using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using W2_RazorExample.Models;

namespace W2_RazorExample.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly W2_RazorExample.Models.MovieContext _context;

        public IndexModel(W2_RazorExample.Models.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
