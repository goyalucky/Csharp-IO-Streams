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
using System.Collections.Generic;
namespace IPLDataCensorship
{
    class CsvHandler{
    public static void ProcessCsv(string inputPath, string outputPath)
    {
        // Read all lines from CSV file
        string[] lines = File.ReadAllLines(inputPath);

        // List to store censored data
        List<string> outputLines = new List<string>();

        // Add header row as it is
        outputLines.Add(lines[0]);

        // Process each data row
        for (int i = 1; i < lines.Length; i++)
        {
            // Split row into columns
            string[] cols = lines[i].Split(',');

            // Apply censorship rules
            cols[1] = CensorHelper.MaskTeamName(cols[1]); // Team1
            cols[2] = CensorHelper.MaskTeamName(cols[2]); // Team2
            cols[3] = CensorHelper.MaskTeamName(cols[3]); // Winner
            cols[4] = "REDACTED";                          // Player of Match

            // Join columns and add to output list
            outputLines.Add(string.Join(",", cols));
        }

        // Write censored data to new CSV file
        File.WriteAllLines(outputPath, outputLines);
    }
}

}
