using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Soft.CalculoJuros.Infra.Taxas
{
    public class TaxasService : ITaxasService
    {
        private readonly HttpClient _httpClient;

        public TaxasService(HttpClient httpClient)
        {
            _httpClient = httpClient;            
        }

        public async Task<decimal> RecuperarTaxaDeJuros()
        {
            var response = await _httpClient.GetAsync("taxajuros");

            response.EnsureSuccessStatusCode();

            return await JsonSerializer.DeserializeAsync<decimal>(await response.Content.ReadAsStreamAsync());
        }
    }
}
