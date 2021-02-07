using iTunesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace iTunesAPI.Services.Interfaces
{
    public interface IArtistService
    {
        Task<Artist> GetArtistByIdAsync(long artistId);
        Task<Artist> GetSongArtistByAMGArtistIdAsync(long amgArtistId);
        Task<ArtistsResult> GetSongArtistsAsync(string artist, int resultLimit = 100, string countryCode = "us");
    }
}