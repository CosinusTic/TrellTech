using TrelloApp.Contracts.Models;
using TrelloApp.Contracts.Response;

namespace TrelloApp.Contracts.Mapping;

public static class MemberMapping
{
    public static Member MapToMember(this GetMemberByIdResponse response)
    {
        return new Member()
        {
            FullName = response.FullName,
            Id = response.Id,
            Bio = response.Bio,
            AvatarUrl = $"https://www.gravatar.com/avatar/{response.AvatarHash}?s=80&d=identicon"
        };
    }
}