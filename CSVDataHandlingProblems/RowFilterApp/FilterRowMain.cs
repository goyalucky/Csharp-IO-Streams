/* Filter Records from CSV
● Read a CSV file and filter students who have scored more than 80 marks.
● Print only the qualifying records. */


using System;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace RowFilterApp
{
    public class FilterRowMain
    {
        public static void Execute(){
            string filePath = "RowFilterApp/data.csv";
            int threshold = 80;
            try
            {
                FilterHighScorers(filePath, threshold);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // method to filter and print students with marks greater than threshold
        static void FilterHighScorers(string filePath, int threshold)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();          // Read first row
                csv.ReadHeader();    // Skip header

                Console.WriteLine("Students scoring more than " + threshold + " marks:");
                Console.WriteLine("Id\tName\tMarks");
                while (csv.Read())
                {
                    int marks = csv.GetField<int>("Marks"); // Get Marks column
                    if (marks > threshold)
                    {
                        string id = csv.GetField("Id");
                        string name = csv.GetField("Name");
                        Console.WriteLine($"{id}\t{name}\t{marks}");
                    }
                }
            }
        }
    }
}
