using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace iTunesAPI.Settings
{
    public class HttpRequester
    {
        protected async Task<T> MakeRequestAsync<T>(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Config.BaseSearchUrl);
            var result = await client.GetStringAsync(url);
            var obj = JsonSerializer.Deserialize<T>(result);
            return obj;
        }
    }
}