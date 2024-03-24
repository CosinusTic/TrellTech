using System.Text.Json.Serialization;

namespace TrelloApp.Contracts.Response;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

    public class NonPublic
    {
    }

    public class GetMemberByIdResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("aaId")]
        public string AaId { get; set; }

        [JsonPropertyName("activityBlocked")]
        public bool ActivityBlocked { get; set; }

        [JsonPropertyName("avatarHash")]
        public string AvatarHash { get; set; }

        [JsonPropertyName("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonPropertyName("bio")]
        public string Bio { get; set; }

        [JsonPropertyName("bioData")]
        public object BioData { get; set; }

        [JsonPropertyName("confirmed")]
        public bool Confirmed { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("idEnterprise")]
        public object IdEnterprise { get; set; }

        [JsonPropertyName("idEnterprisesDeactivated")]
        public object IdEnterprisesDeactivated { get; set; }

        [JsonPropertyName("idMemberReferrer")]
        public object IdMemberReferrer { get; set; }

        [JsonPropertyName("idPremOrgsAdmin")]
        public List<object> IdPremOrgsAdmin { get; set; }

        [JsonPropertyName("initials")]
        public string Initials { get; set; }

        [JsonPropertyName("memberType")]
        public string MemberType { get; set; }

        [JsonPropertyName("nonPublic")]
        public NonPublic NonPublic { get; set; }

        [JsonPropertyName("nonPublicAvailable")]
        public bool NonPublicAvailable { get; set; }

        [JsonPropertyName("products")]
        public List<object> Products { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("aaBlockSyncUntil")]
        public object AaBlockSyncUntil { get; set; }

        [JsonPropertyName("aaEmail")]
        public object AaEmail { get; set; }

        [JsonPropertyName("aaEnrolledDate")]
        public object AaEnrolledDate { get; set; }

        [JsonPropertyName("avatarSource")]
        public object AvatarSource { get; set; }

        [JsonPropertyName("credentialsRemovedCount")]
        public object CredentialsRemovedCount { get; set; }

        [JsonPropertyName("dateLastImpression")]
        public DateTime DateLastImpression { get; set; }

        [JsonPropertyName("dateLastActive")]
        public DateTime DateLastActive { get; set; }

        [JsonPropertyName("domainClaimed")]
        public object DomainClaimed { get; set; }

        [JsonPropertyName("email")]
        public object Email { get; set; }

        [JsonPropertyName("gravatarHash")]
        public object GravatarHash { get; set; }

        [JsonPropertyName("idBoards")]
        public List<string> IdBoards { get; set; }

        [JsonPropertyName("idOrganizations")]
        public List<object> IdOrganizations { get; set; }

        [JsonPropertyName("idEnterprisesAdmin")]
        public List<object> IdEnterprisesAdmin { get; set; }

        [JsonPropertyName("limits")]
        public Models.Limits Limits { get; set; }

        [JsonPropertyName("loginTypes")]
        public object LoginTypes { get; set; }

        [JsonPropertyName("marketingOptIn")]
        public object MarketingOptIn { get; set; }

        [JsonPropertyName("messagesDismissed")]
        public object MessagesDismissed { get; set; }

        [JsonPropertyName("nodeId")]
        public string NodeId { get; set; }

        [JsonPropertyName("oneTimeMessagesDismissed")]
        public object OneTimeMessagesDismissed { get; set; }

        [JsonPropertyName("sessionType")]
        public object SessionType { get; set; }

        [JsonPropertyName("prefs")]
        public object Prefs { get; set; }

        [JsonPropertyName("trophies")]
        public List<object> Trophies { get; set; }

        [JsonPropertyName("uploadedAvatarHash")]
        public object UploadedAvatarHash { get; set; }

        [JsonPropertyName("uploadedAvatarUrl")]
        public object UploadedAvatarUrl { get; set; }

        [JsonPropertyName("premiumFeatures")]
        public List<object> PremiumFeatures { get; set; }

        [JsonPropertyName("isAaMastered")]
        public bool IsAaMastered { get; set; }

        [JsonPropertyName("ixUpdate")]
        public string IxUpdate { get; set; }
    }

    public class TotalPerMember
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("disableAt")]
        public int DisableAt { get; set; }

        [JsonPropertyName("warnAt")]
        public int WarnAt { get; set; }
    }

