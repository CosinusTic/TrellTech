using System.Text.Json.Serialization;

namespace TrelloApp.Contracts.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class AttachmentsByType
{
    [JsonPropertyName("trello")]
    public Trello? Trello { get; set; }
}

public class Badges
{
    [JsonPropertyName("attachmentsByType")]
    public AttachmentsByType? AttachmentsByType { get; set; }

    [JsonPropertyName("location")]
    public bool? Location { get; set; }

    [JsonPropertyName("votes")]
    public int? Votes { get; set; }

    [JsonPropertyName("viewingMemberVoted")]
    public bool? ViewingMemberVoted { get; set; }

    [JsonPropertyName("subscribed")]
    public bool? Subscribed { get; set; }

    [JsonPropertyName("fogbugz")]
    public string? Fogbugz { get; set; }

    [JsonPropertyName("checkItems")]
    public int? CheckItems { get; set; }

    [JsonPropertyName("checkItemsChecked")]
    public int? CheckItemsChecked { get; set; }

    [JsonPropertyName("checkItemsEarliestDue")]
    public object? CheckItemsEarliestDue { get; set; }

    [JsonPropertyName("comments")]
    public int? Comments { get; set; }

    [JsonPropertyName("attachments")]
    public int? Attachments { get; set; }

    [JsonPropertyName("description")]
    public bool? Description { get; set; }

    [JsonPropertyName("due")]
    public object? Due { get; set; }

    [JsonPropertyName("dueComplete")]
    public bool? DueComplete { get; set; }

    [JsonPropertyName("start")]
    public object? Start { get; set; }
}

public class Cover
{
    [JsonPropertyName("idAttachment")]
    public object? IdAttachment { get; set; }

    [JsonPropertyName("color")]
    public object? Color { get; set; }

    [JsonPropertyName("idUploadedBackground")]
    public object? IdUploadedBackground { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("brightness")]
    public string? Brightness { get; set; }

    [JsonPropertyName("idPlugin")]
    public object? IdPlugin { get; set; }
}

public class Card
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("badges")]
    public Badges? Badges { get; set; }

    [JsonPropertyName("checkItemStates")]
    public List<object>? CheckItemStates { get; set; }

    [JsonPropertyName("closed")]
    public bool? Closed { get; set; }

    [JsonPropertyName("dueComplete")]
    public bool? DueComplete { get; set; }

    [JsonPropertyName("dateLastActivity")]
    public DateTime? DateLastActivity { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("descData")]
    public DescData? DescData { get; set; }

    [JsonPropertyName("due")]
    public object? Due { get; set; }

    [JsonPropertyName("dueReminder")]
    public object? DueReminder { get; set; }

    [JsonPropertyName("email")]
    public object? Email { get; set; }

    [JsonPropertyName("idBoard")]
    public string? IdBoard { get; set; }

    [JsonPropertyName("idChecklists")]
    public List<object>? IdChecklists { get; set; }

    [JsonPropertyName("idList")]
    public string? IdList { get; set; }

    [JsonPropertyName("idMembers")]
    public List<string>? IdMembers { get; set; }

    [JsonPropertyName("idMembersVoted")]
    public List<object>? IdMembersVoted { get; set; }

    [JsonPropertyName("idShort")]
    public int? IdShort { get; set; }

    [JsonPropertyName("idAttachmentCover")]
    public object? IdAttachmentCover { get; set; }

    [JsonPropertyName("labels")]
    public List<object>? Labels { get; set; }

    [JsonPropertyName("idLabels")]
    public List<object>? IdLabels { get; set; }

    [JsonPropertyName("manualCoverAttachment")]
    public bool? ManualCoverAttachment { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pos")]
    public int? Pos { get; set; }

    [JsonPropertyName("shortLink")]
    public string? ShortLink { get; set; }

    [JsonPropertyName("shortUrl")]
    public string? ShortUrl { get; set; }

    [JsonPropertyName("start")]
    public object? Start { get; set; }

    [JsonPropertyName("subscribed")]
    public bool? Subscribed { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("cover")]
    public Cover? Cover { get; set; }

    [JsonPropertyName("isTemplate")]
    public bool? IsTemplate { get; set; }

    [JsonPropertyName("cardRole")]
    public object? CardRole { get; set; }
}

public class Trello
{
    [JsonPropertyName("board")]
    public int? Board { get; set; }

    [JsonPropertyName("card")]
    public int? Card { get; set; }
}

