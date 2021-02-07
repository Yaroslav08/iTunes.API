using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace iTunesAPI.Models
{
    public class SongsResult
    {
        [JsonPropertyName("resultCount")]
        public int Count { get; set; }

        [JsonPropertyName("results")]
        public List<Song> Songs { get; set; }
    }
}