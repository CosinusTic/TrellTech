using TrelloApp.Contracts.Request;
using TrelloApp.Contracts.Response;
using Refit;

namespace TrelloApp.ApiTrello.API;

public interface ICard
{
    [Post(TrelloEndpoints.Cards.Create)]
    Task<CreateCardResponse> CreateCardAsync(CreateCardRequest request);

    [Get(TrelloEndpoints.Cards.GetById)]
    Task<GetCardByIdResponse> GetCardByIdAsync(string cardId);

    [Put(TrelloEndpoints.Cards.Update)]
    Task<UpdateCardResponse> UpdateCardAsync(UpdateCardRequest request, string cardId);

    [Delete(TrelloEndpoints.Cards.Delete)]
    Task DeleteCardAsync(string cardId);
}