using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Wpf
{
    public class Hard
    {
        public static int points = 0;

        public static void Begin()
        {
            List<string> easy = new List<string>();

            Random r = new Random();

            int winNum = r.Next(1, 20);

            bool win = false;

            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Please enter a int from 1 - 20");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i == winNum)
                {
                    Console.WriteLine("correct");
                    if (i == 0)
                    {
                        points += 10;
                    }
                    else if (i == 1)
                    {
                        points += 6;
                    }
                    else if (i == 2)
                    {
                        points += 2;
                    }
                    win = true;
                }
                else
                {
                    Console.WriteLine("Wrong awnser");
                }

            }

            Console.WriteLine($"You scored: {points} points.");

            Console.ReadLine();
        }
    }
}
