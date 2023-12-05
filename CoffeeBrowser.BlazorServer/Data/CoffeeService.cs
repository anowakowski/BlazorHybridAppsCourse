using CoffeeBrowser.Library.Data;
using System.Net.Http.Json;

namespace CoffeeBrowser.BlazorServer.Data
{
    public class CoffeeService : ICoffeeService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CoffeeService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<Coffee>?> LoadCoffeesAsync()
        {
            using var httpClient = _httpClientFactory.CreateClient();

            var coffees = await httpClient.GetFromJsonAsync<IEnumerable<Coffee>>("https://www.thomasclaudiushuber.com/pluralsight/coffees.json");

            return coffees;
        }        
    }
}
