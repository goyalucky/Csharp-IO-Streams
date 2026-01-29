using System;
using System.IO;

namespace Streams
{
    public class StreamsMain{
    public static void Start()
    {
            // Create sample employees
            var employees = new List<Employee>
            {
                new Employee { Id = 101, Name = "lucky Goyal", Department = "IT", Salary = 75000 },
                new Employee { Id = 102, Name = "abhay singh", Department = "HR", Salary = 65000 },
                new Employee { Id = 103, Name = "rishabh tiwari", Department = "Finance", Salary = 70000 }
            };

            // Save employees to file
            EmployeeHandler.SaveEmployees(employees);

            // Load employees from file
            var loadedEmployees = EmployeeHandler.LoadEmployees();

            Console.WriteLine("Employees loaded from file:");
            foreach (var emp in loadedEmployees)
            {
                Console.WriteLine(emp);
            }


            // PipeHandler.StartPipeCommunication();


            /* string filePath = @"D:\Csharp-IO-Streams\FileHandling\Streams\sample.txt";
            try
            {
                WordCounter.CountTopWords(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            } */


            /* string filePath = @"D:\Csharp-IO-Streams\FileHandling\Streams\largefile.txt";
            try
            {
                ErrorLineReader.PrintErrorLines(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }*/


            /* string filePath = @"D:\Csharp-IO-Streams\FileHandling\student.dat";
            try
            {
                // Store student details
                StudentDataHandler.WriteStudent(filePath, 101, "Lucky Goyal", 8.7);

                // Retrieve student details
                StudentDataHandler.ReadStudent(filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            } */


            /* string inputfile = @"D:\Csharp-IO-Streams\FileHandling\Streams\input.txt";
            string outputfile =  @"D:\Csharp-IO-Streams\FileHandling\Streams\output.txt";
            try
            {
                TextFilter.ConvertUppertoLower(inputfile,outputfile);
                Console.WriteLine("UpperCase converted to lower case successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            } */


        /* string originalFile = "original.jpg";
        string newFile = "copy.jpg";
        try
        {
            // Convert image to byte array
            byte[] bytes = ImageHelper.ImageToByteArray(originalFile);

            // Write byte array back to new image
            ImageHelper.ByteArrayToImage(bytes, newFile);

            // Verify the files
            bool identical = ImageHelper.AreFilesIdentical(originalFile, newFile);
            Console.WriteLine(identical ? "Files are identical!" : "Files differ!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        } */


        // UserInputToFile.SaveUserInfo("userInfo.txt");


        /* UnbufferedFileCopy.CopyFile(@"Streams\largefile.dat",@"Streams\unbuffered_copy.dat");
        BufferedFileCopy.CopyFile(@"Streams\largefile.dat",@"Streams\buffered_copy.dat"); */


        // FileCopy.CopyTextFile(@"Streams\source.txt", @"Streams\dest.txt");
    }
    }    
}
