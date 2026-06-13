using DevThings.MicrosoftArtifactRegistryApi.V1.Requests;
using DevThings.MicrosoftArtifactRegistryApi.V1.Responses;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DevThings.MicrosoftArtifactRegistryApi.V1;

public static class MicrosoftArtifactRegistryApiV1Client
{
    private readonly static HttpClient _apiHttpClient = new()
    {
        BaseAddress = new Uri("https://mcr.microsoft.com/api/v1/"),
        Timeout = TimeSpan.FromSeconds(30)
    };


    #region Methods

    private const string GetCategoriesPath = "catalog/products/categories";

    public static async Task<string[]> GetCategoriesAsync()
    {
        return await GetAsync<string[]>(GetCategoriesPath);
    }

    private const string SearchRepositoriesPath = "catalog/products";

    public static async Task<RepositoryDetailsResponse[]> SearchRepositoriesAsync(SearchRepositoriesRequest? request = null)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(SearchRepositoriesPath);

        Dictionary<string, string> queryValues = [];

        if (request?.Categories?.Count > 0)
        {
            queryValues.Add("cat", string.Join(",", request.Categories));
        }

        if (request?.SortType != null)
        {
            var sort = (request.SortAscending ?? true) ? "asc" : "desc";

            switch (request.SortType)
            {
                case SearchRepositoriesSortTypeRequest.Alphabetically:
                    queryValues.Add("alphaSortKey", "Name");
                    queryValues.Add("alphaSort", sort);
                    break;

                case SearchRepositoriesSortTypeRequest.PublishDate:
                    queryValues.Add("dateSort", sort);
                    break;
                default:
                    throw new NotImplementedException($"Sort {request.SortType} not implemented");
            }
        }

        if (request?.LastPublishDateAfter != null)
        {
            queryValues.Add("afterDate", request.LastPublishDateAfter.Value.ToString("o"));
        }

        if (request?.LastPublishDateBefore != null)
        {
            queryValues.Add("beforeDate", request.LastPublishDateBefore.Value.ToString("o"));
        }

        if (queryValues.Count > 0)
        {
            using FormUrlEncodedContent query = new FormUrlEncodedContent(queryValues);
            sb.Append('?').Append(await query.ReadAsStringAsync());
        }

        return await GetAsync<RepositoryDetailsResponse[]>(sb.ToString());
    }

    private const string GetRepositoryDetailsPath = "catalog/{0}/details?reg=mar";

    public static async Task<RepositoryDetailsResponse> GetRepositoryDetailsAsync(string repository)
    {
        var path = string.Format(GetRepositoryDetailsPath, repository);
        return await GetAsync<RepositoryDetailsResponse>(path);
    }

    private const string GetRepositoryTagsPath = "catalog/{0}/tags?reg=mar";

    public static async Task<RepositoryTagResponse[]> GetRepositoryTagsAsync(string repository)
    {
        var path = string.Format(GetRepositoryTagsPath, repository);
        return await GetAsync<RepositoryTagResponse[]>(path);
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