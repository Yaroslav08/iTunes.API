using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace iTunesAPI.Models
{
    public class TVSeason
    {
        [JsonPropertyName("artistId")]
        public long ShowId { get; set; }

        [JsonPropertyName("collectionId")]
        public long SeasonId { get; set; }

        [JsonPropertyName("artistName")]
        public string ShowName { get; set; }

        [JsonPropertyName("collectionName")]
        public string SeasonName { get; set; }

        [JsonPropertyName("collectionCensoredName")]
        public string SeasonCensoredName { get; set; }

        [JsonPropertyName("artistViewUrl")]
        public string ShowViewUrl { get; set; }

        [JsonPropertyName("collectionViewUrl")]
        public string SeasonViewUrl { get; set; }

        [JsonPropertyName("artworkUrl100")]
        public string ArtworkUrl { get; set; }

        [JsonPropertyName("collectionPrice")]
        public decimal SeasonPrice { get; set; }

        [JsonPropertyName("collectionHdPrice")]
        public decimal SeasonPriceHD { get; set; }

        [JsonPropertyName("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonPropertyName("collectionExplicitness")]
        public string SeasonExplicitness { get; set; }

        [JsonPropertyName("trackCount")]
        public int SeasonEpisodeCount { get; set; }

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

        public int SeasonNumber
        {
            get
            {
                int retval = 0;
                try
                {
                    string newString = Regex.Replace(this.SeasonName, "[^.0-9]", "");
                    retval = Convert.ToInt32(newString);
                }
                catch (Exception) { }

                return retval;
            }
        }

        public string ArtworkUrlLarge
        {
            get
            {
                string retval = string.Empty;

                try
                {
                    retval = this.ArtworkUrl.Replace("100x100", "600x600");
                }
                catch (Exception) { }

                return retval;
            }
        }
    }
}