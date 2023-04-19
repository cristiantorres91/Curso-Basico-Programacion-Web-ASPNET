using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RickyAndMortyApi_Razor_Pages.DTO;
using RickyAndMortyApi_Razor_Pages.Model;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RickyAndMortyApi_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        public List<Character> Characters { get; set; }

        public async Task OnGetAsync()
        {
            var apiUrl = "https://rickandmortyapi.com/api/character";

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<RickAndMortyDataDTO>(json);

                    Characters = data.Characters.Select(c => new Character
                    {
                        Id = c.Id,
                        Name = c.Name,
                        ImageUrl = c.Image,
                        Species = c.Species,
                        Status = c.Status
                    }).ToList();
                }
            }
        }
    }

}