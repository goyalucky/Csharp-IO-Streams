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


using System;
using System.IO;

namespace IPLDataCensorship
{
    class CensorHelper{
    // Masks team name by keeping first word and hiding the rest
    // Example: "Mumbai Indians" -> "Mumbai ***"
    public static string MaskTeamName(string team)
    {
        // Check for null or empty value
        if (string.IsNullOrEmpty(team))
            return team;

        // Split team name and keep first word
        return team.Split(' ')[0] + " ***";
    }
}
}

