// Create a JSON object for a Student with fields: name, age, and subjects(array).


using System;
using System.Collections.Generic;
using System.Text.Json;
namespace JSONProblems {
// Student class represents the structure of a Student object
public class Student
{
    // Stores the student's name
    public string Name { get; set; }

    // Stores the student's age
    public int Age { get; set; }

    // Stores the list of subjects studied by the student
    public List<string> Subjects { get; set; }
}

public class StudentJson{
    public static void Execute()
    {
        // Creating and initializing a Student object
        Student student = new Student
        {
            Name = "Prashant",
            Age = 21,
            Subjects = new List<string> 
            { 
                "Math", 
                "Physics", 
                "Computer Science" 
            }
        };

        // Convert Student object into JSON formatted string
        // WriteIndented = true makes the JSON output easy to read
        string json = JsonSerializer.Serialize(
            student,
            new JsonSerializerOptions { WriteIndented = true }
        );
        // Display the generated JSON on the console
        Console.WriteLine(json);
    }
}
}
