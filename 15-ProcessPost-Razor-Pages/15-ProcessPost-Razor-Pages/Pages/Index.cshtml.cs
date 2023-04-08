using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _15_ProcessPost_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        //Este atributo se utiliza para simplificar el proceso de vinculación de datos
        //entre una página Razor y un formulario HTML
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int Age { get; set; }
        public bool IsAdult { get; set; }


        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (Age >= 18)
            {
                IsAdult = true;
            }
            else
            {
                IsAdult = false;
            }
        }
    }
}
