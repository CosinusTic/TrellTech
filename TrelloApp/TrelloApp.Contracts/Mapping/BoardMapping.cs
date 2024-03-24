using TrelloApp.Contracts.Models;
using TrelloApp.Contracts.Response;

namespace TrelloApp.Contracts.Mapping;

public static class BoardMapping
{
    public static Board MapToBoard(this AddBoardToOrganizationResponse response)
    {
        return new Board()
        {
            Name = response.Name,
            Id = response.Id,
            Desc = response.Desc,
            IdOrganization = response.IdOrganization
        };
    }
    public static Board MapToBoard(this GetBoardByIdResponse response)
    {
        return new Board()
        {
            Name = response.Name,
            Id = response.Id,
            Desc = response.Desc,
            IdOrganization = response.IdOrganization
        };
    }
    public static Board MapToBoard(this UpdateBoardResponse response)
    {
        return new Board()
        {
            Name = response.Name,
            Id = response.Id,
            Desc = response.Desc,
            IdOrganization = response.IdOrganization
        };
    }    
    
    public static List<Board> MapToBoards(this List<OrganizationBoard> response)
    {
        List<Board> mappedData = new();
        foreach (var organizationBoard in response)
        {
            mappedData.Add(new Board()
            {
                Name = organizationBoard.Name,
                Id = organizationBoard.Id,
                Desc = organizationBoard.Desc,
                IdOrganization = organizationBoard.IdOrganization
            });
        }

        return mappedData;
    }
}