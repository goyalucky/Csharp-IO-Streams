/* Piped Streams - Inter-Thread Communication
Problem Statement: Implement a C# program where one thread writes data into a PipeStream and another thread reads data from it.
Requirements: Use two threads for reading and writing. Synchronize properly to prevent data loss. Handle IOException. */


using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
namespace Streams
{
    public static class PipeHandler
{
    // Starts writer and reader threads using pipe stream
    public static void StartPipeCommunication()
    {
        try
        {
            var server = new AnonymousPipeServerStream(PipeDirection.Out);
            var client = new AnonymousPipeClientStream(PipeDirection.In, server.ClientSafePipeHandle);

            // Writer thread
            new System.Threading.Thread(() =>
            {
                using (server)
                using (StreamWriter writer = new StreamWriter(server, Encoding.UTF8))
                {
                    writer.AutoFlush = true;
                    writer.WriteLine("Message 1 from writer");
                    writer.WriteLine("Message 2 from writer");
                }
            }).Start();

            // Reader thread
            new System.Threading.Thread(() =>
            {
                using (client)
                using (StreamReader reader = new StreamReader(client, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                        Console.WriteLine("Read: " + line);
                }
            }).Start();
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
}


// AutoFlush = true, AutoFlush ensures data is sent immediately to the pipe instead of waiting in the buffer.