// Read a JSON file and print all keys and values.

using System;
using System.IO;
using System.Text.Json;

namespace JSONProblems{
    public class ReadJsonPrintKeysValues
    {
        public static void Execute(){
            // Path to JSON file
            string filePath = "data.json";

            // Read JSON file content
            string jsonData = File.ReadAllText(filePath);

            // Parse JSON
            using JsonDocument document = JsonDocument.Parse(jsonData);

            // Print all keys and values
            PrintElement(document.RootElement);
        }

        static void PrintElement(JsonElement element, string indent = "")
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    foreach (var property in element.EnumerateObject())
                    {
                        Console.WriteLine($"{indent}{property.Name}:");
                        PrintElement(property.Value, indent + "  ");
                    }
                    break;

                case JsonValueKind.Array:
                    foreach (var item in element.EnumerateArray())
                    {
                        PrintElement(item, indent + "  ");
                    }
                    break;

                default:
                    Console.WriteLine($"{indent}{element}");
                    break;
            }
        }
    }
}
