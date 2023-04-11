using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _19_jQuery_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }
        public void OnGet()
        {
            Name = "Mágico González ";
        }
    }
}