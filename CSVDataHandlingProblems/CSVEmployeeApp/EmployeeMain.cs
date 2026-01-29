/* Generate a CSV Report from Database
● Fetch employee records from a database and write them into a CSV file.
● Include headers: Employee ID, Name, Department, Salary. */


using System;

namespace CSVEmployeeApp
{
    public class EmployeeMain
    {
        public static void Start()
        {
            string filePath = @"CSVEmployeeApp\employees.csv";

            // Create employee records
            Employee[] employees =
            {
                new Employee { ID = 1, Name = "Lucky", Department = "IT", Salary = 60000 },
                new Employee { ID = 2, Name = "Rishabh", Department = "HR", Salary = 55000 },
                new Employee { ID = 3, Name = "Abhay", Department = "Finance", Salary = 65000 },
            };

            // Write data to CSV
            CsvFileWriter.WriteCSV(filePath, employees);

            Console.WriteLine("Employee data written to CSV file successfully.");
        }
    }
}
