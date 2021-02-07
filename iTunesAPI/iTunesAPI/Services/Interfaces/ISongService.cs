using iTunesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace iTunesAPI.Services.Interfaces
{
    public interface ISongService
    {
        Task<SongsResult> GetSongsAsync(string song, int resultLimit = 100, string attribute = null, string countryCode = "us");
    }
}