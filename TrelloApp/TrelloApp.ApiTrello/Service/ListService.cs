using Refit;
using TrelloApp.ApiTrello.API;
using TrelloApp.Contracts.Mapping;
using TrelloApp.Contracts.Response;
using TrelloApp.Contracts.Request;
using TrelloApp.Contracts.Models;
using Exception = Java.Lang.Exception;

namespace TrelloApp.ApiTrello.Service;

public class ListService
{
    private IList _listApi;
    private ICacheService _cache;

    public ListService(IList listApi, ICacheService cache)
    {
        _listApi = listApi;
        _cache = cache;
    }

    public async Task<List> CreateList(CreateListRequest req)
    {
        try
        {
            var response = await _listApi.CreateListAsync(req);
            var mappedList = response.MapToList();
            _cache.UpdateListCache(mappedList);
            return mappedList;
        }
        catch (ApiException e)
        {
            throw new Exception($"Api Exception: {e.Message}");
        }
        catch (Exception e)
        {
            throw new Exception($"Critical Exception: {e.Message}");
        }
    }

    public async Task<List> GetListById(string listId, string? boardId)
    {
        try
        {
            if (boardId != null)
            {
                var cacheKey = $"Board_{boardId}_Lists";
                var isCached = _cache.TryGetValue(cacheKey, out List<List> cachedLists);
                if (isCached)
                {
                    List? cachedList =
                        cachedLists.FirstOrDefault(list => list.Id == listId);
                    if (cachedList != null)
                    {
                        return cachedList;
                    }
                };
            }
            var response = await _listApi.GetListAsync(listId);
            var mappedList = response.MapToList();
            _cache.UpdateListCache(mappedList);
            return mappedList;
        }
        catch (ApiException e)
        {
            throw new Exception($"Api Exception: {e.Message}");
        }
        catch (Exception e)
        {
            throw new Exception($"Critical Exception: {e.Message}");
        }
    }

    public async Task<List<Card>> GetListCards(string listId)
    {
        try
        {
            var cacheKey = $"List_{listId}_Cards";
            var isCached = _cache.TryGetValue(cacheKey, out List<Card> listCards);
            if (isCached) return listCards;
            
            var response = await _listApi.GetListCardsAsync(listId);
            var mappedCards = response.MapToCards();
            foreach (var card in mappedCards)
            {
                _cache.UpdateCardCache(card);
            }
            return mappedCards;
        }
        catch (ApiException e)
        {
            throw new Exception($"Api Exception: {e.Message}");
        }
        catch (Exception e)
        {
            throw new Exception($"Critical Exception: {e.Message}");
        }
    }

    public async Task<List> UpdateList(UpdateListRequest req, string listId)
    {
        try
        {
            var response = await _listApi.UpdateListAsync(req, listId);
            var mappedList = response.MapToList();
            _cache.UpdateListCache(mappedList);
            return mappedList;
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

    public async Task<List> ToggleArchiveList(ToggleArchiveListRequest req, string listId)
    {
        try
        {
            var response = await _listApi.ToggleArchiveAsync(req, listId);
            var mappedList = response.MapToList();
            var cacheKey = $"Board_{mappedList.IdBoard}_Lists";
            bool isCached = _cache.TryGetValue(cacheKey, out List<List> lists);
            if (isCached)
            {
                var listToArchive = lists.FirstOrDefault(list => list.Id == listId);
                if (listToArchive != null) lists.Remove(listToArchive);
                _cache.Remove(cacheKey);
                _cache.Set(cacheKey, lists);
            }
            return mappedList;
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

