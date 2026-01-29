/* Search for a Record in CSV
● Read an employees.csv file and search for an employee by name.
● Print their department and salary. */


using System;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace SearchApp
{
    public class SearchMain
    {
        public static void Execute(){
            string filePath = "SearchApp/employees.csv";

            Console.Write("enter employee name to search: ");
            string searchName = Console.ReadLine();

            try
            {
                SearchEmployee(filePath, searchName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Method to search employee by name and print department & salary
        static void SearchEmployee(string filePath, string name)
        {
            bool found = false;

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();       // Read first row
                csv.ReadHeader(); // Skip header

                while (csv.Read())
                {
                    string empName = csv.GetField("Name");
                    if (empName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        string department = csv.GetField("Department");
                        string salary = csv.GetField("Salary");

                        Console.WriteLine($"\nEmployee Found:\nName: {empName}\nDepartment: {department}\nSalary: {salary}");
                        found = true;
                        break; // Stop after first match
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"\nEmployee '{name}' not found.");
            }
        }
    }
}
