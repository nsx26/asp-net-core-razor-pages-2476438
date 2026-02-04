using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data;
using MoviesApp.Data.Models;

namespace MoviesApp.Pages
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; }

        private MoviesDbContext _context;

        public AddMovieModel(MoviesDbContext context)
        {
            _context = context;
        }

        public void OnGetMyOnClick()
        {
            
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string value = $"{Movie.Title} - {Movie.Rate} - {Movie.Description}";

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var movie = new Movie()
            {
                Title = Movie.Title,
                Rate = Movie.Rate,
                Description = Movie.Description
            };

            _context.Movies.Add(movie);
            _context.SaveChanges();

            return Redirect("Movies");
        }
    }
}
