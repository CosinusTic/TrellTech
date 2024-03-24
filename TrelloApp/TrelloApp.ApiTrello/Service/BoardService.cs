using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using TrelloApp.ApiTrello.API;
using TrelloApp.Contracts.Mapping;
using TrelloApp.Contracts.Request;
using TrelloApp.Contracts.Response;
using TrelloApp.Contracts.Models;

namespace TrelloApp.ApiTrello.Service
{
    public class BoardService
    {
        private IBoard _boardApi;
        private ICacheService _cache;

        public BoardService(IBoard boardApi, ICacheService cache)
        {
            _boardApi = boardApi;
            _cache = cache;
        }

        public async Task<List> AddListToBoard(AddListToBoardRequest req, string boardId)
        {
            try
            {
                var response = await _boardApi.AddListToBoardAsync(req, boardId);
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

        public async Task<Board> GetBoardById(string boardId, string? organizationId)
        {
            try
            {
                if (organizationId != null)
                {
                    var cacheKey = $"Organization_{organizationId}_Boards";
                    var isCached = _cache.TryGetValue(cacheKey, out List<Board> cachedBoards);
                    if (isCached)
                    {
                        Board? cachedBoard =
                            cachedBoards.FirstOrDefault(board => board.Id == boardId);
                        if (cachedBoard != null)
                        {
                            return cachedBoard;
                        }
                    };
                }
                
                var response = await _boardApi.GetBoardByIdAsync(boardId);
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

        public async Task<List<List>> GetBoardLists(string boardId)
        {
            try
            {
                var cacheKey = $"Board_{boardId}_Lists";
                var isCached = _cache.TryGetValue(cacheKey, out List<List> boardLists);
                if (isCached) return boardLists;
                
                var response = await _boardApi.GetBoardListsAsync(boardId);
                var mappedLists = response.MapToLists();
                foreach (var list in mappedLists)
                {
                    _cache.UpdateListCache(list);
                }
                return mappedLists;
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

        public async Task<Board> UpdateBoard(string boardId, string? organizationId, UpdateBoardRequest req)
        {
            try
            {
                var response = await _boardApi.UpdateBoardAsync(boardId, req);
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

        public async Task<ResponseOk> DeleteBoard(string boardId, string? organizationId)
        {
            try
            {
                var cacheKey = $"Organizations_{organizationId}_Boards";
                await _boardApi.DeleteBoardAsync(boardId);
                bool isCached = _cache.TryGetValue(cacheKey, out List<Board> boards);
                if (isCached)
                {
                    var boardToDel = boards.FirstOrDefault(board => board.Id == boardId);
                    if (boardToDel != null) boards.Remove(boardToDel);
                    _cache.Remove(cacheKey);
                    _cache.Set(cacheKey, boards);
                }
                return new ResponseOk { HttpCode = 204, Id = boardId };
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

        public async Task<List<BoardMemberResponse>> GetBoardMembers(string boardId)
        {
            try
            {
                // No caching mentioned for members, but consider implementing if data is relatively static
                return await _boardApi.GetBoardMembersAsync(boardId);
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

        public async Task<MailInviteResponse> InviteToBoard(EmailInviteToBoardRequest req, string boardId)
        {
            try
            {
                // No caching mentioned for invites, but consider if applicable
                return await _boardApi.InviteViaEmailAsync(req, boardId);
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

        public async Task<ResponseOk> DeleteBoardMember(string boardId, string memberId)
        {
            try
            {
                await _boardApi.DeleteMemberAsync(boardId, memberId);
                // No caching operation specified, but consider if board members are cached
                return new ResponseOk { HttpCode = 204, Id = memberId };
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

        public async Task<Member> GetMemberById(string memberId)
        {
            try
            {
                var cacheKey = $"Member_{memberId}";
                var isCached = _cache.TryGetValue(cacheKey, out Member member);
                if (isCached) return member;
                var response = await _boardApi.GetMemberNameASync(memberId);
                var mappedMember = response.MapToMember();
                _cache.Set(cacheKey, mappedMember, TimeSpan.FromMinutes(10));
                return mappedMember;
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
