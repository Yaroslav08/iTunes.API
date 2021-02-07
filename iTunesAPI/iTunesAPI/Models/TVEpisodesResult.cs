using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace iTunesAPI.Models
{
    public class TVEpisodesResult
    {
        [JsonPropertyName("resultCount")]
        public int Count { get; set; }

        [JsonPropertyName("results")]
        public List<TVEpisode> Episodes { get; set; }
    }
}