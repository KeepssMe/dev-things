using DevThings.DockerImage.Sandbox.Sandboxes;
using System.Threading.Tasks;

namespace DevThings.DockerImage.Sandbox;

internal static class Program
{
    private static async Task Main(string[] args)
    {

        //await new ImageTagsFileSaverSandbox()
        //    .Start(
        //        ["mssql/rhel/server", "mssql/server", "dotnet/aspnet", "dotnet/runtime", "dotnet/sdk"],
        //        []
        //    );

        //await new ImageTagsFileSaverSandbox()
        //    .Start(
        //        [],
        //        [
        //            (null, "rabbitmq"),
        //            (null, "elasticsearch"),
        //            ("opensearchproject", "opensearch"),
        //            ("mongodb", "mongodb-community-server"),
        //            (null, "redis"),
        //            (null, "mysql"),
        //            (null, "nginx"),
        //            ("minio", "minio"),
        //            ("rustfs", "rustfs"),
        //            ("apache", "kafka"),
        //            (null, "neo4j"),
        //            ("clickhouse", "clickhouse-server"),
        //            (null, "cassandra"),
        //            ("valkey", "valkey")
        //        ]
        //    );
    }
}
