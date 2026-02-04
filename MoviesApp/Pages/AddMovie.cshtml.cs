using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoviesApp.Pages
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public required string Title { get; set; }

        [BindProperty]
        public required string Description { get; set; }

        [BindProperty]
        public int Rate { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string value = $"{Title} - {Description} - {Rate}";

            return Page();
        }
    }
}
