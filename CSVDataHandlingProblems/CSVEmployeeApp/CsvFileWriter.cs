/* Generate a CSV Report from Database
● Fetch employee records from a database and write them into a CSV file.
● Include headers: Employee ID, Name, Department, Salary. */


using System.IO;

namespace CSVEmployeeApp
{
    public class CsvFileWriter
    {
        public static void WriteCSV(string filePath, Employee[] employees)
        {
            using StreamWriter writer = new StreamWriter(filePath);

            writer.WriteLine("ID,Name,Department,Salary");

            foreach (Employee emp in employees)
            {
                writer.WriteLine($"{emp.ID},{emp.Name},{emp.Department},{emp.Salary}");
            }
        }
    }
}
