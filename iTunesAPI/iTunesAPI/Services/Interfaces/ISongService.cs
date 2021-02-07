using iTunesAPI.Models;
using System.Threading.Tasks;
namespace iTunesAPI.Services.Interfaces
{
    public interface ISongService
    {
        Task<SongsResult> GetSongsAsync(string song, int resultLimit = 100, string attribute = null, string countryCode = "us");
    }
}