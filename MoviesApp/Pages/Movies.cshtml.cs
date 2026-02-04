using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data;
using MoviesApp.Data.Models;

namespace MoviesApp.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; } = [];

        private MoviesDbContext _context;

        public MoviesModel(MoviesDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Movies = _context.Movies.ToList();
        }         
    }
}
