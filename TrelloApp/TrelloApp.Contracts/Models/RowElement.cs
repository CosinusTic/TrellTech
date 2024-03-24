using System.Text.Json.Serialization;

namespace TrelloApp.Contracts.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

public class RowElement
{
    public string? Name { get; set; }
    public string? Desc { get; set; }
    public string? ListName { get; set; }
    public string? Labels { get; set; }
    public List<Member>? Members { get; set; }
    public object? Due { get; set; }
}
