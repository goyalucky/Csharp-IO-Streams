/* Filter Streams - Convert Uppercase to Lowercase
Problem Statement: Create a program that reads a text file and writes its contents into another file, converting all uppercase 
letters to lowercase.
Requirements: Use StreamReader and StreamWriter. Use BufferedStream for efficiency. Handle character encoding issues. */


using System.IO;
using System.Text;
namespace Streams
{
    public class TextFilter
{
    public static void ConvertUppertoLower(string input, string output)
    {
        using (FileStream readFs = new FileStream(input, FileMode.Open, FileAccess.Read))
        using (BufferedStream bufferedRead = new BufferedStream(readFs))
        using (StreamReader reader = new StreamReader(bufferedRead, Encoding.UTF8))

        using (FileStream writeFs = new FileStream(output, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedWrite = new BufferedStream(writeFs))
        using (StreamWriter writer = new StreamWriter(bufferedWrite, Encoding.UTF8))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());
            }
        }
    }
}
}
