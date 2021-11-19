using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50
{
    class Week1
    {
        public static void Pryamid()
        {
            Console.WriteLine("Choose a height between 1-20");
            Console.Write("Height: ");
            try
            {
                int h = Convert.ToInt32(Console.ReadLine());
                if (h >= 1 && h <= 20)
                {
                    Console.Write("\n");
                    for (int i = 1; i <= h; i++)
                    {
                        string pyramid = new string('#', i);
                        string space = new string(' ', h - i);
                        Console.WriteLine(space + pyramid + "  " + pyramid);
                    }
                }
                else
                {
                    Week1.Pryamid();
                }
            }
            catch(Exception)
            {
                Week1.Pryamid();
            }
            Program.Menu();
        }
        public static void Cash()
        {
            Console.WriteLine("Total");
            decimal total = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Amount received");
            decimal customer = Convert.ToDecimal(Console.ReadLine());
            total = customer - total;
            bool changeDue = false;
            if (total > 0)
            {
                changeDue = true;
                Console.Write("Change: $" + (total) + "\n");

                int coin = 0;
                while (total > 0)
                {
                    if (total - 0.25m >= 0)
                    {
                        total -= .25m;
                        coin++;
                    }
                    else if (total - 0.10m >= 0)
                    {
                        total -= .10m;
                        coin++;
                    }
                    else if (total - 0.05m >= 0)
                    {
                        total -= .05m;
                        coin++;
                    }
                    else if (total - 0.01m >= 0)
                    {
                        total -= .01m;
                        coin++;
                    }
                }
                Console.WriteLine("Total coins: " + coin);
            }
            Program.Menu();
        }
    }
}
