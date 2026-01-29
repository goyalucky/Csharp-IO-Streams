/* Problem Statement: IPL and Censorship Analyzer
Objective
Develop a C# application that reads IPL match data from JSON and CSV files,
processes the data based on defined censorship rules, and writes the sanitized
data back to new files.

Requirements
1️⃣Input Data Formats
The application should support:
● JSON Input: IPL match data in JSON format.
● CSV Input: IPL match data in CSV format.
2️⃣Censorship Rules
The program should apply the following censorship rules:
1. Mask Team Names → Replace part of the team name with "***".
o Example: "Mumbai Indians" → "Mumbai ***"
2. Redact Player of the Match → Replace player names with "REDACTED".
3️⃣Output Data Formats
● Generate censored JSON and censored CSV files after processing. */


using System.IO;
using System.Text.Json;
using System.Collections.Generic;
namespace IPLDataCensorship
{
    class JsonHandler{
    public static void ProcessJson(string inputPath, string outputPath)
    {
        // Read JSON content from file
        string jsonData = File.ReadAllText(inputPath);

        // Convert JSON data to list of key-value pairs
        var matches = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(jsonData);

        // Apply censorship rules to each match
        foreach (var match in matches)
        {
            match["Team1"] = CensorHelper.MaskTeamName(match["Team1"]);
            match["Team2"] = CensorHelper.MaskTeamName(match["Team2"]);
            match["Winner"] = CensorHelper.MaskTeamName(match["Winner"]);

            // Redact Player of the Match
            match["PlayerOfMatch"] = "REDACTED";
        }

        // Format JSON output neatly
        var options = new JsonSerializerOptions { WriteIndented = true };

        // Write censored JSON to new file
        File.WriteAllText(outputPath, JsonSerializer.Serialize(matches, options));
    }
}
}
