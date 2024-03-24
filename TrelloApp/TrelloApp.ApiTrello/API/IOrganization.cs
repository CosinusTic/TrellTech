using Android.Provider;

namespace TrelloApp.ApiTrello.API;
using TrelloApp.Contracts.Response;
using TrelloApp.Contracts.Request;
using Refit;

public interface IOrganization
{
    [Post(TrelloApp.ApiTrello.TrelloEndpoints.Organizations.Add)]
    Task<CreateOrganizationResponse> CreateOrganizationAsync(CreateOrganizationRequest request);

    [Get(TrelloApp.ApiTrello.TrelloEndpoints.Organizations.GetById)]
    Task<GetOrganizationByIdResponse> GetOrganizationByIdAsync(string organizationId);    
    
    [Get(TrelloApp.ApiTrello.TrelloEndpoints.Organizations.GetByUser)]
    Task<List<UserOrganization>> GetOrganizationByUserAsync();
    
    [Get(TrelloApp.ApiTrello.TrelloEndpoints.Organizations.GetMembers)]
    Task<List<OrganizationMember>> GetOrganizationMembersAsync(string organizationId);

    [Get(TrelloApp.ApiTrello.TrelloEndpoints.Organizations.GetBoards)]
    Task<List<OrganizationBoard>> GetOrganizationBoardsAsync(string organizationId);

    [Post(TrelloApp.ApiTrello.TrelloEndpoints.Organizations.AddBoard)]
    Task<AddBoardToOrganizationResponse> AddOrganizationBoardAsync(AddBoardToOrganizationRequest request);

    [Put(TrelloApp.ApiTrello.TrelloEndpoints.Organizations.Update)]
    Task<UpdateOrganizationResponse> UpdateOrganizationAsync(UpdateOrganizationRequest request, string organizationId);

    [Delete(TrelloApp.ApiTrello.TrelloEndpoints.Organizations.Delete)]
    Task DeleteOrganizationAsync(string organizationId);

}