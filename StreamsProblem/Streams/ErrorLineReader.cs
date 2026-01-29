/* Read a Large File Line by Line
Problem Statement: Develop a C# program that efficiently reads a large text file (500MB+) line by line and prints only lines 
containing the word "error".
Requirements: Use StreamReader for efficient reading. Read line-by-line instead of loading the entire file. Display only lines 
containing "error"(case insensitive). */

using System;
using System.IO;

namespace Streams{
    public class ErrorLineReader{
    // Reads large file line by line and prints lines containing "error"
    public static void PrintErrorLines(string filePath)
    {
        using(StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                // case insensitive check
                if(line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
}
