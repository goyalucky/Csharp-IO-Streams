/* Read a CSV File and Print Data
● Read a CSV file containing student details (ID, Name, Age, Marks).
● Print each record in a structured format. */


using System.IO;

namespace CSVStudentApp
{
    public class Student
    {
        public int ID{get;set;}
        public string Name{get;set;}
        public int Age{get;set;}
        public int Marks{get;set;}
        public void Display()
        {
            Console.WriteLine($"{ID}\t{Name}\t{Age}\t{Marks}");
        }
    }
}