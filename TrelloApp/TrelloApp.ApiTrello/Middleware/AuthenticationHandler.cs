using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TrelloApp.ApiTrello.Middleware;

public class TrelloAuthenticationHandler(string apiKey, string token) : DelegatingHandler
{
    private readonly string _apiKey = apiKey;
    private readonly string _token = token;

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var uriBuilder = new UriBuilder(request.RequestUri);
        var query = System.Web.HttpUtility.ParseQueryString(uriBuilder.Query);

        // Add or update the token and key in the query string.
        query["token"] = _token;
        query["key"] = _apiKey;
        uriBuilder.Query = query.ToString();

        request.RequestUri = uriBuilder.Uri;

        return await base.SendAsync(request, cancellationToken);
    }
}