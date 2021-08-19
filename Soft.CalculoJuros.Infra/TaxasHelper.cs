using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;

namespace Soft.CalculoJuros.Infra
{
    public class TaxasHelper : ITaxasHelper
    {
        IConfiguration _configuration;
        private readonly HttpClient _client;

        public TaxasHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            _client = new HttpClient();
            _client.BaseAddress = new Uri(RecuperarUrlApiTaxas());
        }

        public decimal RecuperarTaxaDeJuros()
        {
            HttpResponseMessage response = _client.GetAsync("taxajuros").Result;

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Não foi possível recuperar a taxa de juros.");

            var valor = response.Content.ReadAsStringAsync().Result;

            return Convert.ToDecimal(valor.Replace('.', ','));
        }

        private string RecuperarUrlApiTaxas()
        {
            var urlApi = Environment.GetEnvironmentVariable("UrlApiTaxas");
            if (!string.IsNullOrEmpty(urlApi))
                return urlApi;

            urlApi = Environment.GetEnvironmentVariable("UrlApiTaxas", EnvironmentVariableTarget.Machine);
            if (!string.IsNullOrEmpty(urlApi))
                return urlApi;

            urlApi = _configuration.GetSection("UrlApiTaxas").Value;
            if (!string.IsNullOrEmpty(urlApi))
                return urlApi;

            throw new Exception("URL de acesso a API TAXAS não encontrada nas variáveis de ambiente com chave 'UrlApiTaxas'.");
        }
    }
}
