using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Wpf
{
    public class Easy
    {
        public static int points = 0;

        public static void Begin()
        {
            List<string> easy = new List<string>();

            Random r = new Random();

            int winNum = r.Next(1, 5);

            bool win = false;

            for (int x = 0; x < 3; x++)
            {
                MainWindow.Instance.label1.Content = ("Please enter a int from 1 - 5");
                string s = MainWindow.Instance.InputB.Text;

                int i = int.Parse(s);

                if (i == winNum)
                {
                    MainWindow.Instance.label1.Content = ("correct");
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
                    MainWindow.Instance.label1.Content = ("Wrong awnser");
                }

            }

            MainWindow.Instance.label1.Content = ($"You scored: {points} points.");
        }
    }
}
