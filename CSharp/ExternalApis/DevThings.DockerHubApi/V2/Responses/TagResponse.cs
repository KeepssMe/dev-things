using System;
using System.Text.Json.Serialization;

namespace DevThings.DockerHubApi.V2.Responses;

/// <summary>
/// Repository tag information
/// </summary>
public class TagResponse
{
    /// <summary>
    /// Tag Id
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; } = 0;

    /// <summary>
    /// Images
    /// </summary>
    [JsonPropertyName("images")]
    public ImageResponse[]? Images { get; set; } = null;

    /// <summary>
    /// Id of the user that pushed the tag
    /// </summary>
    [JsonPropertyName("creator")]
    public int Creator { get; set; } = 0;

    /// <summary>
    /// Datetime of last update
    /// </summary>
    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; set; } = null;

    /// <summary>
    /// Id of the last user that updated the tag
    /// </summary>
    [JsonPropertyName("last_updater")]
    public int LastUpdater { get; set; } = 0;

    /// <summary>
    /// Hub username of the user that updated the tag
    /// </summary>
    [JsonPropertyName("last_updater_username")]
    public string LastUpdaterUsername { get; set; } = string.Empty;

    /// <summary>
    /// Name of the tag
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Repository ID
    /// </summary>
    [JsonPropertyName("repository")]
    public int Repository { get; set; } = 0;

    /// <summary>
    /// Compressed size (sum of all layers) of the tagged image
    /// </summary>
    [JsonPropertyName("full_size")]
    public long FullSize { get; set; } = 0;

    /// <summary>
    /// Repository API version
    /// </summary>
    [JsonPropertyName("v2")]
    public bool V2 { get; set; } = false;

    /// <summary>
    /// Whether a tag has been pushed to or pulled in the past month
    /// </summary>
    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TagStatusResponse Status { get; set; }

    /// <summary>
    /// Datetime of last pull
    /// </summary>
    [JsonPropertyName("tag_last_pulled")]
    public DateTime? TagLastPulled { get; set; } = null;

    /// <summary>
    /// Datetime of last push
    /// </summary>
    [JsonPropertyName("tag_last_pushed")]
    public DateTime? TagLastPushed { get; set; } = null;
}