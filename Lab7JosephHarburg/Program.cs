using System;
using System.Text.RegularExpressions;

namespace Lab7JosephHarburg
{
    class Program
    {
        static void Main(string[] args)
        {
            Name();
            Email();
            Phone();
            Date();
        }
        public static void Name()
        {
            Console.WriteLine("Please enter your name!");
            string nameInput = Console.ReadLine();
            Match nameValidate = Regex.Match(nameInput, "(^[A-Z][a-z]{1,30})");
            if (nameValidate.Success)
            {
                Console.WriteLine($"Hello {nameInput}!");
            }
            else
            {
                Console.WriteLine("Im sorry thats not a valid name!");
            }
        }

        public static void Email()
        {
            Console.WriteLine("Please enter your email!");
            string emailInput = Console.ReadLine();
            Match emailValidate = Regex.Match(emailInput, @"([A-Za-z0-9]{5,30}@{1}[A-Za-z0-9]{5,10}\.{1}[A-Za-z0-9]{2,3}$)");
            if (emailValidate.Success)
            {
                Console.WriteLine($"Your Email is {emailInput}!");
            }
            else
            {
                Console.WriteLine("Im sorry thats not a valid email!");
            }
        }
        public static void Phone()
        {
            Console.WriteLine("Please enter your Phone Number!");
            string phoneInput = Console.ReadLine();
            Match phoneValidate = Regex.Match(phoneInput, @"(^(\d\d\d)-(\d\d\d)-(\d\d\d\d)$)");
            if (phoneValidate.Success)
            {
                Console.WriteLine($"Your Phone Number is {phoneInput}!");
            }
            else
            {
                Console.WriteLine("Im sorry thats not a valid phone number!");
            }
        }

        public static void Date()
        {
            Console.WriteLine("Please enter a date!");
            string dateInput = Console.ReadLine();
            Match dateValidate = Regex.Match(dateInput, @"(^\d\d/{1}\d\d/{1}\d\d\d\d$)");
            bool isDate = DateTime.TryParse(dateInput, out DateTime Datevalidated);

            if (dateValidate.Success && isDate == true)
            {
                Console.WriteLine($"The date you wrote is {dateInput}!");
            }
            else
            {
                Console.WriteLine("Im sorry thats not a valid date!");
            }
        }
    }
}
