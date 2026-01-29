/* Develop a C# application that reads IPL match data from JSON and CSV files, processes the data based on defined censorship rules,
and writes the sanitized data back to new files.
Requirements
Input Data Formats
The application should support:
● JSON Input: IPL match data in JSON format.
● CSV Input: IPL match data in CSV format.
Censorship Rules
The program should apply the following censorship rules:
1. Mask Team Names → Replace part of the team name with "***".
o Example: "Mumbai Indians" → "Mumbai ***"
2. Redact Player of the Match → Replace player names with "REDACTED".
Output Data Formats
● Generate censored JSON and censored CSV files after processing. */

using System;
namespace IPLDataCensorship
{
    public class IPLMain{
    public static void Execute(){
        // Starting message
        Console.WriteLine("IPL Data Censorship Started..\n");

        // Process JSON file
        JsonHandler.ProcessJson(
            "IPLDataCensorship/ipl_matches.json",
            "IPLDataCensorship/ipl_matches_censored.json"
        );

        // Process CSV file
        CsvHandler.ProcessCsv(
            "IPLDataCensorship/ipl_matches.csv",
            "IPLDataCensorship/ipl_matches_censored.csv"
        );

        // Completion message
        Console.WriteLine("\nCensorship Completed Successfully!");
    }
}
}
