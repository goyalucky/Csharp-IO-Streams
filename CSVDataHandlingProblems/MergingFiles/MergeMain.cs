/* Merge Two CSV Files
● You have two CSV files:
○ students1.csv (contains ID, Name, Age)
○ students2.csv (contains ID, Marks, Grade)
● Merge both files based on ID and create a new file containing all details. */


using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace MergingFiles{
    public class MergeMain{
    public static void Execute()
    {
        var students1Path = "MergingFiles/students1.csv";
        var students2Path = "MergingFiles/students2.csv";
        var outputPath = "students_merged.csv";
        List<StudentBasic> students1;
        List<StudentMarks> students2;

        // Read first CSV
        using (var reader = new StreamReader(students1Path))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            students1 = csv.GetRecords<StudentBasic>().ToList();
        }

        // Read second CSV
        using (var reader = new StreamReader(students2Path))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            students2 = csv.GetRecords<StudentMarks>().ToList();
        }

        // Merge based on ID
        var mergedStudents =
            from s1 in students1
            join s2 in students2 on s1.Id equals s2.Id
            select new StudentMerged
            {
                Id = s1.Id,
                Name = s1.Name,
                Age = s1.Age,
                Marks = s2.Marks,
                Grade = s2.Grade
            };

        // Write merged CSV
        using (var writer = new StreamWriter(outputPath))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(mergedStudents);
        }
        Console.WriteLine("CSV files merged successfully!");
    }
}
}
