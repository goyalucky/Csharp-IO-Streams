/* Detect Duplicates in a CSV File
● Read a CSV file and detect duplicate entries based on the ID column.
● Print all duplicate records. */

using System;
namespace DetectDuplicates{
    public class Student{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
}
}