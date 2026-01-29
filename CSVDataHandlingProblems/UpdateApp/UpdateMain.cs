/*Modify a CSV File (Update a Value)
● Read a CSV file and increase the salary of employees from the "IT" department by 10%.
● Save the updated records back to a new CSV file. */

using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace UpdateApp
{
    public class UpdateMain{
        public static void Execute(){
            string inputFile = "UpdateApp/employees.csv";
            string outputFile = "employees_updated.csv";
            try
            {
                UpdateItSalaries(inputFile, outputFile);
                Console.WriteLine($"Updated salaries saved to '{outputFile}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Method to increase salary of IT employees by 10% and save to new CSV
        static void UpdateItSalaries(string inputFile, string outputFile)
        {
            // Read all records first
            using (var reader = new StreamReader(inputFile))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<dynamic>();
                var updatedRecords = new System.Collections.Generic.List<dynamic>();

                foreach (var record in records)
                {
                    string department = record.Department;
                    decimal salary = Convert.ToDecimal(record.Salary);

                    if (department.Equals("IT", StringComparison.OrdinalIgnoreCase))
                    {
                        salary = salary * 1.10m; // increase by 10%
                        record.Salary = salary;
                    }
                    updatedRecords.Add(record);
                }

                // Write updated records to new CSV
                using (var writer = new StreamWriter(outputFile))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteHeader<dynamic>();
                    csvWriter.NextRecord();

                    foreach (var record in updatedRecords)
                    {
                        csvWriter.WriteRecord(record);
                        csvWriter.NextRecord();
                    }
                }
            }
        }
    }
}
