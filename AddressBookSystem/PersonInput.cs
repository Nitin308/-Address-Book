using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Part2
{
    internal class PersonInput
    {
        // Declaring class variable to get the all the details from user
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }

        /// <summary>
        /// To string method to write details in Console
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"First Name : {First_Name}\nLast Name : {Last_Name}\nAddress : {Address}\nCity : {City}\nState : {State}\nEmail : {Email}\nZip Code : {Zip}\nPhone Number : {PhoneNumber}";
        }
    }
}