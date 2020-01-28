using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string country;

            do
            {
                Console.WriteLine("Enter your name:");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"));
            do
            {
                Console.WriteLine("Enter your country:");
                country = Console.ReadLine();
            } while (!Regex.IsMatch(country, @"^[a-zA-Z]+$/"));
            
            Console.WriteLine(" Hello " + name + " from country " + country);
            Console.Read();
        }
    }
}
