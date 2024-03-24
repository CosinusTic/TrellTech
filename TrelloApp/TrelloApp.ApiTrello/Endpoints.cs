namespace TrelloApp.ApiTrello;

public static class TrelloEndpoints
{
    private const string BaseUrl = "/1";

    public static class Organizations
    {
        public const string GetByUser = $"{BaseUrl}/members/me/organizations";
        public const string GetById = $"{BaseUrl}/organizations/{{organizationId}}";
        public const string GetMembers = $"{BaseUrl}/organizations/{{organizationId}}/members";
        public const string GetBoards = $"{BaseUrl}/organizations/{{organizationId}}/boards";
        public const string AddBoard = $"{BaseUrl}/boards";
        public const string Add = $"{BaseUrl}/organizations";
        public const string Update = $"{BaseUrl}/organizations/{{organizationId}}";
        public const string Delete = $"{BaseUrl}/organizations/{{organizationId}}";
    }

    public static class Boards
    {
        public static class BoardMembers
        {
            public const string GetAll = $"{BaseUrl}/boards/{{boardId}}/memberships";
            public const string InviteByMail = $"{BaseUrl}/boards/{{boardId}}/members"; // put request
            public const string Remove = $"{BaseUrl}/boards/{{boardId}}/members/{{memberId}}";
        }

        public const string GetById = $"{BaseUrl}/boards/{{boardId}}";
        public const string GetLists = $"{BaseUrl}/boards/{{boardId}}/lists";
        public const string AddList = $"{BaseUrl}/boards/{{boardId}}/lists";
        public const string Update = $"{BaseUrl}/boards/{{boardId}}";
        public const string Delete = $"{BaseUrl}/boards/{{boardId}}";
    }

    public static class Lists
    {
        public const string GetById = $"{BaseUrl}/lists/{{listId}}";
        public const string GetCards = $"{BaseUrl}/lists/{{listId}}/cards";
        public const string Create = $"{BaseUrl}/lists";
        public const string Update = $"{BaseUrl}/lists/{{listId}}";
        public const string ToggleArchive = $"{BaseUrl}/lists/{{listId}}/closed";
    }

    public static class Cards
    {
        public const string GetById = $"{BaseUrl}/cards/{{cardId}}";
        public const string Create = $"{BaseUrl}/cards";
        public const string Update = $"{BaseUrl}/cards/{{cardId}}";
        public const string Delete = $"{BaseUrl}/cards/{{cardId}}";
    }

    public static class Members
    {
        public const string GetById = $"{BaseUrl}/members/{{memberId}}";
    }
    
}