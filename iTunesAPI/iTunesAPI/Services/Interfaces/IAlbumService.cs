using iTunesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace iTunesAPI.Services.Interfaces
{
    public interface IAlbumService
    {
        Task<AlbumsResult> GetAlbumsByArtistIdAsync(long artistId, int limit = 100, string countryCode = "us");
        Task<AlbumsResult> GetAlbumsByAMGArtistIdAsync(long amgArtistId, int resultLimit = 100, string countryCode = "us");
        Task<AlbumsResult> GetAlbumsAsync(string album, int resultLimit = 100, string attribute = null, string countryCode = "us");
        Task<AlbumsResult> GetAlbumsFromSongAsync(string song, int resultLimit = 100, string attribute = null, string countryCode = "us");
    }
}