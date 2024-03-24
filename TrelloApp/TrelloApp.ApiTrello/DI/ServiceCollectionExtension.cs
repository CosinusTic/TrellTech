using TrelloApp.ApiTrello.Middleware;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Http;
using Refit;
using TrelloApp.ApiTrello.API;
using TrelloApp.ApiTrello.Service;
using TrelloApp.Contracts.Models;

namespace TrelloApp.ApiTrello.DI;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddTrelloApi(this IServiceCollection services, string apiKey, string token)
    {
        services.AddSingleton<BoardService>();
        services.AddSingleton<OrganizationService>();
        services.AddSingleton<ListService>();
        services.AddSingleton<CardService>();
        services.AddTransient<TrelloAuthenticationHandler>(serviceProvider => new TrelloAuthenticationHandler(apiKey, token));
        services.AddRefitClientWithAuth<IBoard>();
        services.AddRefitClientWithAuth<IOrganization>();
        services.AddRefitClientWithAuth<IList>();
        services.AddRefitClientWithAuth<ICard>();
        services.AddMemoryCache();
        services.AddSingleton<ICacheService, MemoryCacheService>();
        return services;
        
    }

    public static IServiceCollection AddRefitClientWithAuth<T>(this IServiceCollection services) where T : class
    {
        services.AddRefitClient<T>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.trello.com"))
            .AddHttpMessageHandler<TrelloAuthenticationHandler>();

        return services;
    }
}