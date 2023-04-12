using _20_PrintListInTable_Razor_Pages.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _20_PrintListInTable_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        public List<Person> Persons { get; set; }

        public void OnGet()
        {
            Persons = new List<Person>()
            {
                new Person { Id = 1, Name = "Diego", LastName= "Maradona", Age = 40 },
                new Person { Id = 2, Name = "Edson", LastName= "Pele", Age = 50},
                new Person { Id = 3, Name = "Cristian", LastName= "Ronaldo", Age = 36 },
                new Person { Id = 4, Name = "Leonel", LastName= "Messi", Age = 35 },
            };
        }
    }
}