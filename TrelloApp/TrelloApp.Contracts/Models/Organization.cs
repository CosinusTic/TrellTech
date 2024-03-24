using System.Text.Json.Serialization;

namespace TrelloApp.Contracts.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);  

public class Organization
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
    public List<object>? Products { get; set; }

    [JsonPropertyName("powerUps")]
    public List<object>? PowerUps { get; set; }
}

public class DescData
{
    [JsonPropertyName("emoji")]
    public Emoji? Emoji { get; set; }
}

public class Emoji
{
}

        