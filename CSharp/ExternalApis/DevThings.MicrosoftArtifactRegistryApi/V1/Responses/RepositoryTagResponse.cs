using System;
using System.Text.Json.Serialization;

namespace DevThings.MicrosoftArtifactRegistryApi.V1.Responses;

public class RepositoryTagResponse
{
    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("digest")]
    public string Digest { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("layerZeroDigest")]
    public string? LayerZeroDigest { get; set; } = null;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("layerZeroSize")]
    public long? LayerZeroSize { get; set; } = null;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("repository")]
    public string Repository { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("regHash")]
    public string RegHash { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("operatingSystem")]
    public string OperatingSystem { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("lastModifiedDate")]
    public DateTime LastModifiedDate { get; set; } = DateTime.MinValue;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("createdDate")]
    public DateTime CreatedDate { get; set; } = DateTime.MinValue;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; } = null;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("annotations")]
    public bool? Annotations { get; set; } = null;
}