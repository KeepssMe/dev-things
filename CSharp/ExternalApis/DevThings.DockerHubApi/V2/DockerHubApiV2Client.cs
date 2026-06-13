using DevThings.DockerHubApi.V2.Requests;
using DevThings.DockerHubApi.V2.Responses;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DevThings.DockerHubApi.V2;

public static class DockerHubApiV2Client
{
    private readonly static HttpClient _apiHttpClient = new()
    {
        BaseAddress = new Uri("https://hub.docker.com/v2/"),
        Timeout = TimeSpan.FromSeconds(30)
    };

    #region Methods

    private const string GetListRepositoryTagsPath = "namespaces/{0}/repositories/{1}/tags";

    public static async Task<ListRepositoryTagsResponse> GetListRepositoryTagsAsync(ListRepositoryTagsRequest request)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(
            string.Format(
                    GetListRepositoryTagsPath,
                    string.IsNullOrWhiteSpace(request.Namespace) ? "library" : request.Namespace,
                    request.Repository
            )
        );

        Dictionary<string, string> queryValues = [];

        if (request.Page.HasValue)
        {
            queryValues.Add("page", Math.Max(1, request.Page.Value).ToString());
        }

        if (request.PageSize.HasValue)
        {
            queryValues.Add("page_size", Math.Clamp(request.PageSize.Value, 1, 100).ToString());
        }

        if (queryValues.Count > 0)
        {
            using FormUrlEncodedContent query = new FormUrlEncodedContent(queryValues);
            sb.Append('?').Append(await query.ReadAsStringAsync());
        }

        return await GetAsync<ListRepositoryTagsResponse>(sb.ToString());
    }

    private const string GetRepositoryTagPath = "namespaces/{0}/repositories/{1}/tags/{2}";

    public static async Task<TagResponse> GetRepositoryTagAsync(RepositoryTagRequest request)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(
            string.Format(
                    GetRepositoryTagPath,
                    string.IsNullOrWhiteSpace(request.Namespace) ? "library" : request.Namespace,
                    request.Repository,
                    request.Tag
            )
        );

        return await GetAsync<TagResponse>(sb.ToString());
    }

    #endregion

    #region Send

    private static async Task<TResponse> GetAsync<TResponse>(string path)
    {
        using HttpRequestMessage request = new(HttpMethod.Get, path);

        using var response = await _apiHttpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);

        var bytes = await response.EnsureSuccessStatusCode().Content.ReadAsByteArrayAsync();
        return JsonSerializer.Deserialize<TResponse>(Encoding.UTF8.GetString(bytes))!;
    }

    #endregion
}