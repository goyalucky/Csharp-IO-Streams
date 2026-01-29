/*Sort CSV Records by a Column
● Read a CSV file and sort the records by Salary in descending order.
● Print the top 5 highest-paid employees. */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace SortApp
{
    public class SortMain
    {
        public static void Execute(){
            string filePath = "SortApp/employees.csv";
            try
            {
                ShowTopPaidEmployees(filePath, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Method to read CSV, sort by Salary descending, and print top N
        static void ShowTopPaidEmployees(string filePath, int topN){
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<dynamic>()
                 .Select(r => new
                                 {
                                     Id = r.Id,
                                     Name = r.Name,
                                     Department = r.Department,
                                     Salary = Convert.ToDecimal(r.Salary)
                                 })
                                 .OrderByDescending(r => r.Salary) // Sort descending
                                 .Take(topN)                        // Top N
                                 .ToList();
                                
                Console.WriteLine($"Top {topN} highest-paid employees:");
                Console.WriteLine("Id\tName\tDepartment\tSalary");

                foreach (var emp in records)
                {
                    Console.WriteLine($"{emp.Id}\t{emp.Name}\t{emp.Department}\t{emp.Salary}");
                }
            }
        }
    }
}
