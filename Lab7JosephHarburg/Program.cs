using System;
using System.Text.RegularExpressions;

namespace Lab7JosephHarburg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name();
            //Email();
            Phone();
        }
        public static void Name()
        {
            Console.WriteLine("Please enter your name!");
            string nameInput = Console.ReadLine();
            Match nameValidate = Regex.Match(nameInput, "(^[A-Z][a-z]{1,30})");
            if (nameValidate.Success)
            {
                Console.WriteLine($"Hello {nameInput}");
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
            Match emailValidate = Regex.Match(emailInput, "([A-Za-z0-9]{5,30}@{1}[A-Za-z0-9]{5,10}.{1}[A-Za-z0-9]{2,3}$)");
            if (emailValidate.Success)
            {
                Console.WriteLine($"Your Email is {emailInput}");
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
                Console.WriteLine($"Your Email is {phoneInput}");
            }
            else
            {
                Console.WriteLine("Im sorry thats not a valid phone number!");
            }
        }
    }
}
