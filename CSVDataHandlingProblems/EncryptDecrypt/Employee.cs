/* Encrypt and Decrypt CSV Data
● Encrypt the sensitive fields (e.g., Salary, Email) while writing to a CSV file.
● Decrypt them when reading the file. */


using System;
namespace EncryptDecrypt
{
    public class Employee{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Email { get; set; } 
    public decimal Salary { get; set; } 
    }
}