using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace iTunesAPI.Models
{
    public class TVEpisodesResult
    {
        [JsonPropertyName("resultCount")]
        public int Count { get; set; }

        [JsonPropertyName("results")]
        public List<TVEpisode> Episodes { get; set; }]
    }
}