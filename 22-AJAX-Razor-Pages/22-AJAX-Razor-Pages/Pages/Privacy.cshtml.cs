using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _22_AJAX_Razor_Pages.Pages
{
    public class PrivacyModel : PageModel
    {
        [BindProperty]
        public decimal Num1 { get; set; }

        [BindProperty]
        public decimal Num2 { get; set; }
        [BindProperty]
        public string Operation { get; set; }

        public void OnGet()
        {
        }

        public JsonResult OnGetResult(decimal num1, decimal num2, string operation)
        {
            var result = Calculate(num1, num2, operation);
            return new JsonResult(result);
        }

        private decimal Calculate(decimal num1, decimal num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    return 0;
            }
        }
    }
}