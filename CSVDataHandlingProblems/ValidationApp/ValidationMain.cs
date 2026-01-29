/* ️Validate CSV Data Before Processing
● Ensure that the "Email" column follows a valid email format using regex.
● Ensure that "Phone Numbers" contain exactly 10 digits.
● Print any invalid rows with an error message. */


using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using CsvHelper;

namespace ValidationApp
{
    public class ValidationMain
    {
        public static void Execute(){
            string filePath = "ValidationApp/users.csv";
            try
            {
                ValidateCsvData(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ValidateCsvData(string filePath)
        {
            // Regex patterns
            Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            Regex phoneRegex = new Regex(@"^\d{10}$");

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();

                Console.WriteLine("Invalid Records Found:\n");

                bool hasInvalid = false;

                while (csv.Read())
                {
                    string id = csv.GetField("Id");
                    string name = csv.GetField("Name");
                    string email = csv.GetField("Email");
                    string phone = csv.GetField("Phone");

                    bool isValid = true;
                    string errorMessage = "";

                    if (!emailRegex.IsMatch(email))
                    {
                        isValid = false;
                        errorMessage += "Invalid Email format; ";
                    }

                    if (!phoneRegex.IsMatch(phone))
                    {
                        isValid = false;
                        errorMessage += "Phone number must be exactly 10 digits; ";
                    }

                    if (!isValid)
                    {
                        hasInvalid = true;
                        Console.WriteLine($"Id: {id}, Name: {name}, Email: {email}, Phone: {phone}");
                        Console.WriteLine($"Error: {errorMessage}\n");
                    }
                }

                if (!hasInvalid)
                {
                    Console.WriteLine("All records are valid");
                }
            }
        }
    }
}
