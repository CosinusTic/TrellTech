using System.Text.Json.Serialization;
using AndroidX.Core.OS;

namespace TrelloApp.Contracts.Response;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class LabelNames
{
    [JsonPropertyName("green")]
    public string? Green { get; set; }

    [JsonPropertyName("yellow")]
    public string? Yellow { get; set; }

    [JsonPropertyName("orange")]
    public string? Orange { get; set; }

    [JsonPropertyName("red")]
    public string? Red { get; set; }

    [JsonPropertyName("purple")]
    public string? Purple { get; set; }

    [JsonPropertyName("blue")]
    public string? Blue { get; set; }

    [JsonPropertyName("sky")]
    public string? Sky { get; set; }

    [JsonPropertyName("lime")]
    public string? Lime { get; set; }

    [JsonPropertyName("pink")]
    public string? Pink { get; set; }

    [JsonPropertyName("black")]
    public string? Black { get; set; }

    [JsonPropertyName("green_dark")]
    public string? GreenDark { get; set; }

    [JsonPropertyName("yellow_dark")]
    public string? YellowDark { get; set; }

    [JsonPropertyName("orange_dark")]
    public string? OrangeDark { get; set; }

    [JsonPropertyName("red_dark")]
    public string? RedDark { get; set; }

    [JsonPropertyName("purple_dark")]
    public string? PurpleDark { get; set; }

    [JsonPropertyName("blue_dark")]
    public string? BlueDark { get; set; }

    [JsonPropertyName("sky_dark")]
    public string? SkyDark { get; set; }

    [JsonPropertyName("lime_dark")]
    public string? LimeDark { get; set; }

    [JsonPropertyName("pink_dark")]
    public string? PinkDark { get; set; }

    [JsonPropertyName("black_dark")]
    public string? BlackDark { get; set; }

    [JsonPropertyName("green_light")]
    public string? GreenLight { get; set; }

    [JsonPropertyName("yellow_light")]
    public string? YellowLight { get; set; }

    [JsonPropertyName("orange_light")]
    public string? OrangeLight { get; set; }

    [JsonPropertyName("red_light")]
    public string? RedLight { get; set; }

    [JsonPropertyName("purple_light")]
    public string? PurpleLight { get; set; }

    [JsonPropertyName("blue_light")]
    public string? BlueLight { get; set; }

    [JsonPropertyName("sky_light")]
    public string? SkyLight { get; set; }

    [JsonPropertyName("lime_light")]
    public string? LimeLight { get; set; }

    [JsonPropertyName("pink_light")]
    public string? PinkLight { get; set; }

    [JsonPropertyName("black_light")]
    public string? BlackLight { get; set; }
}

public class Prefs
{
    public Prefs(object backgroundImageScaled)
    {
        this.BackgroundImageScaled = backgroundImageScaled;
    }

    [JsonPropertyName("permissionLevel")]
    public string? PermissionLevel { get; set; }

    [JsonPropertyName("hideVotes")]
    public bool? HideVotes { get; set; }

    [JsonPropertyName("voting")]
    public string? Voting { get; set; }

    [JsonPropertyName("comments")]
    public string? Comments { get; set; }

    [JsonPropertyName("invitations")]
    public string? Invitations { get; set; }

    [JsonPropertyName("selfJoin")]
    public bool? SelfJoin { get; set; }

    [JsonPropertyName("cardCovers")]
    public bool? CardCovers { get; set; }

    [JsonPropertyName("cardCounts")]
    public bool? CardCounts { get; set; }

    [JsonPropertyName("isTemplate")]
    public bool? IsTemplate { get; set; }

    [JsonPropertyName("cardAging")]
    public string? CardAging { get; set; }

    [JsonPropertyName("calendarFeedEnabled")]
    public bool? CalendarFeedEnabled { get; set; }

    [JsonPropertyName("hiddenPluginBoardButtons")]
    public List<object>? HiddenPluginBoardButtons { get; set; }

    [JsonPropertyName("switcherViews")]
    public List<SwitcherView>? SwitcherViews { get; set; }

    [JsonPropertyName("background")]
    public string? Background { get; set; }

    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    [JsonPropertyName("backgroundImage")]
    public object? BackgroundImage { get; set; }

    [JsonPropertyName("backgroundTile")]
    public bool? BackgroundTile { get; set; }

    [JsonPropertyName("backgroundBrightness")]
    public string? BackgroundBrightness { get; set; }

    [JsonPropertyName("backgroundImageScaled")]
    public object BackgroundImageScaled { get; set; }

    [JsonPropertyName("backgroundBottomColor")]
    public string? BackgroundBottomColor { get; set; }

    [JsonPropertyName("backgroundTopColor")]
    public string? BackgroundTopColor { get; set; }

    [JsonPropertyName("canBePublic")]
    public bool? CanBePublic { get; set; }

    [JsonPropertyName("canBeEnterprise")]
    public bool? CanBeEnterprise { get; set; }

    [JsonPropertyName("canBeOrg")]
    public bool? CanBeOrg { get; set; }

    [JsonPropertyName("canBePrivate")]
    public bool? CanBePrivate { get; set; }

    [JsonPropertyName("canInvite")]
    public bool? CanInvite { get; set; }
}

public class MailInviteResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("descData")]
    public object? DescData { get; set; }

    [JsonPropertyName("closed")]
    public bool? Closed { get; set; }

    [JsonPropertyName("idOrganization")]
    public string? IdOrganization { get; set; }

    [JsonPropertyName("idEnterprise")]
    public object? IdEnterprise { get; set; }

    [JsonPropertyName("pinned")]
    public bool? Pinned { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("shortUrl")]
    public string? ShortUrl { get; set; }

    [JsonPropertyName("prefs")]
    public Prefs? Prefs { get; set; }

    [JsonPropertyName("labelNames")]
    public LabelNames? LabelNames { get; set; }
}

public class SwitcherView
{
    [JsonPropertyName("viewType")]
    public string? ViewType { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public class Limits
{
    // Do not know limit contents yet
}
public class AddListToBoardResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("closed")]
    public bool? Closed { get; set; }
    
    [JsonPropertyName("color")]
    public string? Color { get; set; }
    
    [JsonPropertyName("idBoard")]
    public string? IdBoard { get; set; }
    
    [JsonPropertyName("pos")]
    public int? Pos { get; set; }
    
    [JsonPropertyName("limits")]
    public Limits? Limits { get; set; }
}
    public class GetBoardByIdResponse
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("desc")]
        public string? Desc { get; set; }

        [JsonPropertyName("descData")]
        public object? DescData { get; set; }

        [JsonPropertyName("closed")]
        public bool? Closed { get; set; }

        [JsonPropertyName("idOrganization")]
        public string? IdOrganization { get; set; }

        [JsonPropertyName("idEnterprise")]
        public object? IdEnterprise { get; set; }

        [JsonPropertyName("pinned")]
        public bool? Pinned { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("shortUrl")]
        public string? ShortUrl { get; set; }

        [JsonPropertyName("prefs")]
        public Prefs? Prefs { get; set; }

        [JsonPropertyName("labelNames")]
        public LabelNames? LabelNames { get; set; }
    }

    public class ListResponse
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("closed")]
        public bool? Closed { get; set; }
        
        [JsonPropertyName("color")]
        public string? Color { get; set; }
        
        [JsonPropertyName("idBoard")]
        public string? IdBoard { get; set; }
        
        [JsonPropertyName("pos")]
        public int? Pos { get; set; }
        
        [JsonPropertyName("subscribed")]
        public bool? Subscribed { get; set; }
        
        [JsonPropertyName("softLimit")]
        public string? SoftLimit { get; set; }
    }


    public class UpdateBoardResponse
    {
        [JsonPropertyName("id")] 
        public string? Id { get; set; }

        [JsonPropertyName("name")] 
        public string? Name { get; set; }

        [JsonPropertyName("desc")] 
        public string? Desc { get; set; }

        [JsonPropertyName("descData")] 
        public object? DescData { get; set; }

        [JsonPropertyName("closedpos")]
        public bool? Closed { get; set; }

        [JsonPropertyName("idOrganization")]
        public string? IdOrganization { get; set; }

        [JsonPropertyName("idEnterprise")]
        public object? IdEnterprise { get; set; }

        [JsonPropertyName("pinned")]
        public bool? Pinned { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("shortUrl")]
        public string? ShortUrl { get; set; }

        [JsonPropertyName("prefs")]
        public Prefs? Prefs { get; set; }

        [JsonPropertyName("labelNames")]
        public LabelNames? LabelNames { get; set; }
    }

    public class BoardMemberResponse
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("idMember")]
        public string? IdMember { get; set; }
        
        [JsonPropertyName("memberType")]
        public string? MemberType { get; set; }
        
        [JsonPropertyName("unconfirmed")]
        public bool? Unconfirmed { get; set; }
        
        [JsonPropertyName("deactivated")]
        public bool? Deactivated { get; set; }
    }










