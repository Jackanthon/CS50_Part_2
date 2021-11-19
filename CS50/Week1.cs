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
    }
}
