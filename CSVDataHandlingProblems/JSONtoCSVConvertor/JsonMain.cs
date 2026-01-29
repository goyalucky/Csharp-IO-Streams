/* Convert JSON to CSV and Vice Versa
● Read a JSON file containing a list of students.
● Convert it into CSV format and save it.
● Implement another method to read CSV and convert it back to JSON. */


using System;
namespace JSONtoCSVConvertor
{
    public class JsonMain
    {
        public static void Execute()
        {
        string jsonPath = "JSONtoCSVConvertor/students.json";
        string csvPath = "JSONtoCSVConvertor/students.csv";
        string outputJsonPath = "students_from_csv.json";

        JsonCsvConverter.JsonToCsv(jsonPath, csvPath);
        JsonCsvConverter.CsvToJson(csvPath, outputJsonPath);
        }
    }
}