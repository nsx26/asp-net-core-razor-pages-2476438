using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data.Models;

namespace MoviesApp.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; } = [];

        public void OnGet()
        {
            Movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Title = "Inception",
                    Rate = 9,
                    Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O."
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Matrix",
                    Rate = 10,
                    Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers."
                },
                new Movie
                {
                    Id = 3,
                    Title = "Interstellar",
                    Rate = 8,
                    Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival."
                }
            };
        }
    }
}
