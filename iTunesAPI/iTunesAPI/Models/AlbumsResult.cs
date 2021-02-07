using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace iTunesAPI.Models
{
    public class AlbumsResult
    {
        [JsonPropertyName("resultCount")]
        public int Count { get; set; }

        [JsonPropertyName("results")]
        public List<Album> Albums { get; set; }
    }
}