/* Convert CSV Data into Java Objects
● Read a CSV file and convert each row into a Student Java object.
● Store the objects in a List<Student> and print them. */


using System;
using System.Collections.Generic;
using System.IO;
namespace DataToObjects
{
    public class StudentsMain{
    public static void Execute(){
        string filePath = "DataToObjects/students.csv";
        List<Student> students = new List<Student>();
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                reader.ReadLine(); // Skip header

                while ((line = reader.ReadLine()) != null){
                    string[] data = line.Split(',');

                    int id = int.Parse(data[0]);
                    string name = data[1];
                    int age = int.Parse(data[2]);
                    string course = data[3];

                    students.Add(new Student(id, name, age, course));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading CSV file: " + ex.Message);
        }

        // Print students
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}
}
