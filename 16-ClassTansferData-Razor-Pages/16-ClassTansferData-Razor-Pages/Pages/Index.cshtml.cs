using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _16_ClassTansferData_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        [ViewData]
        public string Message { get; set; }
        [BindProperty]
        public string Name { get; set; }
        public void OnGet()
        {
            ViewData["MyString"] = "Hola";
            ViewData["MyNumber"] = 100;

            Message = "Hello Word";

        }

        public IActionResult OnPost()
        {
            // Almacenar mensaje en TempData para mostrar en la página siguiente
            TempData["Name"] = Name;
            // Redirigir a la página siguiente
            return RedirectToPage("/Privacy");
        }
    }
}