using System.Text.Json;
using System.Text.Json.Serialization;

public static class JsonFileReader
{
    public static T Read<T>(string filePath)
    {
        var options = new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
        };
        string text = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(text, options);
    }
}