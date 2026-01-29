// Read a JSON file and extract only specific fields (e.g., name, email).


using System;
using System.IO;
using System.Text.Json;
namespace JSONProblems
{
// User class for extracting fields
public class User{
    // Stores user's name from JSON
    public string name { get; set; }

    // Stores user's email from JSON
    public string email { get; set; }
}

public class ReadSpecificFields{
    public static void Execute(){
        // path of the JSON file
        string filePath = "user.json";

        // read entire JSON file as string
        string jsonData = File.ReadAllText(filePath);

        // convert JSON data into User object
        User user = JsonSerializer.Deserialize<User>(jsonData);

        // print only required fields
        Console.WriteLine("Name- " + user.name);
        Console.WriteLine("Email- " + user.email);
    }
}
}

