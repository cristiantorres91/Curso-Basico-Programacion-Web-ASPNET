using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _23_PartialViews_Razor_Pages.Pages
{
    public class PrivacyModel : PageModel
    {
        public List<string> Comments = new List<string>();
        public IActionResult OnGetComments()
        {
            Comments.AddRange(new[] { "Comentario 1", "Comentario 2", "Comentario 3" });
            return Partial("_CommentsProduct", Comments);
        }
    }
}