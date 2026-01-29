/* Convert JSON to CSV and Vice Versa
● Read a JSON file containing a list of students.
● Convert it into CSV format and save it.
● Implement another method to read CSV and convert it back to JSON. */


using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;
using CsvHelper;
namespace JSONtoCSVConvertor
{
    public static class JsonCsvConverter{
    // JSON to CSV
    public static void JsonToCsv(string jsonFilePath, string csvFilePath)
    {
        var json = File.ReadAllText(jsonFilePath);
        var students = JsonSerializer.Deserialize<List<Student>>(json);

        using var writer = new StreamWriter(csvFilePath);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(students);
    }

    // CSV to JSON
    public static void CsvToJson(string csvFilePath, string jsonFilePath)
    {
        using var reader = new StreamReader(csvFilePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        var students = csv.GetRecords<Student>();
        var json = JsonSerializer.Serialize(
            students,
            new JsonSerializerOptions { WriteIndented = true }
        );
        File.WriteAllText(jsonFilePath, json);
    }
}

}
