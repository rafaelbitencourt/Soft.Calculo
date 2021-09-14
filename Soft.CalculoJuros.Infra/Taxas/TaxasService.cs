using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;

namespace Soft.CalculoJuros.Infra.Taxas
{
    public class TaxasService : ITaxasService
    {
        private readonly HttpClient _httpClient;

        public TaxasService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(configuration["UrlApiTaxas"]);
        }

        public async Task<decimal> RecuperarTaxaDeJuros()
        {
            var response = await _httpClient.GetAsync("taxajuros");

            response.EnsureSuccessStatusCode();

            return await JsonSerializer.DeserializeAsync<decimal>(await response.Content.ReadAsStreamAsync());
        }
    }
}
