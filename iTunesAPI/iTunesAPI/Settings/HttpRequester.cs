﻿using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
namespace iTunesAPI.Settings
{
    public class HttpRequester
    {
        protected async Task<T> MakeRequestAsync<T>(string url)
        {
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync(url);
            var obj = JsonSerializer.Deserialize<T>(result);
            return obj;
        }

        protected string GetFinalUrl(HttpValueCollection nc)
        {
            return Config.BaseSearchUrl + nc.ToString();
        }
    }
}