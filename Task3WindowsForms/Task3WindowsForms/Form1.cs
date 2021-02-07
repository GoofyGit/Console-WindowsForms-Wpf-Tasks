using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3WindowsForms
{
    public partial class Form1 : Form
    {
        public static int points = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
 
            List<string> easy = new List<string>();

            Random r = new Random();

            int winNum = r.Next(1, 5);

            bool win = false;

            for (int x = 0; x < 3; x++)
            {
                label1.Text = ("Please enter a int from 1 - 5");
                string s = textBox1.Text;

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
                    label1.Text = ("Wrong awnser");
                }
            }
            label1.Text = ($"You scored: {points} points.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> med = new List<string>();

            Random r = new Random();

            int winNum = r.Next(1, 5);

            bool win = false;

            for (int x = 0; x < 3; x++)
            {
                label1.Text = ("Please enter a int from 1 - 10");
                string s = textBox1.Text;

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
                    label1.Text = ("Wrong awnser");
                }
            }
            label1.Text = ($"You scored: {points} points.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> hard = new List<string>();

            Random r = new Random();

            int winNum = r.Next(1, 20);

            bool win = false;

            for (int x = 0; x < 3; x++)
            {
                label1.Text = ("Please enter a int from 1 - 20");
                string s = textBox1.Text;

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
                    label1.Text = ("Wrong awnser");
                }
            }
            label1.Text = ($"You scored: {points} points.");
        }
    }
}

