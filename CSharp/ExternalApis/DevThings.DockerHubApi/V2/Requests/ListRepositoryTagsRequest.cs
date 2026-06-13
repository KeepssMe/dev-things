namespace DevThings.DockerHubApi.V2.Requests;

public class ListRepositoryTagsRequest
{
    public string? Namespace { get; set; } = null;

    public required string Repository { get; set; }

    public int? Page { get; set; } = null;

    public int? PageSize { get; set; } = null;
}