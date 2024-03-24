using Refit;
using TrelloApp.ApiTrello.API;
using TrelloApp.Contracts.Mapping;
using TrelloApp.Contracts.Response;
using TrelloApp.Contracts.Request;
using TrelloApp.Contracts.Models;
using Exception = Java.Lang.Exception;

namespace TrelloApp.ApiTrello.Service;

public class OrganizationService
{
    private IOrganization _organizationApi;
    private ICacheService _cache;

    public OrganizationService(IOrganization organizationApi, ICacheService cache)
    {
        _organizationApi = organizationApi;
        _cache = cache;
    }

    public async Task<Organization> CreateOrganization(CreateOrganizationRequest req)
    {
        try
        {
            var response = await _organizationApi.CreateOrganizationAsync(req);
            var mappedOrganization = response.MapToOrganization();

            _cache.UpdateOrganizationCache(mappedOrganization);
            
            return mappedOrganization;
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

    public async Task<Organization> GetOrganizationById(string organizationId)
    {
        try
        {
            var cacheKey = $"Organizations";
            var isCached = _cache.TryGetValue(cacheKey, out List<Organization> cachedOrganizations);
            if (isCached)
            {
                Organization? cachedOrganization =
                    cachedOrganizations.FirstOrDefault(organization => organization.Id == organizationId);
                if (cachedOrganization != null)
                {
                    return cachedOrganization;
                }
            };
            
            var response = await _organizationApi.GetOrganizationByIdAsync(organizationId);
            var mappedOrganization = response.MapToOrganization();

           _cache.UpdateOrganizationCache(mappedOrganization);
            
            return mappedOrganization;
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

    public async Task<List<Organization>> GetUserOrganizations()
    {
        try
        {
            var cacheKey = $"Organizations";
            var isCached = _cache.TryGetValue(cacheKey, out List<Organization> cachedOrganizations);
            if (isCached) return cachedOrganizations;
            
            var response = await _organizationApi.GetOrganizationByUserAsync();
            var mappedOrganizations = response.MapToOrganizations();
            foreach (var mappedOrga in mappedOrganizations)
            {
                _cache.UpdateOrganizationCache(mappedOrga);
            }
            _cache.Set(cacheKey, mappedOrganizations, TimeSpan.FromMinutes(5));
            return mappedOrganizations;
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

    public async Task<List<OrganizationMember>> GetOrganizationMembers(string organizationId)
    {
        try
        {
            return await _organizationApi.GetOrganizationMembersAsync(organizationId);
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

    public async Task<List<Board>> GetOrganizationBoards(string organizationId)
    {
        try
        {
            var cacheKey = $"Organization_{organizationId}_Boards";
            var isCached = _cache.TryGetValue(cacheKey, out List<Board> cachedOrganizationBoards);
            if (isCached) return cachedOrganizationBoards;
            
            var response = await _organizationApi.GetOrganizationBoardsAsync(organizationId);
            var mappedBoards = response.MapToBoards();
            foreach (var mappedBoard in mappedBoards)
            {
                _cache.UpdateBoardCache(mappedBoard);
            }
            return mappedBoards;
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

    public async Task<Board> AddBoardToOrganization(AddBoardToOrganizationRequest req)
    {
        try
        {
            var response = await _organizationApi.AddOrganizationBoardAsync(req);
            var mappedBoard = response.MapToBoard();
            _cache.UpdateBoardCache(mappedBoard);
            return mappedBoard;
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

    public async Task<Organization> UpdateOrganization(UpdateOrganizationRequest req,
        string organizationId)
    {
        try
        {
            var response = await _organizationApi.UpdateOrganizationAsync(req, organizationId);
            var mappedOrganization = response.MapToOrganization();
            _cache.UpdateOrganizationCache(mappedOrganization);
            return mappedOrganization;
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

    public async Task<ResponseOk> DeleteOrganization(string organizationId)
    {
        try
        {
            var cacheKey = "Organization";
            await _organizationApi.DeleteOrganizationAsync(organizationId);
            bool isCached = _cache.TryGetValue(cacheKey, out List<Organization> organizations);
            if (isCached)
            {
                var orgaToDel = organizations.FirstOrDefault(organization => organization.Id == organizationId);
                if (orgaToDel != null) organizations.Remove(orgaToDel);
                _cache.Remove(cacheKey);
                _cache.Set(cacheKey, organizations);
            }
            return new ResponseOk()
            {
                HttpCode = 204,
                Id = organizationId
            };
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