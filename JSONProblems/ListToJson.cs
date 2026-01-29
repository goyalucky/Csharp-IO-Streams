// Convert a list of C# objects into a JSON array.

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace JSONProblems
{
    // Student class
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class ListToJson
    {
        public static void Execute(){
            // Create a list of C# objects
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Prashant", Age = 21 },
                new Student { Id = 2, Name = "Aman", Age = 22 }
            };

            // Convert list to JSON array
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonArray = JsonSerializer.Serialize(students, options);
            Console.WriteLine(jsonArray);
        }
    }
}
