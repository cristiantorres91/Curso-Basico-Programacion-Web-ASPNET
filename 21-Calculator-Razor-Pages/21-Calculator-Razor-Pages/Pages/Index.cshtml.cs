using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _21_Calculator_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public decimal Num1 { get; set; }

        [BindProperty]
        public decimal Num2 { get; set; }
        [BindProperty]
        public string Operation { get; set; }
        [ViewData]
        public string Result { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            Result = Calculate().ToString();

            return Page();
        }

        public decimal Calculate()
        {
            switch (Operation)
            {
                case "+":
                    return Num1 + Num2;
                case "-":
                    return Num1 - Num2;
                case "*":
                    return Num1 * Num2;
                case "/":
                    return Num1 / Num2;
                default:
                    return 0;
            }
        }

    }
}