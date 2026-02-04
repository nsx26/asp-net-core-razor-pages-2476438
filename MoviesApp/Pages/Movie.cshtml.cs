using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Data.Models;

namespace MoviesApp.Pages
{
    public class MovieModel : PageModel
    {
        [BindProperty]
        public Movie? Movie {  get; set; }

        private MoviesDbContext _context;

        public MovieModel(MoviesDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet(int id)
        {
            Movie = await _context.Movies.FirstOrDefaultAsync(o => o.Id == id);

            return Page();
        }
    }
}
