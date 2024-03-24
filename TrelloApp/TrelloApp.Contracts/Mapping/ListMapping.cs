using TrelloApp.Contracts.Models;
using TrelloApp.Contracts.Response;

namespace TrelloApp.Contracts.Mapping;

public static class ListMapping
{
    public static List MapToList(this AddListToBoardResponse response)
    {
        return new List()
        {
            Name = response.Name,
            Closed = response.Closed,
            Id = response.Id,
            IdBoard = response.IdBoard,
            Pos = response.Pos
        };
    }
    public static List MapToList(this CreateListResponse response)
    {
        return new List()
        {
            Name = response.name,
            Closed = response.closed,
            Id = response.id,
            IdBoard = response.idBoard,
            Pos = response.pos
        };
    }    
    public static List MapToList(this GetListByIdResponse response)
    {
        return new List()
        {
            Name = response.name,
            Closed = response.closed,
            Id = response.id,
            IdBoard = response.idBoard,
            Pos = response.pos
        };
    }
    public static List MapToList(this UpdateListResponse response)
    {
        return new List()
        {
            Name = response.name,
            Closed = response.closed,
            Id = response.id,
            IdBoard = response.idBoard,
            Pos = response.pos
        };
    }
    public static List MapToList(this ToggleArchiveListResponse response)
    {
        return new List()
        {
            Name = response.Name,
            Closed = response.Closed,
            Id = response.Id,
            IdBoard = response.idBoard,
            Pos = response.Pos
        };
    }
    public static List<List> MapToLists(this List<ListResponse> response)
    {
        List<List> mappedData = new();
        
        foreach (var listResponse in response)
        {
            mappedData.Add(new List()
            {
                Name = listResponse.Name,
                Closed = listResponse.Closed,
                Id = listResponse.Id,
                IdBoard = listResponse.IdBoard,
                Pos = listResponse.Pos
            });
        }

        return mappedData;
    }
}