using System.Runtime.Serialization;

namespace DevThings.DockerHubApi.V2.Responses;

/// <summary>
/// Repository tag status
/// </summary>
public enum TagStatusResponse
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "inactive")]
    Inactive
}