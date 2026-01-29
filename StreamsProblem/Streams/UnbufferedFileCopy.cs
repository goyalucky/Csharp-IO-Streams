/* Buffered Streams - Efficient File Copy
Problem Statement: Create a C# program that copies a large file(e.g., 100MB) from one location to another using Buffered Streams 
(BufferedStream). Compare the performance with normal file streams.
Requirements: Read and write in chunks of 4 KB (4096 bytes). Use Stopwatch to measure execution time. Compare execution time with 
unbuffered streams. */


using System;
using System.Diagnostics;
using System.IO;

namespace Streams
{
    public class UnbufferedFileCopy
    {
        public static void CopyFile(string sourcePath, string destPath)
        {
            byte[] buffer = new byte[4096]; // 4 KB buffer
            Stopwatch sw = Stopwatch.StartNew();

            using (FileStream fsRead = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destPath, FileMode.Create, FileAccess.Write))
            {
                int bytesRead;
                // Read and write file in chunks
                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }
            sw.Stop();
            Console.WriteLine("Unbuffered Copy Time: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
