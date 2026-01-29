using System.Globalization;
using System.IO;
using CsvHelper;

namespace CSVCountApp
{
    public class Service
    {
        public static int CountRecords(string filePath)
        {
            int count = 0;
            using(var reader = new StreamReader(filePath))
            using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Read header
                csv.Read();
                csv.ReadHeader();

                // Count each remaining row
                while (csv.Read())
                {
                    count++;
                }
            }
            return count;
        }
    }
}
