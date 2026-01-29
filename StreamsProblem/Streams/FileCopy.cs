/* File Handling - Read and Write a Text File
Problem Statement: Write a C# program that reads the contents of a text file and writes it into a new file. If the source file does not 
exist, display an appropriate message.
Requirements: Use FileStream for reading and writing. Handle IOException properly. Ensure that the destination file is created if it 
does not exist. */

using System;
using System.IO;

namespace Streams
{
    public class FileCopy
    {
        // Copies content from source text file to destination text file
        public static void CopyTextFile(string sourcePath, string destPath)
        {
            try
            {
                // Check whether source file exists
                if (!File.Exists(sourcePath))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                // Open source file for reading
                using (FileStream fsRead = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
                
                // Create/Open destination file for writing
                using (FileStream fsWrite = new FileStream(destPath, FileMode.Create, FileAccess.Write))
                {
                    // Copy data from source file to destination file
                    fsRead.CopyTo(fsWrite);
                }
                Console.WriteLine("File copied successfully.");
            }
            catch (IOException ex)
            {
                // Handle input/output related exceptions
                Console.WriteLine("IO Error: " + ex.Message);
            }
        }
    }
}
