using _21_Calculator_Razor_Pages.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _21_Calculator_Razor_Pages.Pages
{
    public class PrivacyModel : PageModel
    {
        [BindProperty]
        public decimal Num1 { get; set; }

        [BindProperty]
        public decimal Num2 { get; set; }
        [BindProperty]
        public List<Operation> Operation { get; set; }
        [BindProperty]
        public string SelectedOperation { get; set; }
        [ViewData]
        public string Result { get; set; }

        public void OnGet()
        {
            GetRequiredDataToLoadPage();

        }

        public IActionResult OnPost()
        {
            Result = Calculate().ToString();
            GetRequiredDataToLoadPage();

            return Page();
        }


        private void GetRequiredDataToLoadPage()
        {
            Operation = new List<Operation>()
            {
                new Operation() { Id = "1", Description = "Sumar"},
                new Operation() { Id = "2", Description = "Restar"},
                new Operation() { Id = "3", Description = "Multiplicar"},
                new Operation() { Id = "4", Description = "Dividir"},
            };
        }
        private decimal Calculate()
        {
            switch (SelectedOperation)
            {
                case "1":
                    return Num1 + Num2;
                case "2":
                    return Num1 - Num2;
                case "3":
                    return Num1 * Num2;
                case "4":
                    return Num1 / Num2;
                default:
                    return 0;
            }
        }
    }
}