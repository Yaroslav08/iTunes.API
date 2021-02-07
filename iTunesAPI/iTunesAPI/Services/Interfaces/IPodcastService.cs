using iTunesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace iTunesAPI.Services.Interfaces
{
    public interface IPodcastService
    {
        Task<PodcastsResult> GetPodcasts(string podcast, int resultLimit = 100, string countryCode = "us");
        Task<PodcastsResult> GetPodcastById(long podcastId);
    }
}