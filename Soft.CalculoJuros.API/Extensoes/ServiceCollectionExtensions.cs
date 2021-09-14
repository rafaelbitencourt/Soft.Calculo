using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;
using Soft.CalculoJuros.Aplicacao.CalculoJuros;
using Soft.CalculoJuros.Infra.Taxas;
using System;
using System.Net.Http;

namespace Soft.CalculoJuros.API.Extensoes
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAplicCalculoJuros, AplicCalculoJuros>();

            services.AddHttpClient<ITaxasService, TaxasService>()
                .AddPolicyHandler(GetRetryPolicy())
                .AddPolicyHandler(GetCircuitBreakerPolicy());

            return services;
        }

        public static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy() =>
            HttpPolicyExtensions.HandleTransientHttpError()
                .WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromMilliseconds(Math.Pow(2, retryAttempt) * 1000));

        public static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy() =>
            HttpPolicyExtensions.HandleTransientHttpError()
                .CircuitBreakerAsync(15, TimeSpan.FromSeconds(15));
    }
}
