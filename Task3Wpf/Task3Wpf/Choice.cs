using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Wpf
{
    public class Choice
    {
        public static void Input()
        {
            string mode = MainWindow.Instance.InputB.Text;
            string easy = "easy";
            string med = "med";
            string hard = "hard";

            if (mode == easy)
            {
                Easy.Begin();
            }

            if (mode == med)
            {
                Med.Begin();
            }

            if (mode == hard)
            {
                Hard.Begin();
            }
            else
            {
                Messages.WrongInput();
            }
        }
    }
}
