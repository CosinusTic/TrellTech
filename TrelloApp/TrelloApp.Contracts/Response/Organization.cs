using System.Text.Json.Serialization;

namespace TrelloApp.Contracts.Response;

public class CreateOrganizationResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("descData")]
    public DescData? DescData { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("website")]
    public object? Website { get; set; }

    [JsonPropertyName("teamType")]
    public object? TeamType { get; set; }

    [JsonPropertyName("logoHash")]
    public object? LogoHash { get; set; }

    [JsonPropertyName("logoUrl")]
    public object? LogoUrl { get; set; }

    [JsonPropertyName("offering")]
    public string? Offering { get; set; }

    [JsonPropertyName("products")]
    public List<object?>? Products { get; set; }

    [JsonPropertyName("powerUps")]
    public List<object?>? PowerUps { get; set; }

    [JsonPropertyName("idMemberCreator")]
    public string? IdMemberCreator { get; set; }

    [JsonPropertyName("limits")]
    public Limits? Limits { get; set; }
}

public class GetOrganizationByIdResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("descData")]
    public DescData? DescData { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("website")]
    public object? Website { get; set; }

    [JsonPropertyName("teamType")]
    public object? TeamType { get; set; }

    [JsonPropertyName("logoHash")]
    public object? LogoHash { get; set; }

    [JsonPropertyName("logoUrl")]
    public object? LogoUrl { get; set; }

    [JsonPropertyName("offering")]
    public string? Offering { get; set; }

    [JsonPropertyName("products")]
    public List<object?>? Products { get; set; }

    [JsonPropertyName("powerUps")]
    public List<object?>? PowerUps { get; set; }
}

public class BoardDeleteRestrict
{
    [JsonPropertyName("private")]
    public string? Private { get; set; }

    [JsonPropertyName("org")]
    public string? Org { get; set; }

    [JsonPropertyName("enterprise")]
    public string? Enterprise { get; set; }

    [JsonPropertyName("public")]
    public string? Public { get; set; }
}

public class BoardVisibilityRestrict
{
    [JsonPropertyName("private")]
    public string? Private { get; set; }

    [JsonPropertyName("org")]
    public string? Org { get; set; }

    [JsonPropertyName("enterprise")]
    public string? Enterprise { get; set; }

    [JsonPropertyName("public")]
    public string? Public { get; set; }
}

public class EnterpriseJoinRequest
{
}

public class FreeBoardsPerOrg
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }
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

public class Orgs
{
    [JsonPropertyName("totalMembersPerOrg")]
    public TotalMembersPerOrg? TotalMembersPerOrg { get; set; }

    [JsonPropertyName("freeBoardsPerOrg")]
    public FreeBoardsPerOrg? FreeBoardsPerOrg { get; set; }

    [JsonPropertyName("usersPerFreeOrg")]
    public UsersPerFreeOrg? UsersPerFreeOrg { get; set; }
}


public class UserOrganization
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("creationMethod")]
    public string? CreationMethod { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("credits")]
    public List<object?>? Credits { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("descData")]
    public DescData? DescData { get; set; }

    [JsonPropertyName("domainName")]
    public object? DomainName { get; set; }

    [JsonPropertyName("idBoards")]
    public List<string?>? IdBoards { get; set; }

    [JsonPropertyName("idEnterprise")]
    public object? IdEnterprise { get; set; }

    [JsonPropertyName("idMemberCreator")]
    public string? IdMemberCreator { get; set; }

    [JsonPropertyName("invited")]
    public bool? Invited { get; set; }

    [JsonPropertyName("invitations")]
    public List<object?>? Invitations { get; set; }

    [JsonPropertyName("limits")]
    public Limits? Limits { get; set; }

    [JsonPropertyName("membersCount")]
    public int? MembersCount { get; set; }

    [JsonPropertyName("nodeId")]
    public string? NodeId { get; set; }

    [JsonPropertyName("prefs")]
    public Prefs? Prefs { get; set; }

    [JsonPropertyName("powerUps")]
    public List<object?>? PowerUps { get; set; }

    [JsonPropertyName("offering")]
    public string? Offering { get; set; }

    [JsonPropertyName("products")]
    public List<object?>? Products { get; set; }

    [JsonPropertyName("billableMemberCount")]
    public int? BillableMemberCount { get; set; }

    [JsonPropertyName("billableCollaboratorCount")]
    public int? BillableCollaboratorCount { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("website")]
    public object? Website { get; set; }

    [JsonPropertyName("logoHash")]
    public object? LogoHash { get; set; }

    [JsonPropertyName("logoUrl")]
    public object? LogoUrl { get; set; }

    [JsonPropertyName("premiumFeatures")]
    public List<string?>? PremiumFeatures { get; set; }

    [JsonPropertyName("promotions")]
    public List<object?>? Promotions { get; set; }

    [JsonPropertyName("enterpriseJoinRequest")]
    public EnterpriseJoinRequest? EnterpriseJoinRequest { get; set; }

    [JsonPropertyName("standardVariation")]
    public object? StandardVariation { get; set; }

    [JsonPropertyName("availableLicenseCount")]
    public object? AvailableLicenseCount { get; set; }

    [JsonPropertyName("maximumLicenseCount")]
    public object? MaximumLicenseCount { get; set; }

    [JsonPropertyName("ixUpdate")]
    public string? IxUpdate { get; set; }

    [JsonPropertyName("teamType")]
    public object? TeamType { get; set; }

    [JsonPropertyName("dateLastActivity")]
    public DateTime? DateLastActivity { get; set; }

    [JsonPropertyName("jwmLink")]
    public object? JwmLink { get; set; }

    [JsonPropertyName("activeMembershipCount")]
    public object? ActiveMembershipCount { get; set; }

    [JsonPropertyName("idActiveAdmins")]
    public object? IdActiveAdmins { get; set; }

    [JsonPropertyName("memberships")]
    public List<Membership>? Memberships { get; set; }
}

public class TotalMembersPerOrg
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }
}

public class UsersPerFreeOrg
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("disableAt")]
    public int? DisableAt { get; set; }

    [JsonPropertyName("warnAt")]
    public int? WarnAt { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

public class OrganizationMember
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }
    
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

public class Attachments
{
    [JsonPropertyName("perBoard")]
    public PerBoard? PerBoard { get; set; }

    [JsonPropertyName("perCard")]
    public PerCard? PerCard { get; set; }
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

public class Labels
{
    [JsonPropertyName("perBoard")]
    public PerBoard? PerBoard { get; set; }
}

public class Lists
{
    [JsonPropertyName("openPerBoard")]
    public OpenPerBoard? OpenPerBoard { get; set; }

    [JsonPropertyName("totalPerBoard")]
    public TotalPerBoard? TotalPerBoard { get; set; }
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



public class Reactions
{
    [JsonPropertyName("perAction")]
    public PerAction? PerAction { get; set; }

    [JsonPropertyName("uniquePerAction")]
    public UniquePerAction? UniquePerAction { get; set; }
}

public class OrganizationBoard
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nodeId")]
    public string? NodeId { get; set; }

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
    public List<object?>? PowerUps { get; set; }

    [JsonPropertyName("dateLastActivity")]
    public object? DateLastActivity { get; set; }

    [JsonPropertyName("dateLastView")]
    public DateTime? DateLastView { get; set; }

    [JsonPropertyName("shortUrl")]
    public string? ShortUrl { get; set; }

    [JsonPropertyName("idTags")]
    public List<object?>? IdTags { get; set; }

    [JsonPropertyName("datePluginDisable")]
    public object? DatePluginDisable { get; set; }

    [JsonPropertyName("creationMethod")]
    public string? CreationMethod { get; set; }

    [JsonPropertyName("ixUpdate")]
    public string? IxUpdate { get; set; }

    [JsonPropertyName("templateGallery")]
    public object? TemplateGallery { get; set; }

    [JsonPropertyName("enterpriseOwned")]
    public bool? EnterpriseOwned { get; set; }

    [JsonPropertyName("idBoardSource")]
    public object? IdBoardSource { get; set; }

    [JsonPropertyName("premiumFeatures")]
    public List<string?>? PremiumFeatures { get; set; }

    [JsonPropertyName("idMemberCreator")]
    public string? IdMemberCreator { get; set; }

    [JsonPropertyName("memberships")]
    public List<Membership>? Memberships { get; set; }
}

public class Stickers
{
    [JsonPropertyName("perCard")]
    public PerCard? PerCard { get; set; }
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

public class AddBoardToOrganizationResponse
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

    [JsonPropertyName("limits")]
    public Limits? Limits { get; set; }
}


public class UpdateOrganizationResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("descData")]
    public DescData? DescData { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("website")]
    public object? Website { get; set; }

    [JsonPropertyName("teamType")]
    public object? TeamType { get; set; }

    [JsonPropertyName("logoHash")]
    public object? LogoHash { get; set; }

    [JsonPropertyName("logoUrl")]
    public object? LogoUrl { get; set; }

    [JsonPropertyName("offering")]
    public string? Offering { get; set; }

    [JsonPropertyName("products")]
    public List<object?>? Products { get; set; }

    [JsonPropertyName("powerUps")]
    public List<object?>? PowerUps { get; set; }
}









