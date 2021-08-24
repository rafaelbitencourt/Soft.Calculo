using Newtonsoft.Json;
using System.Net.Http;

namespace Soft.CalculoJuros.Infra.Taxas
{
    public class TaxasService : ITaxasService
    {
        private readonly HttpClient _httpClient;

        public TaxasService(HttpClient httpClient)
        {
            _httpClient = httpClient;            
        }

        public decimal RecuperarTaxaDeJuros()
        {
            var responseString = _httpClient.GetStringAsync("taxajuros").Result;

            var taxaJuros = JsonConvert.DeserializeObject<decimal>(responseString);

            return taxaJuros;
        }
    }
}
