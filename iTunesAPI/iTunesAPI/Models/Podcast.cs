using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace iTunesAPI.Models
{
    public class Podcast
    {
        [JsonPropertyName("artistId")]
        public long ArtistId { get; set; }

        [JsonPropertyName("collectionId")]
        public long Id { get; set; }

        [JsonPropertyName("artistName")]
        public string ArtistName { get; set; }

        [JsonPropertyName("collectionName")]
        public string Name { get; set; }

        [JsonPropertyName("collectionCensoredName")]
        public string CensoredName { get; set; }

        [JsonPropertyName("artistViewUrl")]
        public string ArtistViewUrl { get; set; }

        [JsonPropertyName("collectionViewUrl")]
        public string PodcastViewUrl { get; set; }

        [JsonPropertyName("artworkUrl100")]
        public string ArtworkUrl { get; set; }

        [JsonPropertyName("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonPropertyName("collectionExplicitness")]
        public string Explicitness { get; set; }

        [JsonPropertyName("trackCount")]
        public int EpisodeCount { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("primaryGenreName")]
        public string Genre { get; set; }

        [JsonPropertyName("contentAdvisoryRating")]
        public string Rating { get; set; }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("longDescription")]
        public string Description { get; set; }

        [JsonPropertyName("feedUrl")]
        public string FeedUrl { get; set; }

        public string ArtworkUrlLarge
        {
            get
            {
                string retval = string.Empty;

                //  See if we can parse the large artwork url from the regular artwork url
                try
                {
                    retval = this.ArtworkUrl.Replace("100x100", "600x600");
                }
                catch (Exception)
                { }

                return retval;
            }
        }
    }
}
