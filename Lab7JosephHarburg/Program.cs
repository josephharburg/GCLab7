using System;
using System.Text.RegularExpressions;

namespace Lab7JosephHarburg
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Name();
                Email();
                Phone();
                Date();
                HtmlTags();
                Console.WriteLine("Do you want to try again?");
                string response = Console.ReadLine().ToLower();
                while (response != "y")
                {
                   
                    if (response != "y" && response != "n")
                    {
                        Console.WriteLine("Please enter a y or n");
                        response = Console.ReadLine().ToLower();
                    }
                    else if (response == "y")
                    {
                        Console.WriteLine("Great! Lets do it again!");
                        
                       
                    }
                    else if (response == "n")
                    {
                       Console.WriteLine("Thanks for using my program!");
                       response = "y";
                       repeat = false;
                        
                    }
                }
            }
        }
        public static void Name()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Please enter your name!");
                string nameInput = Console.ReadLine();
                Match nameValidate = Regex.Match(nameInput, "(^[A-Z][a-z]{1,30})");
                if (Regex.IsMatch(nameInput, "(^[A-Z][a-z]{1,30})"))
                {
                    Console.WriteLine($"Hello {nameInput}!");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Im sorry thats not a valid name!");
                    
                }
            }
        }

        public static void Email()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("\nPlease enter your email!");
                string emailInput = Console.ReadLine();
                Match emailValidate = Regex.Match(emailInput, @"([A-Za-z0-9]{5,30}@{1}[A-Za-z0-9]{5,10}\.{1}[A-Za-z0-9]{2,3}$)");
                if (emailValidate.Success)
                {
                    Console.WriteLine($"Your Email is {emailInput}!");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Im sorry thats not a valid email!");
                }
            }
        }
        public static void Phone()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("\nPlease enter your Phone Number!");
                string phoneInput = Console.ReadLine();
                Match phoneValidate = Regex.Match(phoneInput, @"(^([0-9]{3})-([0-9]{3})-([0-9]{4})$)");
                if (phoneValidate.Success)
                {
                    Console.WriteLine($"Your Phone Number is {phoneInput}!");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Im sorry thats not a valid phone number!");
                }
            }
        }

        public static void Date()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("\nPlease enter a date!");
                string dateInput = Console.ReadLine();
                Match dateValidate = Regex.Match(dateInput, @"((0[1-9]|1[0-9]|2[0-9]|3[0-1]){1}/{1}(0[1-9]|1[0-2]){1}/{1}([0-9]){4}$)");
                if (dateValidate.Success)
                {
                    Console.WriteLine($"The date you wrote is {dateInput}!");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Im sorry thats not a valid date!");
                }
            }
        }
        public static void HtmlTags()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("\nPlease enter an html element!");
                string htmlInput = Console.ReadLine();
                Match htmlValidate = Regex.Match(htmlInput, @"((<[a-z]{1,5}[0-6]{0,1}>){1}[A-Za-z ]*(<{1}/{1}[a-z]{1,5}[0-6]{0,1}>)$)");


                if (htmlValidate.Success)
                {
                    Console.WriteLine($"The HTML Element you wrote is {htmlInput}!");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Im sorry thats not a valid html element!");
                }
            }
        }
    }
}
