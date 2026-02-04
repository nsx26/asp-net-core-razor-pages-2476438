using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data.Models;
using MoviesApp.Services;

namespace MoviesApp.Pages
{
    public class MovieModel(IMoviesService moviesService) : PageModel
    {
        [BindProperty]
        public Movie? Movie { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            Movie = await moviesService.Get(id);

            return Page();
        }
    }
}
