using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Validation
    {
        //pattern to match First name where 1st letter is caps and next 2 to 9 letters are small
        private string NamePattern { get; set; } = @"^[A-Z][a-z]{2,9}$";

        private string EmailPattern { get; set; } = @"^\w{3,}([.+-]\w{1,})?@\w{1,}.[a-z]{1,}(.[a-z]{1,})?$";

        private string NumberPattern { get; set; } = @"^[0-9]{1,3}\s[0-9]{10}$";

        private string ZipCodePattern { get; set; } = @"^\d{6}$";

        //refactoring code of email
       
        public bool IsName(string name)
        {
            if (Regex.IsMatch(name, NamePattern))
            {
                Console.WriteLine("valid first OR last name");
                return true;
            }
            else
            {
                Console.WriteLine("INVALID FIRST NAME");
                return false;
            }
        }

        public bool IsEmail(string email)
        {
            if (Regex.IsMatch(email, EmailPattern)) return true;
            else
            {
                Console.WriteLine("INVALID EMAIL ID ");
                return false;
            }
        }

        public bool IsNumber(string number)
        {
            if (Regex.IsMatch(number, NumberPattern))
            return true;
            else
            { 
            Console.WriteLine("INVALID PHONE NUMBER ");
            return false;
            }
        }
        
        public bool IsZipCode(string zipcode
            )
        {
            if (Regex.IsMatch(zipcode, ZipCodePattern)) return true;
            else
            {
                Console.WriteLine("Invalid ZIPCODE");
                return false;
            }
        }
    }
}