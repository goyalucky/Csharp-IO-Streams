/* Detect Duplicates in a CSV File
● Read a CSV file and detect duplicate entries based on the ID column.
● Print all duplicate records. */


using CsvHelper;
using System.Globalization;
using System.IO;
using System;
using System.Collections.Generic;
namespace DetectDuplicates{
    public class DuplicateDetector{
    public static void FindDuplicates(string filePath)
    {
        var seenIds = new HashSet<int>();
        var duplicates = new List<Student>();

        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        foreach (var record in csv.GetRecords<Student>())
        {
            if (!seenIds.Add(record.Id))
                duplicates.Add(record);
        }

        Console.WriteLine("Duplicate Records:");
        foreach (var student in duplicates)
        {
            Console.WriteLine($"Id={student.Id}, Name={student.Name}, Age={student.Age}");
        }
    }
}
}
