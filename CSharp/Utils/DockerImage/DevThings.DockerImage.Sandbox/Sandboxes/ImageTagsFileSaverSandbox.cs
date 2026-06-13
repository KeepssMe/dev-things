using DevThings.DockerHubApi.V2;
using DevThings.MicrosoftArtifactRegistryApi.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DevThings.DockerImage.Sandbox.Sandboxes;

internal class ImageTagsFileSaverSandbox
{
    private const string DirImageTags = "image_tags";

    public ImageTagsFileSaverSandbox()
    {

    }

    public async Task Start(
        List<string> microsoftRepositories,
        List<(string? namespaceRepo, string repo)> dockerRepositories)
    {
        if (!Directory.Exists(DirImageTags))
        {
            Directory.CreateDirectory(DirImageTags);
        }

        foreach (string repository in microsoftRepositories)
        {
            var fileName = $"{repository.Replace("/", "__")}.txt";
            var filePath = Path.Combine(DirImageTags, fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            var tags = await ParseTagsMicrosoft(repository)
                .Distinct()
                .ToArrayAsync();

            File.WriteAllLines(filePath, tags);
        }

        foreach (var (namespaceRepo, repository) in dockerRepositories)
        {
            var fileName = $"{(string.IsNullOrWhiteSpace(namespaceRepo) ? "" : $"{namespaceRepo}__")}{repository.Replace("/", "__")}.txt";
            var filePath = Path.Combine(DirImageTags, fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            var tags = await ParseTagsDockerHub(namespaceRepo, repository)
                .Distinct()
                .ToArrayAsync();

            File.WriteAllLines(filePath, tags);
        }

    }

    public static async IAsyncEnumerable<string> ParseTagsMicrosoft(string repository)
    {
        var response = await MicrosoftArtifactRegistryApiV1Client.GetRepositoryTagsAsync(repository);
        Console.WriteLine($"Parse repo {repository}");

        foreach (var tag in response)
        {
            yield return tag.Name;
        }
    }

    public static async IAsyncEnumerable<string> ParseTagsDockerHub(string? namespaceRepo, string repository)
    {
        var repoName = string.IsNullOrWhiteSpace(namespaceRepo) ? repository : $"{namespaceRepo}/{repository}";

        var page = 0;

        do
        {
            var response = await DockerHubApiV2Client.GetListRepositoryTagsAsync(new()
            {
                Namespace = namespaceRepo,
                Repository = repository,
                Page = page + 1,
                PageSize = 100
            });

            Console.WriteLine($"Parse repo {repoName} [{page * 100 + (response.Results?.Length ?? 0)}/{response.Count}]");

            foreach (var tag in response.Results ?? [])
            {
                yield return tag.Name;
            }

            if (string.IsNullOrWhiteSpace(response.Next))
            {
                page = -1;
            }
            else
            {
                page++;
            }
        }
        while (page >= 0);
    }
}