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
            string card = "4003600000000014";
            int[] cardArr = new int[card.Length];
            var counter1 = 0;
            var counter2 = 0;
            for (int i = 0; i < card.Length; i++)
            {
                if (i % 2 != 0)
                {
                    cardArr[i] *= 2;
                }
            }

            Menu();
            Console.ReadLine();
        }
        public static void Menu()
        {
            Console.Write("Menu: ");
            string userChoice = Console.ReadLine();
            if (userChoice == "ls") { Console.WriteLine("Mario\nCash"); Menu(); }
            if (userChoice == "Mario" || userChoice == "mario") { Week1.Pryamid(); }
            if (userChoice == "Cash" || userChoice == "cash") { Week1.Cash(); }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
