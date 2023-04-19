using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RickyAndMortyApi_Razor_Pages.DTO;
using RickyAndMortyApi_Razor_Pages.Model;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RickyAndMortyApi_Razor_Pages.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public Character Character { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync($"https://rickandmortyapi.com/api/character/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<RickAndMortyCharacterDTO>(json);

                    Character = new Character()
                    {
                        Id = data.Id,
                        Name = data.Name,
                        Status = data.Status,
                        Species = data.Species,
                        ImageUrl = data.Image,
                    };

                    return Page();
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}

