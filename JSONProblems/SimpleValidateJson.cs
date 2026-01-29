// Validate JSON structure using Newtonsoft.Json.Schema.

using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
namespace JSONProblems{
    public class SimpleValidateJson{
    public static void Execute(){
        // JSON data to validate
        string jsonData = @"{
            ""name"": ""Prashant"",
            ""age"": 21,
            ""email"": ""prashant@gmail.com""
        }";

        // JSON Schema for validation
        string jsonSchema = @"{
            ""type"": ""object"",
            ""properties"": {
                ""name"": { ""type"": ""string"" },
                ""age"": { ""type"": ""integer"" },
                ""email"": { ""type"": ""string"" }
            },
            ""required"": [""name"", ""age"", ""email""]
        }";

        // Parse JSON and Schema
        JObject obj = JObject.Parse(jsonData);
        JSchema schema = JSchema.Parse(jsonSchema);

        // Validate JSON
        if (obj.IsValid(schema))
            Console.WriteLine("JSON is valid");
        else
            Console.WriteLine("JSON is invalid");
    }
}
}
