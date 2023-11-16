using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPTestProject.Data;
using ASPTestProject.Models;

namespace ASPTestProject.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ASPTestProject.Data.ASPTestProjectContext _context;

        public IndexModel(ASPTestProject.Data.ASPTestProjectContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
