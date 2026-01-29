/* Generate a CSV Report from Database
● Fetch employee records from a database and write them into a CSV file.
● Include headers: Employee ID, Name, Department, Salary. */

using System;

namespace CSVEmployeeApp
{
    public class Employee
    {
        public int ID;
        public string Name = "";
        public string Department = "";
        public double Salary;
    }
}
