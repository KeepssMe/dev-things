using System.Text.Json.Serialization;

namespace DevThings.DockerHubApi.V2.Responses;

/// <summary>
/// List of repository tags
/// </summary>
public class ListRepositoryTagsResponse
{
    /// <summary>
    /// Total number of results available across all pages
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; } = 0;

    /// <summary>
    /// Link to next page of results if any
    /// </summary>
    [JsonPropertyName("next")]
    public string? Next { get; set; } = null;

    /// <summary>
    /// link to previous page of results if any
    /// </summary>
    [JsonPropertyName("previous")]
    public string? Previous { get; set; } = null;

    /// <summary>
    /// Tags
    /// </summary>
    [JsonPropertyName("results")]
    public TagResponse[]? Results { get; set; } = null;
}