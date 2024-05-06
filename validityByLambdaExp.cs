using System;
using System.Text.RegularExpressions;

namespace AddressBook
{
    public class ValiditybyLambdaexp
    {
        private string NamePattern { get; } = @"^[A-Z][a-z]{2,9}$";
        private string EmailPattern { get; } = @"^\w{3,}([.+-]\w{1,})?@\w{1,}.[a-z]{1,}(.[a-z]{1,})?$";
        private string NumberPattern { get; } = @"^[0-9]{1,3}\s[0-9]{10}$";
        private string ZipCodePattern { get; } = @"^\d{6}$";

        public bool IsName(string name) =>
            Regex.IsMatch(name, NamePattern) ? true : ThrowErrorMessage("INVALID FIRST NAME");

        public bool IsEmail(string email) =>
            Regex.IsMatch(email, EmailPattern) ? true : ThrowErrorMessage("INVALID EMAIL ID");

        public bool IsNumber(string number) =>
            Regex.IsMatch(number, NumberPattern) ? true : ThrowErrorMessage("INVALID PHONE NUMBER");

        public bool IsZipCode(string zipcode) =>
            Regex.IsMatch(zipcode, ZipCodePattern) ? true : ThrowErrorMessage("Invalid ZIPCODE");

        private bool ThrowErrorMessage(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            return false;
        }
    }
}
