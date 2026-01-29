/* Data Streams - Store and Retrieve Primitive Data
Problem Statement: Write a C# program that stores student details (roll number, name, GPA) in a binary file and retrieves it later.
Requirements: Use BinaryWriter to write primitive data. Use BinaryReader to read data. Ensure proper closing of resources. */

using System.IO;
namespace Streams
{
    public class StudentDataHandler
{
    //  Writes student details (roll no, name, GPA) to a binary file
    public static void WriteStudent(string filepath, int rollno,string name, double gpa)
    {
        // create a file and BinaryWriter to store primitive data
        using(FileStream fs = new FileStream(filepath,FileMode.Create))
        using(BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(rollno);
            writer.Write(name);
            writer.Write(gpa);
        }
    }
    //  Reads a student details from a binary file
    public static void ReadStudent(string filepath)
    {
        // open a file and BinaryReader to retrieve data
        using(FileStream fs = new FileStream(filepath, FileMode.Open))
        using(BinaryReader reader = new BinaryReader(fs))
        {
            // Read a data in same order as written
            int rollno = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();
        }
    }
}
}
