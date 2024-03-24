using System.Text.Json.Serialization;

namespace TrelloApp.Contracts.Response;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class AttachmentsByType
    {
        [JsonPropertyName("trello")]
        public Trello trello { get; set; }
    }

    public class Badges
    {
        [JsonPropertyName("attachmentsByType")]
        public AttachmentsByType attachmentsByType { get; set; }

        [JsonPropertyName("location")]
        public bool? location { get; set; }

        [JsonPropertyName("votes")]
        public int? votes { get; set; }

        [JsonPropertyName("viewingMemberVoted")]
        public bool? viewingMemberVoted { get; set; }

        [JsonPropertyName("subscribed")]
        public bool? subscribed { get; set; }

        [JsonPropertyName("fogbugz")]
        public string fogbugz { get; set; }

        [JsonPropertyName("checkItems")]
        public int? checkItems { get; set; }

        [JsonPropertyName("checkItemsChecked")]
        public int? checkItemsChecked { get; set; }

        [JsonPropertyName("checkItemsEarliestDue")]
        public object checkItemsEarliestDue { get; set; }

        [JsonPropertyName("comments")]
        public int? comments { get; set; }

        [JsonPropertyName("attachments")]
        public int? attachments { get; set; }

        [JsonPropertyName("description")]
        public bool? description { get; set; }

        [JsonPropertyName("due")]
        public object due { get; set; }

        [JsonPropertyName("dueComplete")]
        public bool? dueComplete { get; set; }

        [JsonPropertyName("start")]
        public object start { get; set; }
    }

    public class Cover
    {
        [JsonPropertyName("idAttachment")]
        public object idAttachment { get; set; }

        [JsonPropertyName("color")]
        public object color { get; set; }

        [JsonPropertyName("idUploadedBackground")]
        public object idUploadedBackground { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("brightness")]
        public string brightness { get; set; }

        [JsonPropertyName("idPlugin")]
        public object idPlugin { get; set; }
    }

    public class DescData
    {
        [JsonPropertyName("emoji")]
        public Emoji emoji { get; set; }
    }

    public class Emoji
    {
    }


    public class CreateCardResponse
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("badges")]
        public Badges badges { get; set; }

        [JsonPropertyName("checkItemStates")]
        public List<object> checkItemStates { get; set; }

        [JsonPropertyName("closed")]
        public bool? closed { get; set; }

        [JsonPropertyName("dueComplete")]
        public bool? dueComplete { get; set; }

        [JsonPropertyName("dateLastActivity")]
        public DateTime? dateLastActivity { get; set; }

        [JsonPropertyName("desc")]
        public string desc { get; set; }

        [JsonPropertyName("descData")]
        public DescData descData { get; set; }

        [JsonPropertyName("due")]
        public object due { get; set; }

        [JsonPropertyName("dueReminder")]
        public object dueReminder { get; set; }

        [JsonPropertyName("email")]
        public object email { get; set; }

        [JsonPropertyName("idBoard")]
        public string idBoard { get; set; }

        [JsonPropertyName("idChecklists")]
        public List<object> idChecklists { get; set; }

        [JsonPropertyName("idList")]
        public string idList { get; set; }

        [JsonPropertyName("idMembers")]
        public List<object> idMembers { get; set; }

        [JsonPropertyName("idMembersVoted")]
        public List<object> idMembersVoted { get; set; }

        [JsonPropertyName("idShort")]
        public int? idShort { get; set; }

        [JsonPropertyName("idAttachmentCover")]
        public object idAttachmentCover { get; set; }

        [JsonPropertyName("labels")]
        public List<object> labels { get; set; }

        [JsonPropertyName("idLabels")]
        public List<object> idLabels { get; set; }

        [JsonPropertyName("manualCoverAttachment")]
        public bool? manualCoverAttachment { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("pos")]
        public int? pos { get; set; }

        [JsonPropertyName("shortLink")]
        public string shortLink { get; set; }

        [JsonPropertyName("shortUrl")]
        public string shortUrl { get; set; }

        [JsonPropertyName("start")]
        public object start { get; set; }

        [JsonPropertyName("subscribed")]
        public bool? subscribed { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("cover")]
        public Cover cover { get; set; }

        [JsonPropertyName("isTemplate")]
        public bool? isTemplate { get; set; }

        [JsonPropertyName("cardRole")]
        public object cardRole { get; set; }

        [JsonPropertyName("attachments")]
        public List<object> attachments { get; set; }

        [JsonPropertyName("stickers")]
        public List<object> stickers { get; set; }

        [JsonPropertyName("limits")]
        public Limits limits { get; set; }
    }

    public class Trello
    {
        [JsonPropertyName("board")]
        public int? board { get; set; }

        [JsonPropertyName("card")]
        public int? card { get; set; }
    }

    // GetCardByIdResponse myDeserializedClass = JsonSerializer.Deserialize<GetCardByIdResponse>(myJsonResponse);
    public class GetCardByIdResponse
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("badges")]
        public Badges badges { get; set; }

        [JsonPropertyName("checkItemStates")]
        public List<object> checkItemStates { get; set; }

        [JsonPropertyName("closed")]
        public bool? closed { get; set; }

        [JsonPropertyName("dueComplete")]
        public bool? dueComplete { get; set; }

        [JsonPropertyName("dateLastActivity")]
        public DateTime? dateLastActivity { get; set; }

        [JsonPropertyName("desc")]
        public string desc { get; set; }

        [JsonPropertyName("descData")]
        public DescData descData { get; set; }

        [JsonPropertyName("due")]
        public object due { get; set; }

        [JsonPropertyName("dueReminder")]
        public object dueReminder { get; set; }

        [JsonPropertyName("email")]
        public object email { get; set; }

        [JsonPropertyName("idBoard")]
        public string idBoard { get; set; }

        [JsonPropertyName("idChecklists")]
        public List<object> idChecklists { get; set; }

        [JsonPropertyName("idList")]
        public string idList { get; set; }

        [JsonPropertyName("idMembers")]
        public List<string> idMembers { get; set; }

        [JsonPropertyName("idMembersVoted")]
        public List<object> idMembersVoted { get; set; }

        [JsonPropertyName("idShort")]
        public int? idShort { get; set; }

        [JsonPropertyName("idAttachmentCover")]
        public object idAttachmentCover { get; set; }

        [JsonPropertyName("labels")]
        public List<object> labels { get; set; }

        [JsonPropertyName("idLabels")]
        public List<object> idLabels { get; set; }

        [JsonPropertyName("manualCoverAttachment")]
        public bool? manualCoverAttachment { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("pos")]
        public int? pos { get; set; }

        [JsonPropertyName("shortLink")]
        public string shortLink { get; set; }

        [JsonPropertyName("shortUrl")]
        public string shortUrl { get; set; }

        [JsonPropertyName("start")]
        public object start { get; set; }

        [JsonPropertyName("subscribed")]
        public bool? subscribed { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("cover")]
        public Cover cover { get; set; }

        [JsonPropertyName("isTemplate")]
        public bool? isTemplate { get; set; }

        [JsonPropertyName("cardRole")]
        public object cardRole { get; set; }
    }

    public class UpdateCardResponse
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("badges")]
        public Badges badges { get; set; }

        [JsonPropertyName("checkItemStates")]
        public List<object> checkItemStates { get; set; }

        [JsonPropertyName("closed")]
        public bool? closed { get; set; }

        [JsonPropertyName("dueComplete")]
        public bool? dueComplete { get; set; }

        [JsonPropertyName("dateLastActivity")]
        public DateTime? dateLastActivity { get; set; }

        [JsonPropertyName("desc")]
        public string desc { get; set; }

        [JsonPropertyName("descData")]
        public DescData descData { get; set; }

        [JsonPropertyName("due")]
        public object due { get; set; }

        [JsonPropertyName("dueReminder")]
        public object dueReminder { get; set; }

        [JsonPropertyName("email")]
        public object email { get; set; }

        [JsonPropertyName("idBoard")]
        public string idBoard { get; set; }

        [JsonPropertyName("idChecklists")]
        public List<object> idChecklists { get; set; }

        [JsonPropertyName("idList")]
        public string idList { get; set; }

        [JsonPropertyName("idMembers")]
        public List<string> idMembers { get; set; }

        [JsonPropertyName("idMembersVoted")]
        public List<object> idMembersVoted { get; set; }

        [JsonPropertyName("idShort")]
        public int? idShort { get; set; }

        [JsonPropertyName("idAttachmentCover")]
        public object idAttachmentCover { get; set; }

        [JsonPropertyName("labels")]
        public List<object> labels { get; set; }

        [JsonPropertyName("idLabels")]
        public List<object> idLabels { get; set; }

        [JsonPropertyName("manualCoverAttachment")]
        public bool? manualCoverAttachment { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("pos")]
        public int? pos { get; set; }

        [JsonPropertyName("shortLink")]
        public string shortLink { get; set; }

        [JsonPropertyName("shortUrl")]
        public string shortUrl { get; set; }

        [JsonPropertyName("start")]
        public object start { get; set; }

        [JsonPropertyName("subscribed")]
        public bool? subscribed { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("cover")]
        public Cover cover { get; set; }

        [JsonPropertyName("isTemplate")]
        public bool? isTemplate { get; set; }

        [JsonPropertyName("cardRole")]
        public object cardRole { get; set; }
    }