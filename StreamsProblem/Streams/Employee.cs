/* Serialization - Save and Retrieve an Object
Problem Statement: Design a C# program that allows a user to store a list of employees in a file using Object Serialization 
and later retrieve the data from the file.
Requirements: Create an Employee class with fields: id, name, department, salary. Serialize the list of employees into 
a file (BinaryFormatter / JSON Serialization). Deserialize and display the employees from the file. Handle exceptions properly. */


using System;
namespace Streams
{
[Serializable]
public class Employee    //Employee class to store details
{
    public int Id {get;set;}
    public string Name {get;set;}
    public string Department{get;set;}
    public int Salary{get;set;}

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Dept: {Department}, Salary: {Salary}";
    }
}
}
