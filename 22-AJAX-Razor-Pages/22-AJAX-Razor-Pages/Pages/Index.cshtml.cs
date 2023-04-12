using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _22_AJAX_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {

        public void OnGet()
        {

        }

        public JsonResult OnGetData()
        {
            var data = new { name = "Juan", age = 25 };
            return new JsonResult(data);
        }
    }
}