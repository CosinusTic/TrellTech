using System.Text.Json.Serialization;

namespace TrelloApp.Contracts.Request;

public class CreateListRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("closed")]
    public bool? Closed { get; set; }

    [JsonPropertyName("color")]
    public object? Color { get; set; }

    [JsonPropertyName("idBoard")]
    public string? IdBoard { get; set; }

    [JsonPropertyName("pos")]
    public int? Pos { get; set; }
    
    [JsonPropertyName("idListSource")]
    public string? IdListSource { get; set; }

}

public class UpdateListRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("closed")]
    public bool? Closed { get; set; }

    [JsonPropertyName("color")]
    public object? Color { get; set; }

    [JsonPropertyName("idBoard")]
    public string? IdBoard { get; set; }

    [JsonPropertyName("pos")]
    public int? Pos { get; set; }
    
    [JsonPropertyName("subscribed")]
    public bool? Subscribed { get; set; }
}

public class ToggleArchiveListRequest
{
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}