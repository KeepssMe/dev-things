using System.Runtime.Serialization;

namespace DevThings.DockerHubApi.V2.Responses;

/// <summary>
/// Image status
/// </summary>
public enum ImageStatusResponse
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "inactive")]
    Inactive
}