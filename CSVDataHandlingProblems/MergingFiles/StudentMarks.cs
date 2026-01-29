/* Merge Two CSV Files
● You have two CSV files:
○ students1.csv (contains ID, Name, Age)
○ students2.csv (contains ID, Marks, Grade)
● Merge both files based on ID and create a new file containing all details. */


using System;
namespace MergingFiles{
    public class StudentMarks
    {
        public int Id { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
    }    
}
