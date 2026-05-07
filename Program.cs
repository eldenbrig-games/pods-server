using System.Text.Json;
using PODS.Server.Configuration;

if (!File.Exists("config.json"))
{
    Console.WriteLine("ERROR: config.json not found.");
    return;
}

try
{
    var json = await File.ReadAllTextAsync("config.json");

    var config = JsonSerializer.Deserialize<ServerConfig>(
    json,
    new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    }
);

    if (config == null)
    {
        Console.WriteLine("ERROR: Failed to parse config.json");
        return;
    }

    AppConfig.Instance = config;

    Console.WriteLine("=== P.O.D.S Server ===");
    Console.WriteLine($"Name: {AppConfig.Instance.ServerName}");
    Console.WriteLine($"Version: {AppConfig.Instance.ServerVersion}");
    Console.WriteLine($"Issues: {AppConfig.Instance.IssuesUrl}");
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}

