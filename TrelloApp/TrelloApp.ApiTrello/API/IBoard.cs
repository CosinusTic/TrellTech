using TrelloApp.Contracts.Request;
using TrelloApp.Contracts.Response;
using TrelloApp.ApiTrello;
using Refit;

namespace TrelloApp.ApiTrello.API;

public interface IBoard
{
    
    // Boards
    [Post(TrelloEndpoints.Boards.AddList)]
    Task<AddListToBoardResponse> AddListToBoardAsync(AddListToBoardRequest request, string boardId);

    [Get(TrelloEndpoints.Boards.GetById)]
    Task<GetBoardByIdResponse> GetBoardByIdAsync(string boardId);

    [Get(TrelloEndpoints.Boards.GetLists)]
    Task<List<ListResponse>> GetBoardListsAsync(string boardId);
    
    [Put(TrelloEndpoints.Boards.Update)]
    Task<UpdateBoardResponse> UpdateBoardAsync(string boardId, UpdateBoardRequest request);

    [Delete(TrelloEndpoints.Boards.Delete)]
    Task DeleteBoardAsync(string boardId);
    
    // Board members
    [Get(TrelloEndpoints.Boards.BoardMembers.GetAll)]
    Task<List<BoardMemberResponse>> GetBoardMembersAsync(string boardId);

    [Put(TrelloEndpoints.Boards.BoardMembers.InviteByMail)]
    Task<MailInviteResponse> InviteViaEmailAsync(EmailInviteToBoardRequest request, string boardId);

    [Delete(TrelloEndpoints.Boards.BoardMembers.Remove)]
    Task DeleteMemberAsync(string boardId, string memberId);

    [Get(TrelloEndpoints.Members.GetById)]
    Task<GetMemberByIdResponse> GetMemberNameASync(string memberId);
}