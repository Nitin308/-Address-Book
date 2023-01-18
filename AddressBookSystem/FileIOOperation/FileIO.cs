using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Part2.FileIOOperation
{
    internal class FileIO
    {
        /// <summary>
        /// Write all the details in File
        /// </summary>
        public static void WriteRecordsInFile(string path, PersonInput person)
        {

            if (Program.IsFileExists(path))
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine("\nFirst Name : " + person.First_Name);
                sw.WriteLine("Last Name : " + person.Last_Name);
                sw.WriteLine("Address : " + person.Address);
                sw.WriteLine("City : " + person.City);
                sw.WriteLine("State : " + person.State);
                sw.WriteLine("Email : " + person.Email);
                sw.WriteLine("Zip code : " + person.Zip);
                sw.WriteLine();
                sw.Close();
                Console.WriteLine("\nData added successfully in file");
            }
        }
        /// <summary>
        /// Read all records from which are present in Files
        /// </summary>
        public static void ReadRecordsFromFile(string path)
        {
            if (Program.IsFileExists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}