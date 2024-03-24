using System;
using System.Threading.Tasks;
using Refit;
using TrelloApp.ApiTrello.API;
using TrelloApp.Contracts.Mapping;
using TrelloApp.Contracts.Response;
using TrelloApp.Contracts.Request;
using TrelloApp.Contracts.Models;

namespace TrelloApp.ApiTrello.Service
{
    public class CardService
    {
        private readonly ICard _cardApi;
        private readonly ICacheService _cache; // Add cache service

        public CardService(ICard cardApi, ICacheService cache) // Add cache to constructor
        {
            _cardApi = cardApi;
            _cache = cache;
        }

        public async Task<Card> CreateCard(CreateCardRequest req)
        {
            try
            {
                var response = await _cardApi.CreateCardAsync(req);
                var mappedCard = response.MapToCard();
                _cache.UpdateCardCache(mappedCard);
                return mappedCard;
            }
            catch (ApiException e)
            {
                throw new Exception($"Api Exception: {e.Content}");
            }
            catch (Exception e)
            {
                throw new Exception($"Critical Exception: {e.Message}");
            }
        }

        public async Task<Card> GetCardById(string cardId, string? listId)
        {
            try
            {
                var cacheKey = $"List_{listId}_Cards";
                var isCached = _cache.TryGetValue(cacheKey, out List<Card> cachedCards);
                if (isCached)
                {
                    Card? cachedCard = cachedCards.FirstOrDefault(card => card.Id == cardId);
                    if (cachedCard != null)
                    {
                        return cachedCard;
                    }
                }

                var response = await _cardApi.GetCardByIdAsync(cardId);
                var mappedCard = response.MapToCard();
                _cache.UpdateCardCache(mappedCard);
                return mappedCard;
            }
            catch (ApiException e)
            {
                throw new Exception($"Api Exception: {e.Content}");
            }
            catch (Exception e)
            {
                throw new Exception($"Critical Exception: {e.Message}");
            }
        }

        public async Task<Card> UpdateCard(UpdateCardRequest req, string cardId, string? oldListId = null)
        {
            try
            {
                var response = await _cardApi.UpdateCardAsync(req, cardId);
                var mappedCard = response.MapToCard();
                _cache.UpdateCardCache(mappedCard, oldListId);
                return mappedCard;
            }
            catch (ApiException e)
            {
                throw new Exception($"Api Exception: {e.Content}");
            }
            catch (Exception e)
            {
                throw new Exception($"Critical Exception: {e.Message}");
            }
        }

        public async Task<ResponseOk> DeleteCard(string cardId, string? listId)
        {
            try
            {
                var cacheKey = $"List_{listId}_Cards";
                await _cardApi.DeleteCardAsync(cardId);
                bool isCached = _cache.TryGetValue(cacheKey, out List<Card> cachedCards);
                if (isCached)
                {
                    var cardToDel = cachedCards.FirstOrDefault(card => card.Id == cardId);
                    if (cardToDel != null) cachedCards.Remove(cardToDel);
                    _cache.Remove(cacheKey);
                    _cache.Set(cacheKey, cachedCards);
                }
                return new ResponseOk { HttpCode = 204, Id = cardId };
            }
            catch (ApiException e)
            {
                throw new Exception($"Api Exception: {e.Content}");
            }
            catch (Exception e)
            {
                throw new Exception($"Critical Exception: {e.Message}");
            }
        }
    }
}
