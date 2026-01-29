/* Read and Count Rows in a CSV File
Read a CSV file and count the number of records (excluding the header row). */

using System;

namespace CSVCountApp
{
    public class CountMain
    {
        public static void Execute(){
            try
            {
                int count = Service.CountRecords(@"CSVCountApp\data.csv");
                Console.WriteLine($"Number of records: {count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
