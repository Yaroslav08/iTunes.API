using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace iTunesAPI.Models
{
    public class ArtistsResult
    {
        [JsonPropertyName("resultCount")]
        public int Count { get; set; }

        [JsonPropertyName("results")]
        public List<Artist> Artists { get; set; }
    }
}