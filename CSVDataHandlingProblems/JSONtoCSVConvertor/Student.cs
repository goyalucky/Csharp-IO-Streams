/* Convert JSON to CSV and Vice Versa
● Read a JSON file containing a list of students.
● Convert it into CSV format and save it.
● Implement another method to read CSV and convert it back to JSON. */

using System;
namespace JSONtoCSVConvertor
{
    public class Student{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
}
}