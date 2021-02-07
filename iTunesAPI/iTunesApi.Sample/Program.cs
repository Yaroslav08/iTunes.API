using iTunesAPI;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace iTunesApi.Sample
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            iTunesClient client = new iTunesClient();
            var res = await client.Song.GetSongsAsync("Roses", 200);
            foreach (var item in res.Songs)
            {
                RunPreviewMusic(item.PreviewUrl);
            }

            //var song = res.Songs.FirstOrDefault(d => d.ArtistName.Contains("SAINt"));
            //RunPreviewMusic(song.PreviewUrl);
        }

        static void RunPreviewMusic(string url)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
