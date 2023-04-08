using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _14_TagHelpers_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        public Movie Movie { get; set; }
        public void OnGet()
        {
            Movie = new Movie { ID= 1, Title = "Los Vengadores", Genre = "Accion" };
        }
    }

    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
    }
}