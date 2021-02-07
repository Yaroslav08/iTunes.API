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
    public class SongService : HttpRequester, ISongService
    {
        public async Task<SongsResult> GetSongsAsync(string song, int resultLimit = 100, string attribute = null, string countryCode = "us")
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);
            nvc.Add("term", song);
            nvc.Add("media", "music");
            nvc.Add("entity", "musicTrack");
            if (attribute != null)
            {
                nvc.Add("attribute", attribute);
            }
            nvc.Add("limit", resultLimit.ToString());
            nvc.Add("country", countryCode);
            var result = await MakeRequestAsync<SongsResult>(nvc.ToString());
            return result;
        }
    }
}