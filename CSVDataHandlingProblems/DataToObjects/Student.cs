/* Convert CSV Data into Java Objects
● Read a CSV file and convert each row into a Student Java object.
● Store the objects in a List<Student> and print them. */


using System;

namespace DataToObjects{
    public class Student{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }
    public Student(int id, string name, int age, string course)
    {
        Id = id;
        Name = name;
        Age = age;
        Course = course;
    }
    public override string ToString()
    {
        return $"Student {{ Id={Id}, Name={Name}, Age={Age}, Course={Course} }}";
    }
}
}
