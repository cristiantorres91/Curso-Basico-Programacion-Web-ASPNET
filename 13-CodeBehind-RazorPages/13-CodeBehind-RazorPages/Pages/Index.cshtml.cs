using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _13_CodeBehind_RazorPages.Pages
{
    public class IndexModel : PageModel
    {

        public string Name;
        public int Age;

        public void OnGet()
        {
            Name = "Leonel Messi";
            Age = 35;
        }
    }
}