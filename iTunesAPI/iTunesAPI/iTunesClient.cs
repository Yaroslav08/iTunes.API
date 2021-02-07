using iTunesAPI.Services;
using iTunesAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace iTunesAPI
{
    public class iTunesClient
    {
        private string version = "1.0";

        private IAlbumService album;
        private IArtistService artist;
        private IPodcastService podcast;
        private ISongService song;
        private ITVEpisodeService tvEposide;
        private ITVSeasonService tvSeason;


        public iTunesClient()
            :this(new AlbumService(), new ArtistService(), new PodcastService(), new SongService(), new TVEpisodeService(), new TVSeasonService())
        { }
        public iTunesClient(IAlbumService album, IArtistService artist, IPodcastService podcast, ISongService song, ITVEpisodeService tvEposide, ITVSeasonService tvSeason)
        {
            this.album = album;
            this.artist = artist;
            this.podcast = podcast;
            this.song = song;
            this.tvEposide = tvEposide;
            this.tvSeason = tvSeason;
        }

        public IAlbumService Album => album;
        public IArtistService Artist => artist;
        public IPodcastService Podcast => podcast;
        public ISongService Song => song;
        public ITVEpisodeService TvEposide => tvEposide;
        public ITVSeasonService TvSeason => tvSeason;
        public string Version => version;
    }
}