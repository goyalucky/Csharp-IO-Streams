// Parse JSON and filter only those records where age > 25.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace JSONProblems{
    // Model class
    public class Person{
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class FilterJsonByAge{
        public static void Execute(){
            string jsonData = @"
            [
                { ""Name"": ""Prashant"", ""Age"": 21 },
                { ""Name"": ""Aman"", ""Age"": 26 },
                { ""Name"": ""Rohit"", ""Age"": 30 }
            ]";

            // Parse JSON into List<Person>
            List<Person> people = JsonSerializer.Deserialize<List<Person>>(jsonData);

            // Filter records where Age > 25
            var filteredPeople = people.Where(p => p.Age > 25).ToList();

            // Convert filtered result back to JSON
            string resultJson = JsonSerializer.Serialize(filteredPeople, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            Console.WriteLine(resultJson);
        }
    }
}
