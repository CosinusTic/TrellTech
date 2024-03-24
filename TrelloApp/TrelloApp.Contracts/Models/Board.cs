using System.Text.Json.Serialization;

namespace TrelloApp.Contracts.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);

public class Board
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nodeId")]
    public string? NodeId { get; set; }//

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("descData")]
    public object? DescData { get; set; }

    [JsonPropertyName("closed")]
    public bool? Closed { get; set; }

    [JsonPropertyName("dateClosed")]
    public object? DateClosed { get; set; }

    [JsonPropertyName("idOrganization")]
    public string? IdOrganization { get; set; }

    [JsonPropertyName("idEnterprise")]
    public object? IdEnterprise { get; set; }

    [JsonPropertyName("limits")]
    public Limits? Limits { get; set; }

    [JsonPropertyName("pinned")]
    public bool? Pinned { get; set; }

    [JsonPropertyName("starred")]
    public bool? Starred { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("prefs")]
    public Prefs? Prefs { get; set; }

    [JsonPropertyName("shortLink")]
    public string? ShortLink { get; set; }

    [JsonPropertyName("subscribed")]
    public bool? Subscribed { get; set; }

    [JsonPropertyName("labelNames")]
    public LabelNames? LabelNames { get; set; }

    [JsonPropertyName("powerUps")]
    public List<object>? PowerUps { get; set; }

    [JsonPropertyName("dateLastActivity")]
    public object? DateLastActivity { get; set; }

    [JsonPropertyName("dateLastView")]
    public DateTime? DateLastView { get; set; }

    [JsonPropertyName("shortUrl")]
    public string? ShortUrl { get; set; }

    [JsonPropertyName("idTags")]
    public List<object>? IdTags { get; set; }

    [JsonPropertyName("datePluginDisable")]
    public object? DatePluginDisable { get; set; }

    [JsonPropertyName("creationMethod")]
    public object? CreationMethod { get; set; }

    [JsonPropertyName("ixUpdate")]
    public string? IxUpdate { get; set; }

    [JsonPropertyName("templateGallery")]
    public object? TemplateGallery { get; set; }

    [JsonPropertyName("enterpriseOwned")]
    public bool? EnterpriseOwned { get; set; }

    [JsonPropertyName("idBoardSource")]
    public object? IdBoardSource { get; set; }

    [JsonPropertyName("premiumFeatures")]
    public List<string>? PremiumFeatures { get; set; }

    [JsonPropertyName("idMemberCreator")]
    public string? IdMemberCreator { get; set; }

    [JsonPropertyName("memberships")]
    public List<Membership>? Memberships { get; set; }
}

public class Attachments
{
    [JsonPropertyName("perBoard")]
    public PerBoard? PerBoard { get; set; }

    [JsonPropertyName("perCard")]
    public PerCard? PerCard { get; set; }
}

public class BackgroundImageScaled
{
    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public class Boards
{
    [JsonPropertyName("totalMembersPerBoard")]
    public TotalMembersPerBoard? TotalMembersPerBoard { get; set; }

    [JsonPropertyName("totalAccessRequestsPerBoard")]
    public TotalAccessRequestsPerBoard? TotalAccessRequestsPerBoard { get; set; }
}

public class Cards
{
    [JsonPropertyName("openPerBoard")]
    public OpenPerBoard? OpenPerBoard { get; set; }

    [JsonPropertyName("openPerList")]
    public OpenPerList? OpenPerList { get; set; }

    [JsonPropertyName("totalPerBoard")]
    public TotalPerBoard? TotalPerBoard { get; set; }

    [JsonPropertyName("totalPerList")]
    public TotalPerList? TotalPerList { get; set; }
}

public class CheckItems
{
    [JsonPropertyName("perChecklist")]
    public PerChecklist? PerChecklist { get; set; }
}

public class Checklists
{
    [JsonPropertyName("perBoard")]
    public PerBoard? PerBoard { get; set; }

    [JsonPropertyName("perCard")]
    public PerCard? PerCard { get; set; }
}

public class CustomFieldOptions
{
    [JsonPropertyName("perField")]
    public PerField? PerField { get; set; }
}

public class CustomFields
{
    [JsonPropertyName("perBoard")]
    public PerBoard? PerBoard { get; set; }
}

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

public class Labels
{
    [JsonPropertyName("perBoard")]
    public PerBoard? PerBoard { get; set; }
}

public class Limits
{
    [JsonPropertyName("attachments")]
    public Attachments? Attachments { get; set; }

    [JsonPropertyName("boards")]
    public Boards? Boards { get; set; }

    [JsonPropertyName("cards")]
    public Cards? Cards { get; set; }

    [JsonPropertyName("checklists")]
    public Checklists? Checklists { get; set; }

    [JsonPropertyName("checkItems")]
    public CheckItems? CheckItems { get; set; }

    [JsonPropertyName("customFields")]
    public CustomFields? CustomFields { get; set; }

    [JsonPropertyName("customFieldOptions")]
    public CustomFieldOptions? CustomFieldOptions { get; set; }

    [JsonPropertyName("labels")]
    public Labels? Labels { get; set; }

    [JsonPropertyName("lists")]
    public Lists? Lists { get; set; }

    [JsonPropertyName("stickers")]
    public Stickers? Stickers { get; set; }

    [JsonPropertyName("reactions")]
    public Reactions? Reactions { get; set; }
}

public class Lists
{
    [JsonPropertyName("openPerBoard")]
    public OpenPerBoard? OpenPerBoard { get; set; }

    [JsonPropertyName("totalPerBoard")]
    public TotalPerBoard? TotalPerBoard { get; set; }
}

public class Membership
{
    [JsonPropertyName("idMember")]
    public string? IdMember { get; set; }

    [JsonPropertyName("memberType")]
    public string? MemberType { get; set; }

    [JsonPropertyName("unconfirmed")]
    public bool? Unconfirmed { get; set; }

    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public class OpenPerBoard
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class OpenPerList
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class PerAction
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class PerBoard
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class PerCard
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class PerChecklist
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class PerField
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class Prefs
{
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
    public object? BackgroundColor { get; set; }

    [JsonPropertyName("backgroundImage")]
    public string? BackgroundImage { get; set; }

    [JsonPropertyName("backgroundTile")]
    public bool? BackgroundTile { get; set; }

    [JsonPropertyName("backgroundBrightness")]
    public string? BackgroundBrightness { get; set; }

    [JsonPropertyName("backgroundImageScaled")]
    public List<BackgroundImageScaled>? BackgroundImageScaled { get; set; }

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

public class Reactions
{
    [JsonPropertyName("perAction")]
    public PerAction? PerAction { get; set; }

    [JsonPropertyName("uniquePerAction")]
    public UniquePerAction? UniquePerAction { get; set; }
}

public class Stickers
{
    [JsonPropertyName("perCard")]
    public PerCard? PerCard { get; set; }
}

public class SwitcherView
{
    [JsonPropertyName("viewType")]
    public string? ViewType { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public class TotalAccessRequestsPerBoard
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class TotalMembersPerBoard
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class TotalPerBoard
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class TotalPerList
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class UniquePerAction
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

