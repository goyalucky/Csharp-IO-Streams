// Convert a C# object (Car class) into JSON format.


using System;
using System.Text.Json;
namespace JSONProblems{
    // Car class represents the structure of a car object
public class Car{
    // Brand name of the car
    public string Brand { get; set; }

    // Model name of the car
    public string Model { get; set; }

    // Manufacturing year of the car
    public int Year { get; set; }
}

public class CarToJson {
    public static void Execute()
    {
        // Create and initialize a Car object
        Car car = new Car
        {
            Brand = "Toyota",
            Model = "Fortuner",
            Year = 2023
        };

        // Convert the Car object into JSON format
        // WriteIndented = true makes the JSON human-readable
        string json = JsonSerializer.Serialize(
            car,
            new JsonSerializerOptions { WriteIndented = true }
        );
        Console.WriteLine(json);
    }
}
}
