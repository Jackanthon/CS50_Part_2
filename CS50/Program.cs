using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();
        }
        public static void Menu()
        {
            Console.Write("Menu: ");
            string userChoice = Console.ReadLine();
            Console.WriteLine();
            if (userChoice == "Mario") { Week1.Pryamid(); }
            if (userChoice == "Cash") { Week1.Cash(); }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
//if some customer is owed $9.75 (as in the case where a newspaper costs 25¢ but the customer pays
//with a $10 bill), assume that your program’s input will be 9.75
