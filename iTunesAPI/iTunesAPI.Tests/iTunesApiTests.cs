using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
namespace iTunesAPI.Tests
{
    public class iTunesApiTests
    {

        public class SongTests
        {
            [Fact]
            public async void GetRosesSongs()
            {
                iTunesClient client = new iTunesClient();
                var res = await client.Song.GetSongsAsync("Roses");

                Assert.True(res.Songs.Any());
            }
        }
    }
}