using Microsoft.Extensions.Caching.Memory;
using System;
using TrelloApp.Contracts.Models;
using Exception = Java.Lang.Exception;

namespace TrelloApp.ApiTrello.Service;

public interface ICacheService
{
    T Get<T>(string key);
    void Set<T>(string key, T value, TimeSpan? expiry = null);
    bool TryGetValue<T>(string key, out T value);
    void Remove(string key);
    bool UpdateOrganizationCache(Organization updatedOrganization);
    bool UpdateBoardCache(Board updatedBoard);
    bool UpdateListCache(List updatedBoard);
    bool UpdateCardCache(Card updatedBoard, string? oldCacheId = null);
}

public class MemoryCacheService : ICacheService
{
    private readonly IMemoryCache _memoryCache;

    public MemoryCacheService(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

    public T Get<T>(string key)
    {
        return _memoryCache.Get<T>(key);
    }

    public void Set<T>(string key, T value, TimeSpan? expiry = null)
    {
        var options = new MemoryCacheEntryOptions();
        if (expiry.HasValue)
        {
            options.SetAbsoluteExpiration(expiry.Value);
        }
        _memoryCache.Set(key, value, options);
    }

    public bool TryGetValue<T>(string key, out T value)
    {
        return _memoryCache.TryGetValue(key, out value);
    }

    public void Remove(string key)
    {
        _memoryCache.Remove(key);
    }
    
    public bool UpdateOrganizationCache(Organization updatedOrganization)
    {
        try
        {
            var cacheKey = $"Organizations";
            bool isCached = _memoryCache.TryGetValue(cacheKey, out List<Organization> cachedOrganization);
            if (isCached)
            {
                var itemToUpdate = cachedOrganization.FirstOrDefault(organization => organization.Id == updatedOrganization.Id);
                if (itemToUpdate != null)
                {
                    cachedOrganization.Remove(itemToUpdate);
                }
                cachedOrganization.Add(updatedOrganization);
                _memoryCache.Remove(cacheKey);
                _memoryCache.Set(cacheKey, cachedOrganization);
            }
            else
            {
                var listToCache = new List<Organization>();
                listToCache.Add(updatedOrganization);
                _memoryCache.Set(cacheKey, listToCache, TimeSpan.FromMinutes(10));
            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public bool UpdateBoardCache(Board updatedBoard)
    {
        try
        {
            var cacheKey = $"Organization_{updatedBoard.IdOrganization}_Boards";
            bool isCached = _memoryCache.TryGetValue(cacheKey, out List<Board> cachedBoards);

            if (isCached)
            {
                var itemToUpdate = cachedBoards.FirstOrDefault(board => board.Id == updatedBoard.Id);
                if (itemToUpdate != null)
                {
                    cachedBoards.Remove(itemToUpdate);
                }
                cachedBoards.Add(updatedBoard);
                _memoryCache.Remove(cacheKey);
                _memoryCache.Set(cacheKey, cachedBoards);
            }
            else
            {
                var listToCache = new List<Board>();
                listToCache.Add(updatedBoard);
                _memoryCache.Set(cacheKey, listToCache, TimeSpan.FromMinutes(10));
            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public bool UpdateListCache(List updatedList)
    {
        try
        {
            var cacheKey = $"Board_{updatedList.IdBoard}_Lists";
            bool isCached = _memoryCache.TryGetValue(cacheKey, out List<List> cachedList);

            if (isCached)
            {
                var itemToUpdate = cachedList.FirstOrDefault(list => list.Id == updatedList.Id);
                if (itemToUpdate != null)
                {
                    cachedList.Remove(itemToUpdate);
                }
                cachedList.Add(updatedList);
                _memoryCache.Remove(cacheKey);
                _memoryCache.Set(cacheKey, cachedList);
            }
            else
            {
                var listToCache = new List<List>();
                listToCache.Add(updatedList);
                _memoryCache.Set(cacheKey, listToCache, TimeSpan.FromMinutes(10));
            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public bool UpdateCardCache(Card updatedCard, string? oldListId = null)
    {
        try
        {
            var cacheKey = $"List_{updatedCard.IdList}_Cards";
            bool isCached = _memoryCache.TryGetValue(cacheKey, out List<Card> cachedCard);

            if (oldListId != null)
            {
                var oldCacheKey = $"List_{oldListId}_Cards";
                bool wasCached = _memoryCache.TryGetValue(cacheKey, out List<Card> oldCache);
                if (wasCached)
                {
                    var oldCard = oldCache.FirstOrDefault(card => card.Id == updatedCard.Id);
                    oldCache.Remove(oldCard);
                    _memoryCache.Remove(oldCacheKey);
                    _memoryCache.Set(cacheKey, oldCache, TimeSpan.FromMinutes(10));
                }
            }

            if (isCached)
            {
                var itemToUpdate = cachedCard.FirstOrDefault(card => card.Id == updatedCard.Id);
                if (itemToUpdate != null)
                {
                    cachedCard.Remove(itemToUpdate);
                }
                cachedCard.Add(updatedCard);
                _memoryCache.Remove(cacheKey);
                _memoryCache.Set(cacheKey, cachedCard, TimeSpan.FromMinutes(10));
            }
            else
            {
                var listToCache = new List<Card>();
                listToCache.Add(updatedCard);
                _memoryCache.Set(cacheKey, listToCache, TimeSpan.FromMinutes(10));
            }
            
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
