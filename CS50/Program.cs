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
            Console.Write("Menu $");
            string userChoice = Console.ReadLine();
            Console.WriteLine();
            if (userChoice == "Week1") { Week1.Pryamid(); }
            
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
//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
