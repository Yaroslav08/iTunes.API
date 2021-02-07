using iTunesAPI.Models;
using iTunesAPI.Services.Interfaces;
using iTunesAPI.Settings;
using System.Threading.Tasks;
namespace iTunesAPI.Services
{
    public class PodcastService : HttpRequester, IPodcastService
    {
        public async Task<PodcastsResult> GetPodcastById(long podcastId)
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);
            nvc.Add("id", podcastId.ToString());
            var result = await MakeRequestAsync<PodcastsResult>(GetFinalUrl(nvc));
            return result;
        }

        public async Task<PodcastsResult> GetPodcasts(string podcast, int resultLimit = 100, string countryCode = "us")
        {
            var nvc = HttpUrlBuilder.ParseQueryString(string.Empty);
            nvc.Add("term", podcast);
            nvc.Add("media", "podcast");
            nvc.Add("attribute", "titleTerm");
            nvc.Add("limit", resultLimit.ToString());
            nvc.Add("country", countryCode);
            var result = await MakeRequestAsync<PodcastsResult>(GetFinalUrl(nvc));
            return result;
        }
    }
}