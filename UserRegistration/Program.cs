using System;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User registration validator program");
        }
        public static bool NameCheck(string name)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return Regex.IsMatch(name, pattern);
        }
        public static bool EmailCheck(string eMail)
        {
            string pattern = "^[a-z]{2,}[-.+]?[a-z]*[0-9]*[@][a-z]*[0-9]*[.][a-z]{2,3}[.]{0,1}[a-z]{0,3}$";
            return Regex.IsMatch(eMail, pattern);
        }
        public static bool PhoneNumberCheck(string number)
        {
            string pattern = "^[9][1][ ][6-9][0-9]{9}$";
            return Regex.IsMatch(number, pattern);
        }
        public static bool PasswordCheck(string password)
        {
            string pattern = "^.*[!@#$%^&*,.-_][0-9]*.*$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
