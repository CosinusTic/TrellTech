using TrelloApp.Contracts.Response;
using TrelloApp.Contracts.Models;

namespace TrelloApp.Contracts.Mapping;

public static class CardMapping
{
    public static Card MapToCard(this CreateCardResponse response)
    {
        return new Card()
        {
            Name = response.name,
            Id = response.id,
            Desc = response.desc,
            IdList = response.idList,
            Closed = response.closed
        };
    }
    public static Card MapToCard(this GetCardByIdResponse response)
    {
        return new Card()
        {
            Name = response.name,
            Id = response.id,
            Desc = response.desc,
            IdList = response.idList,
            Closed = response.closed,
            IdMembers = response.idMembers
        };
    }
    public static Card MapToCard(this UpdateCardResponse response)
    {
        return new Card()
        {
            Name = response.name,
            Id = response.id,
            Desc = response.desc,
            IdList = response.idList,
            Closed = response.closed
        };
    }
    public static List<Card> MapToCards(this List<ListCardResponse> response)
    {
        List<Card> mappedData = new();
        foreach (var cardResponse in response)
        {
            mappedData.Add(new Card()
            {
                Name = cardResponse.name,
                Id = cardResponse.id,
                Desc = cardResponse.desc,
                IdList = cardResponse.idList,
                Closed = cardResponse.closed,
                IdMembers = cardResponse.idMembers
                
            });
        }

        return mappedData;
    }
}