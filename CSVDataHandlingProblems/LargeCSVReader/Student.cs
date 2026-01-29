/* Read Large CSV File Efficiently
● Given a large CSV file (500MB+), implement a memory-efficient way to read it in chunks.
● Process only 100 lines at a time and display the count of records processed. */


using System;
namespace LargeCSVReader{
    public class Student{
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
