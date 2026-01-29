/* Read Large CSV File Efficiently
● Given a large CSV file (500MB+), implement a memory-efficient way to read it in chunks.
● Process only 100 lines at a time and display the count of records processed. */


using CsvHelper;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System;
namespace LargeCSVReader{
    public class LargeCsvProcessor{
    public static void Process(string filePath)
    {
        const int batchSize = 100;
        int total = 0;
        var batch = new List<Student>(batchSize);

        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        foreach (var record in csv.GetRecords<Student>())
        {
            batch.Add(record);

            if (batch.Count == batchSize)
            {
                total += batchSize;
                batch.Clear();
                Console.WriteLine($"Records processed: {total}");
            }
        }

        if (batch.Count > 0)
        {
            total += batch.Count;
            Console.WriteLine($"Records processed: {total}");
        }
    }
}
}
