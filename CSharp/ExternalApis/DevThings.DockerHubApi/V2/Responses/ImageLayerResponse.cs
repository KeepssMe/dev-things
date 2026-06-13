using System.Text.Json.Serialization;

namespace DevThings.DockerHubApi.V2.Responses;

/// <summary>
/// Image layer information
/// </summary>
public class ImageLayerResponse
{
    /// <summary>
    /// Image layer digest
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; } = null;

    /// <summary>
    /// Size of the layer
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; } = 0;

    /// <summary>
    /// Dockerfile instruction
    /// </summary>
    [JsonPropertyName("instruction")]
    public string Instruction { get; set; } = string.Empty;
}