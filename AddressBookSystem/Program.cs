using AddressBookSystem_Part2.CSVIOOperation;
using AddressBookSystem_Part2.FileIOOperation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\DELL\source\repos\AddressBookSystem_UC13_FileIO\AddressBookSystem_UC13_FileIO\MyFiles\Records.txt";
            string path = @"C:\Users\DELL\source\repos\AddressBookSystem_Part2\AddressBookSystem_Part2\MyFiles\RecordsInCSVFormat.csv";
            PersonInput input = new PersonInput();
            //Getting details from user
            Console.WriteLine("\nEnter your First Name : ");
            input.First_Name = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.Last_Name = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.Address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.City = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.State = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            input.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.Email = Console.ReadLine();

            //Read or Write Operation in Text Files
            //FileIO.WriteRecordsInFile(path,input); // Writing records into file
            //Console.WriteLine("\n\nRecords present in Text file are : ");
            //FileIO.ReadRecordsFromFile(path); // Reading all records from file 
            //Console.ReadLine();

            ///Read and Write Operation in CSV Files
            CSVOperations.WriteRecordsInCSVFile(path, input);
            Console.WriteLine("\n\nRecords present in CSV file are : \n");
            CSVOperations.ReadRecordsInCSVFile(path);
            Console.ReadLine();
        }
        /// <summary>
        /// Checking that File is Present or not
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool IsFileExists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                Console.WriteLine("File Not Found");
                return false;
            }
        }
    }
}