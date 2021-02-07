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
    public class TVSeasonService : HttpRequester, ITVSeasonService
    {
        public async Task<TVSeasonsResult> GetTVSeasonById(long seasonId)
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);
            nvc.Add("id", seasonId.ToString());
            var result = await MakeRequestAsync<TVSeasonsResult>(GetFinalUrl(nvc));
            return result;
        }

        public async Task<TVSeasonsResult> GetTVSeasonsForShow(string showName, int resultLimit = 10, string countryCode = "us")
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);
            nvc.Add("term", showName);
            nvc.Add("media", "tvShow");
            nvc.Add("entity", "tvSeason");
            nvc.Add("attribute", "showTerm");
            nvc.Add("limit", resultLimit.ToString());
            nvc.Add("country", countryCode);
            var result = await MakeRequestAsync<TVSeasonsResult>(GetFinalUrl(nvc));
            return result;
        }
    }
}