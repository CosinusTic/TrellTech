using System.Text.Json.Serialization;

namespace TrelloApp.Contracts.Response;

    public class GetListByIdResponse
    {
        [JsonPropertyName("id")]
        public string id { get; set; }
        
        [JsonPropertyName("name")]
        public string name { get; set; }
        
        [JsonPropertyName("closed")]
        public bool? closed { get; set; }
        
        [JsonPropertyName("color")]
        public string? color { get; set; }
        
        [JsonPropertyName("idBoard")]
        public string idBoard { get; set; }
        
        [JsonPropertyName("pos")]
        public int? pos { get; set; }
    }

    public class ListCardResponse
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("badges")]
        public Badges? badges { get; set; }

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

    public class CreateListResponse
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("closed")]
        public bool? closed { get; set; }

        [JsonPropertyName("color")]
        public object? color { get; set; }

        [JsonPropertyName("idBoard")]
        public string idBoard { get; set; }

        [JsonPropertyName("pos")]
        public int? pos { get; set; }

        [JsonPropertyName("limits")]
        public Limits limits { get; set; }
    }

    public class UpdateListResponse
    {
        [JsonPropertyName("id")]
        public string id { get; set; }
        
        [JsonPropertyName("name")]
        public string name { get; set; }
        
        [JsonPropertyName("closed")]
        public bool? closed { get; set; }
        
        [JsonPropertyName("color")]
        public object? color { get; set; }
        
        [JsonPropertyName("idBoard")]
        public string idBoard { get; set; }
        
        [JsonPropertyName("pos")]
        public int? pos { get; set; }
    }

    public class ToggleArchiveListResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("closed")]
        public bool? Closed { get; set; }
        
        [JsonPropertyName("color")]
        public object? Color { get; set; }
        
        [JsonPropertyName("idBoard")]
        public string? idBoard { get; set; }
        
        [JsonPropertyName("pos")]
        public int? Pos { get; set; }
    }



