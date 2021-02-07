using iTunesAPI.Models;
using iTunesAPI.Services.Interfaces;
using iTunesAPI.Settings;
using System.Threading.Tasks;
namespace iTunesAPI.Services
{
    public class AlbumService : HttpRequester, IAlbumService
    {
        public async Task<AlbumsResult> GetAlbumsAsync(string album, int resultLimit = 100, string attribute = null, string countryCode = "us")
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);
            nvc.Add("term", album);
            nvc.Add("media", "music");
            nvc.Add("entity", "album");
            if (attribute != null)
            {
                nvc.Add("attribute", attribute);
            }
            nvc.Add("limit", resultLimit.ToString());
            nvc.Add("country", countryCode);
            var result = await MakeRequestAsync<AlbumsResult>(GetFinalUrl(nvc));
            return result;
        }

        public async Task<AlbumsResult> GetAlbumsByAMGArtistIdAsync(long amgArtistId, int resultLimit = 100, string countryCode = "us")
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);
            nvc.Add("amgArtistId", amgArtistId.ToString());
            nvc.Add("entity", "album");
            nvc.Add("limit", resultLimit.ToString());
            nvc.Add("country", countryCode);
            var result = await MakeRequestAsync<AlbumsResult>(GetFinalUrl(nvc));
            return result;
        }

        public async Task<AlbumsResult> GetAlbumsByArtistIdAsync(long artistId, int limit = 100, string countryCode = "us")
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);

            nvc.Add("id", artistId.ToString());
            nvc.Add("entity", "album");
            nvc.Add("limit", limit.ToString());
            nvc.Add("country", countryCode);
            var result = await MakeRequestAsync<AlbumsResult>(GetFinalUrl(nvc));
            return result;
        }

        public async Task<AlbumsResult> GetAlbumsFromSongAsync(string song, int resultLimit = 100, string attribute = null, string countryCode = "us")
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);

            nvc.Add("term", song);
            nvc.Add("media", "music");
            nvc.Add("entity", "album");
            if (attribute != null)
            {
                nvc.Add("attribute", attribute);
            }
            nvc.Add("limit", resultLimit.ToString());
            nvc.Add("country", countryCode);
            var result = await MakeRequestAsync<AlbumsResult>(GetFinalUrl(nvc));
            return result;
        }
    }
}