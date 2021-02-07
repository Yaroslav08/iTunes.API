using System.Text.Json.Serialization;
namespace iTunesAPI.Models
{
    public class Artist
    {
        [JsonPropertyName("artistName")]
        public string ArtistName { get; set; }

        [JsonPropertyName("artistId")]
        public long ArtistId { get; set; }

        [JsonPropertyName("artistType")]
        public string ArtistType { get; set; }

        [JsonPropertyName("artistLinkUrl")]
        public string ArtistLinkUrl { get; set; }

        [JsonPropertyName("amgArtistId")]
        public long AMGArtistId { get; set; }

        [JsonPropertyName("primaryGenreName")]
        public string PrimaryGenreName { get; set; }

        [JsonPropertyName("primaryGenreId")]
        public long PrimaryGenreId { get; set; }
    }
}