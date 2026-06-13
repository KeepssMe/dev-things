using System;
using System.Collections.Generic;

namespace DevThings.MicrosoftArtifactRegistryApi.V1.Requests;

public class SearchRepositoriesRequest
{
    public List<string>? Categories { get; set; } = null;

    public SearchRepositoriesSortTypeRequest? SortType { get; set; } = null;

    public bool? SortAscending { get; set; } = null;

    public DateTime? LastPublishDateAfter { get; set; } = null;

    public DateTime? LastPublishDateBefore { get; set; } = null;
}