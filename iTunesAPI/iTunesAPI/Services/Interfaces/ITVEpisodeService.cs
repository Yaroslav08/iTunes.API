using iTunesAPI.Models;
using System.Threading.Tasks;
namespace iTunesAPI.Services.Interfaces
{
    public interface ITVEpisodeService
    {
        Task<TVEpisodesResult> GetTVEpisodesForShow(string showName, int resultLimit = 100, string countryCode = "us");
    }
}