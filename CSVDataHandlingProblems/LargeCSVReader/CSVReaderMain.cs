/* Read Large CSV File Efficiently
● Given a large CSV file (500MB+), implement a memory-efficient way to read it in chunks.
● Process only 100 lines at a time and display the count of records processed. */


using System;
using System.IO;
namespace LargeCSVReader{
public class CSVReaderMain{
    public static void Execute(){
        string filePath = "LargeCSVReader/largefile.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }

        LargeCsvProcessor.Process(filePath);
    }
}
}
