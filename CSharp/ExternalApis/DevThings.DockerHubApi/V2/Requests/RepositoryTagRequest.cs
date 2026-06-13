namespace DevThings.DockerHubApi.V2.Requests;

public class RepositoryTagRequest
{
    public string? Namespace { get; set; } = null;

    public required string Repository { get; set; }

    public required string Tag { get; set; }
}