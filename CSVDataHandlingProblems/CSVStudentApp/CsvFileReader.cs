/* Read a CSV File and Print Data
● Read a CSV file containing student details (ID, Name, Age, Marks).
● Print each record in a structured format. */


using System;
using System.IO;

namespace CSVStudentApp
{
    public class CsvFileReader
    {
        // Reads CSV file and returns Student array
        public static Student[] ReadCSV(string filePath){
             // Read all lines from CSV
            string[] lines = File.ReadAllLines(filePath);
            
            Student[] students = new Student[lines.Length - 1];
            
            for(int i = 1; i < lines.Length; i++){
                string[] data = lines[i].Split(',');

                 // Assign values to Student object
                students[i - 1] = new Student
                {
                    ID = int.Parse(data[0]),
                    Name = data[1],
                    Age = int.Parse(data[2]),
                    Marks = int.Parse(data[3])
                };
            }
            return students;
        }
    }
}
