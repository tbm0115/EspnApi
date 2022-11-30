using EspnApi.Models.Contracts;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EspnApi
{
    //https://www.espn.com/apis/devcenter/docs/
    public class WebAccessor : IDisposable
    {
        private HttpClient _httpClient;
        private HttpClient Client
        {
            get
            {
                if (_httpClient == null)
                {
                    _httpClient = new HttpClient();
                    _httpClient.DefaultRequestHeaders.Accept.Clear();
                    _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    _httpClient.DefaultRequestHeaders.Add("User-Agent", "Off the Wall Creations - Sports Sign");
                }
                return _httpClient;
            }
        }

        private async Task<T> GetAsync<T>(bool parametersAsSlugs = false, params string[] parameters)
        {
            var type = typeof(T);

            var apiUrlAttribute = type.GetCustomAttribute<ApiUrlAttribute>();
            if (apiUrlAttribute == null) throw new NotImplementedException("Missing ApiUrlAttribute on " + type.FullName);

            string uri = apiUrlAttribute.Url;
            if (parameters != null && parameters.Length > 0)
            {
                if (parametersAsSlugs)
                {
                    if (!uri.EndsWith("/")) uri += "/";
                    uri += string.Join("/", parameters);

                    // QUESTION: Should the parameter format be replaced with slug format? For example "key={value}" => "key/{value}" or "/{value}"
                }
                else
                {
                    uri += "?" + string.Join("&", parameters);
                }
            }

            return await GetAsync<T>(uri);
        }
        private async Task<T> GetAsync<T>(string uri)
        {
            var json = await Client.GetStringAsync(uri);

            if (string.IsNullOrEmpty(json)) throw new NullReferenceException();

            var jsonOptions = new JsonSerializerSettings()
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                },
                TypeNameHandling = TypeNameHandling.Auto
            };
            var result = JsonConvert.DeserializeObject<T>(json, jsonOptions);
            if (result == null) throw new NullReferenceException();
            return result;
        }

        public async Task<TScoreboard> GetScoreboardAsync<TScoreboard>() where TScoreboard : class, IScoreboard
            => await GetAsync<TScoreboard>();
        public async Task<TEventSummary> GetEventSummaryAsync<TEventSummary>(string gameId) where TEventSummary : class, IEventSummary
            => await GetAsync<TEventSummary>(false, $"event={gameId}");

        public void Dispose()
        {
            Client?.Dispose();
        }
    }
}
