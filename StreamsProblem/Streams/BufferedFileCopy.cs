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
    public class BufferedFileCopy
    {
        public static void CopyFile(string sourcePath, string destPath)
        {
            byte[] buffer = new byte[4096]; // 4 KB buffer
            Stopwatch sw = Stopwatch.StartNew();

            using (FileStream fsRead = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (FileStream fsWrite = new FileStream(destPath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite))
            {
                int bytesRead;
                // Read and write using buffered streams
                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bsWrite.Write(buffer, 0, bytesRead);
                }
            }

            sw.Stop();
            Console.WriteLine("Buffered Copy Time: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
