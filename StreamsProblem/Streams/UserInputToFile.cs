/* Read User Input from Console
Problem Statement: Write a program that asks the user for their name, age, and favorite programming language, then saves this 
information into a file.
Requirements: Use StreamReader for console input. Use StreamWriter to write the data into a file. Handle exceptions properly. */

using System;
using System.IO;
namespace Streams
{
    public class UserInputToFile{
    // Reads user input from console and saves it to a file (userInfo.txt is created automatically)
    public static void SaveUserInfo(string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                Console.Write("Enter your name: ");
                string name = reader.ReadLine();

                Console.Write("Enter your age: ");
                string age = reader.ReadLine();

                Console.Write("Enter your favorite programming language: ");
                string language = reader.ReadLine();

                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Favorite Language: " + language);
            }

            Console.WriteLine("User information saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}

}
