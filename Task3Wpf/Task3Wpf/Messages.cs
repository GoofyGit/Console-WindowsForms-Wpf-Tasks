using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Wpf
{
    public class Messages
    {
        public static void Menu()
        {

            MainWindow.Instance.label1.Content = ("Please type in choice: easy, med or hard");
            Choice.Input();

        }

        public static void WrongInput()
        {
            MainWindow.Instance.label1.Content = ("Please enter one of the choices.");
            Messages.Menu();
        }
    }
}
