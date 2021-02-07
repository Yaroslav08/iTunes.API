using iTunesAPI;
using System;

namespace iTunesApi.Sample
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            iTunesClient client = new iTunesClient();
            var res = await client.Song.GetSongsAsync("Roses");


        }
    }
}
