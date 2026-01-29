// Merge two JSON objects into one.

using System;
using System.Text.Json;
using System.Text.Json.Nodes;
namespace JSONProblems{
    public class MergeJsonObjects{
    public static void Execute(){
        // First JSON object
        string json1 = @"{
            ""name"": ""Prashant"",
            ""age"": 21
        }";

        // Second JSON object
        string json2 = @"{
            ""email"": ""prashant@gmail.com"",
            ""city"": ""Mathura""
        }";

        // Parse JSON strings into JsonObject
        JsonObject obj1 = JsonNode.Parse(json1).AsObject();
        JsonObject obj2 = JsonNode.Parse(json2).AsObject();

        // Merge obj2 into obj1
        foreach (var item in obj2)
        {
            obj1[item.Key] = item.Value;
        }

        // Convert merged JSON object back to string
        string mergedJson = obj1.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(mergedJson);
    }
}
}
