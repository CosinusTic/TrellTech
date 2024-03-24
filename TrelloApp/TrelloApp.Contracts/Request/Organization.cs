using System.Text.Json.Serialization;
using TrelloApp.Contracts.Models;

namespace TrelloApp.Contracts.Request;


public class CreateOrganizationRequest
{
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }
}


public class AddBoardToOrganizationRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    [JsonPropertyName("idOrganization")]
    public required string IdOrganization { get; set; }
    
    [JsonPropertyName("defaultLabels")]
    public bool? DefaultLabels { get; set; }
    
    [JsonPropertyName("defaultLists")]
    public bool? DefaultLists { get; set; }
    
    [JsonPropertyName("desc")]
    public string? Desc { get; set; }
    
    [JsonPropertyName("idBoardSource")]
    public string? IdBoardSource { get; set; }
    
    [JsonPropertyName("keepFromSource")]
    public bool? KeepFromSource { get; set; }
    
    [JsonPropertyName("powerUps")]
    public string? PowerUps { get; set; }
    
    [JsonPropertyName("pref_permissionLevel")]
    public string? PrefsPermissionLevel { get; set; }
    
    [JsonPropertyName("prefs_voting")]
    public string? PrefsVoting { get; set; }
    
    [JsonPropertyName("prefs_comments")]
    public string? Prefs { get; set; }
    
    [JsonPropertyName("prefs_invitations")]
    public string? PrefsInvitations { get; set; }
    
    [JsonPropertyName("prefs_selfJoin")]
    public bool? PrefsSelfJoin { get; set; }
    
    [JsonPropertyName("prefs_cardCovers")]
    public bool? PrefsCardCovers { get; set; }
    
    [JsonPropertyName("prefs_background")]
    public string? PrefsBackground { get; set; }
    
    [JsonPropertyName("prefs_cardAging")]
    public string? PrefsCardAging { get; set; }
}

public class UpdateOrganizationRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("desc")]
    public string? Desc { get; set; }
    
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
    
    [JsonPropertyName("website")]
    public string? Website { get; set; }
    
    [JsonPropertyName("prefs/associatedDomain")]
    public string? PrefsAssociatedDomain { get; set; }
    
    [JsonPropertyName("prefs/externalMembersDisabled")]
    public bool? PrefsExternalMembersDisabled { get; set; }

    [JsonPropertyName("prefs/googleAppsVersion")]
    public string? PrefsGoogleAppsVersion { get; set; }
    
    [JsonPropertyName("prefs/boardVisibilityRestrict/org")]
    public string? PrefsBoardVisibilityRestrictOrg { get; set; }
    
    [JsonPropertyName("prefs/boardVisibilityRestrict/private")]
    public string? PrefsBoardVisibilityRestrictPrivate { get; set; }
    
    [JsonPropertyName("prefs/boardVisibilityRestrict/public")]
    public string? PrefsBoardVisibilityRestrictPublic { get; set; }
    
    [JsonPropertyName("prefs/orgInviteRestrict")]
    public string? PrefsOrgInviteRestrict { get; set; }
    
    [JsonPropertyName("prefs/permissionLevel")]
    public string? PrefsPermissionLevel { get; set; }
}
