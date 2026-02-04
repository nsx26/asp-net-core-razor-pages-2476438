using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data;
using MoviesApp.Data.Models;
using MoviesApp.Services;

namespace MoviesApp.Pages
{
    public class AddMovieModel(IMoviesService moviesService) : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; }

        public void OnGetMyOnClick()
        {
            
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            string value = $"{Movie.Title} - {Movie.Rate} - {Movie.Description}";

            if (!ModelState.IsValid)
            {
                return Page();
            }

            await moviesService.Add(new Movie()
            {
                Title = Movie.Title,
                Rate = Movie.Rate,
                Description = Movie.Description
            });

            return Redirect("Movies");
        }
    }
}
