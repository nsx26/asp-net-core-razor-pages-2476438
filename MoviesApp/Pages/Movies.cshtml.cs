using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data.Models;
using MoviesApp.Services;

namespace MoviesApp.Pages
{
    public class MoviesModel(IMoviesService moviesService) : PageModel
    {
        public List<Movie> Movies { get; set; } = [];

        public async Task OnGetAsync()
        {
            Movies = await moviesService.GetAll();
        }         
    }
}
