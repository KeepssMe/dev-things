namespace DevThings.MicrosoftArtifactRegistryApi.V1.Requests;

/// <summary>
/// Sorting type when searching for repositories
/// </summary>
public enum SearchRepositoriesSortTypeRequest
{
    /// <summary>
    /// Sort alphabetically
    /// </summary>
    Alphabetically,

    /// <summary>
    /// Sort by latest publication date
    /// </summary>
    PublishDate
}