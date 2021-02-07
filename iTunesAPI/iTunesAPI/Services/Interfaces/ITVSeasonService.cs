using iTunesAPI.Models;
using System.Threading.Tasks;
namespace iTunesAPI.Services.Interfaces
{
    public interface ITVSeasonService
    {
        Task<TVSeasonsResult> GetTVSeasonsForShow(string showName, int resultLimit = 10, string countryCode = "us");
        Task<TVSeasonsResult> GetTVSeasonById(long seasonId);
    }
}