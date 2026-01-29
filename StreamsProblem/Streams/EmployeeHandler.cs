/* Serialization - Save and Retrieve an Object
Problem Statement: Design a C# program that allows a user to store a list of employees in a file using Object Serialization 
and later retrieve the data from the file.
Requirements: Create an Employee class with fields: id, name, department, salary. Serialize the list of employees into 
a file (BinaryFormatter / JSON Serialization). Deserialize and display the employees from the file. Handle exceptions properly. */


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; // JSON serialization

namespace Streams
{
    public static class EmployeeHandler
{
    private static string filePath = @"D:\Csharp-IO-Streams\FileHandling\employees.json";

    // Serialize list of employees to file
    public static void SaveEmployees(List<Employee> employees)
    {
        try
        {
            string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    // Deserialize and return list of employees from file
    public static List<Employee> LoadEmployees()
    {
        try
        {
            if (!File.Exists(filePath)) return new List<Employee>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Employee>>(json);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
            return new List<Employee>();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return new List<Employee>();
        }
    }
}

}
