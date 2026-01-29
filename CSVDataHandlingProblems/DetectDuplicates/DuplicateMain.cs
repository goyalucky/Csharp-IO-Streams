/* Detect Duplicates in a CSV File
● Read a CSV file and detect duplicate entries based on the ID column.
● Print all duplicate records. */


using System;
using System.IO;
namespace DetectDuplicates{
    public class DuplicateMain{
    public static void Execute()
    {
        string filePath = "DetectDuplicates/students.csv";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }
        DuplicateDetector.FindDuplicates(filePath);
    }
}
}

