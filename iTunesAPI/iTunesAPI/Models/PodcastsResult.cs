using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace iTunesAPI.Models
{
    public class PodcastsResult
    {
        [JsonPropertyName("resultCount")]
        public int Count { get; set; }

        [JsonPropertyName("results")]
        public List<Podcast> Podcasts { get; set; }
    }
}