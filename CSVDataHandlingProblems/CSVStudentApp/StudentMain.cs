/* Read a CSV File and Print Data
● Read a CSV file containing student details (ID, Name, Age, Marks).
● Print each record in a structured format. */

using System;
namespace CSVStudentApp
{
    public class StudentMain
    {
        public static void Start()
        {
            string filePath = "CSVStudentApp/students.csv";
            Student[] students = CsvFileReader.ReadCSV(filePath);

            Console.WriteLine("ID\tName\tAge\tMarks");
            foreach (var student in students)
            {
                student.Display();
            }
        }
    }
}