using System;
using System.Text.Json.Serialization;

namespace DevThings.DockerHubApi.V2.Responses;

/// <summary>
/// Image information
/// </summary>
public class ImageResponse
{
    /// <summary>
    /// CPU architecture
    /// </summary>
    [JsonPropertyName("architecture")]
    public string Architecture { get; set; } = string.Empty;

    /// <summary>
    /// CPU features
    /// </summary>
    [JsonPropertyName("features")]
    public string Features { get; set; } = string.Empty;

    /// <summary>
    /// CPU variant
    /// </summary>
    [JsonPropertyName("variant")]
    public string Variant { get; set; } = string.Empty;

    /// <summary>
    /// Image digest
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; } = null;

    /// <summary>
    /// Layers
    /// </summary>
    [JsonPropertyName("layers")]
    public ImageLayerResponse[]? Layers { get; set; } = null;

    /// <summary>
    /// Operating system
    /// </summary>
    [JsonPropertyName("os")]
    public string OS { get; set; } = string.Empty;

    /// <summary>
    /// OS features
    /// </summary>
    [JsonPropertyName("os_features")]
    public string OSFeatures { get; set; } = string.Empty;

    /// <summary>
    /// OS version
    /// </summary>
    [JsonPropertyName("os_version")]
    public string OSVersion { get; set; } = string.Empty;

    /// <summary>
    /// Size of the image
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; } = 0;

    /// <summary>
    /// Status of the image
    /// </summary>
    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ImageStatusResponse Status { get; set; }

    /// <summary>
    /// Datetime of last pull
    /// </summary>
    [JsonPropertyName("last_pulled")]
    public DateTime? LastPulled { get; set; } = null;

    /// <summary>
    /// Datetime of last push
    /// </summary>
    [JsonPropertyName("last_pushed")]
    public DateTime? LastPushed { get; set; } = null;
}