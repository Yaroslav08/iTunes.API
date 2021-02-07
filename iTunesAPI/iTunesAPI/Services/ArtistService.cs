using iTunesAPI.Models;
using iTunesAPI.Services.Interfaces;
using iTunesAPI.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace iTunesAPI.Services
{
    public class ArtistService : HttpRequester, IArtistService
    {
        public async Task<Artist> GetArtistByIdAsync(long artistId)
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);
            nvc.Add("id", artistId.ToString());
            var result = (await MakeRequestAsync<ArtistsResult>(nvc.ToString())).Artists.FirstOrDefault();
            return result ?? new Artist();
        }

        public async Task<Artist> GetSongArtistByAMGArtistIdAsync(long amgArtistId)
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);
            nvc.Add("amgArtistId", amgArtistId.ToString());
            var result = (await MakeRequestAsync<ArtistsResult>(nvc.ToString())).Artists.FirstOrDefault();
            return result ?? new Artist();
        }

        public async Task<ArtistsResult> GetSongArtistsAsync(string artist, int resultLimit = 100, string countryCode = "us")
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);
            nvc.Add("term", artist);
            nvc.Add("media", "music");
            nvc.Add("entity", "musicArtist");
            nvc.Add("attribute", "artistTerm");
            nvc.Add("limit", resultLimit.ToString());
            nvc.Add("country", countryCode);
            var result = await MakeRequestAsync<ArtistsResult>(nvc.ToString());
            return result;
        }
    }
}