/* Encrypt and Decrypt CSV Data
● Encrypt the sensitive fields (e.g., Salary, Email) while writing to a CSV file.
● Decrypt them when reading the file. */


using System;
using System.Collections.Generic;
using System.IO;

namespace EncryptDecrypt
{
    public class EmployeeMain
    {
        public static void Execute()
        {
            string filePath = "employees.csv";

            // Sample employees
            var employees = new List<Employee>
            {
                new Employee { Id=1, Name="Lucky", Department="HR", Email="lucky@example.com", Salary=50000 },
                new Employee { Id=2, Name="Abhay", Department="IT", Email="abhay@example.com", Salary=60000 }
            };

            // Write CSV with encrypted sensitive fields
            using (StreamWriter sw = new(filePath))
            {
                sw.WriteLine("Id,Name,Department,Email,Salary");
                foreach (var emp in employees)
                {
                    sw.WriteLine($"{emp.Id},{emp.Name},{emp.Department},{CryptoHelper.Encrypt(emp.Email)},{CryptoHelper.Encrypt(emp.Salary.ToString())}");
                }
            }

            // Read CSV and decrypt
            Console.WriteLine("Reading CSV with decrypted data:");
            using (StreamReader sr = new(filePath))
            {
                string header = sr.ReadLine(); // skip header
                while (!sr.EndOfStream)
                {
                    var parts = sr.ReadLine().Split(',');
                    var emp = new Employee
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Department = parts[2],
                        Email = CryptoHelper.Decrypt(parts[3]),
                        Salary = decimal.Parse(CryptoHelper.Decrypt(parts[4]))
                    };
                    Console.WriteLine($"{emp.Id} {emp.Name} {emp.Department} {emp.Email} {emp.Salary}");
                }
            }
        }
    }
}
