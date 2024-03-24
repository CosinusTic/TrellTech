using System.Text.Json.Serialization;

namespace TrelloApp.Contracts.Models;

public class List
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

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

}