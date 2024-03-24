using TrelloApp.Contracts.Request;
using TrelloApp.Contracts.Response;
using Refit;

namespace TrelloApp.ApiTrello.API;

public interface IList
{
    [Post(TrelloApp.ApiTrello.TrelloEndpoints.Lists.Create)]
    Task<CreateListResponse> CreateListAsync(CreateListRequest request);
    
    [Get(TrelloApp.ApiTrello.TrelloEndpoints.Lists.GetById)]
    Task<GetListByIdResponse> GetListAsync(string listId);

    [Get(TrelloApp.ApiTrello.TrelloEndpoints.Lists.GetCards)]
    Task<List<ListCardResponse>> GetListCardsAsync(string listId);

    [Put(TrelloApp.ApiTrello.TrelloEndpoints.Lists.Update)]
    Task<UpdateListResponse> UpdateListAsync(UpdateListRequest request, string listId);

    [Put(TrelloEndpoints.Lists.ToggleArchive)]
    Task<ToggleArchiveListResponse> ToggleArchiveAsync(ToggleArchiveListRequest req, string listId);
}