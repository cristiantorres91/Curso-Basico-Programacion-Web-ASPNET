using System.Text.Json.Serialization;

namespace RickyAndMortyApi_Razor_Pages.DTO
{
    public class RickAndMortyDataDTO
    {
        [JsonPropertyName("results")]
        public List<RickAndMortyCharacterDTO> Characters { get; set; }
    }
}
