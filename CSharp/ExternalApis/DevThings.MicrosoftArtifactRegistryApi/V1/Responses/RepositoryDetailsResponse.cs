using System;
using System.Text.Json.Serialization;

namespace DevThings.MicrosoftArtifactRegistryApi.V1.Responses;

/// <summary>
/// Detailed information about the repository
/// </summary>
public class RepositoryDetailsResponse
{
    /// <summary>
    /// Description (markdown)
    /// </summary>
    [JsonPropertyName("readme")]
    public string? Readme { get; set; } = null;

    /// <summary>
    /// Supported tags
    /// </summary>
    [JsonPropertyName("supportedTags")]
    public string[]? SupportedTags { get; set; } = null;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("projectWebsite")]
    public Uri? ProjectWebsite { get; set; } = null;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("projectRepostioryUrl")]
    public Uri? ProjectRepostioryUrl { get; set; } = null;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("licenseType")]
    public string LicenseType { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("licenseUrl")]
    public Uri LicenseUrl { get; set; } = default!;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("supportLink")]
    public Uri SupportLink { get; set; } = default!;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("documentationLink")]
    public Uri DocumentationLink { get; set; } = default!;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("totalPullCount")]
    public string TotalPullCount { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("sourceRepository")]
    public string SourceRepository { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("readmeNeedsTagTable")]
    public bool ReadmeNeedsTagTable { get; set; } = false;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("regHash")]
    public string RegHash { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("repository")]
    public string Repository { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("publisher")]
    public string Publisher { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("keywords")]
    public bool[]? Keywords { get; set; } = null;

    /// <summary>
    /// Short description
    /// </summary>
    [JsonPropertyName("shortDescription")]
    public string? ShortDescription { get; set; } = null;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("imagePath")]
    public string ImagePath { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("imageAltText")]
    public string ImageAltText { get; set; } = string.Empty;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("lastModifiedDate")]
    public DateTime LastModifiedDate { get; set; } = DateTime.MinValue;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("sizeInBytes")]
    public int SizeInBytes { get; set; } = 0;

    /// <summary>
    /// Supported architectures
    /// </summary>
    [JsonPropertyName("architectures")]
    public string[]? Architectures { get; set; } = null;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("artifacts")]
    public bool[]? Artifacts { get; set; } = null;

    /// <summary>
    /// Categories
    /// </summary>
    [JsonPropertyName("categories")]
    public string[]? Categories { get; set; } = null;

    /// <summary>
    /// Supported operating systems
    /// </summary>
    [JsonPropertyName("operatingSystems")]
    public string[]? OperatingSystems { get; set; } = null;

    /// <summary>
    /// You need to log in
    /// </summary>
    [JsonPropertyName("authRequired")]
    public bool AuthRequired { get; set; } = false;
}