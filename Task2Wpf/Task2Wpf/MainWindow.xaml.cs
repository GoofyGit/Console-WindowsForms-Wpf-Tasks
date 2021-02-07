using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<people> info = new List<people>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void fillLabels()
        {
            label6.Content = info[0].FirstName;
            label7.Content = info[0].LastName;
            label8.Content = info[0].Email;
            label9.Content = info[0].Phone;
            label10.Content = info[0].Address;

            label21.Content = info[1].FirstName;
            label22.Content = info[1].LastName;
            label23.Content = info[1].Email;
            label24.Content = info[1].Phone;
            label25.Content = info[1].Address;

            label26.Content = info[2].FirstName;
            label27.Content = info[2].LastName;
            label28.Content = info[2].Email;
            label29.Content = info[2].Phone;
            label30.Content = info[2].Address;

            label31.Content = info[3].FirstName;
            label32.Content = info[3].LastName;
            label33.Content = info[3].Email;
            label34.Content = info[3].Phone;
            label35.Content = info[3].Address;

            label36.Content = info[4].FirstName;
            label37.Content = info[4].LastName;
            label38.Content = info[4].Email;
            label39.Content = info[4].Phone;
            label40.Content = info[4].Address;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            people person1 = new people("Leanne", "Graham", "Sincere@april.biz", "1-770-736-8031 x56442", "Kulas Light, Gwenborough");
            people person2 = new people("Ervin ", "Howell", "Shanna@melissa.tv", "010-692-6593 x09125", "Victor Plains, Wisokyburgh");
            people person3 = new people("Clementine ", "Bauch", "Nathan@yesenia.net", "1-463-123-4447", "Douglas Extension, McKenziehaven");
            people person4 = new people("Patricia ", "Lebsack", "Julianne.OConner@kory.org", "493-170-9623 x156", "Hoeger Mall, South Elvis");
            people person5 = new people("Chelsey ", "Dietrich", "Lucio_Hettinger@annie.ca", "(254)954-1289", "Skiles Walks, Roscoeview");
            info.Add(person1);
            info.Add(person2);
            info.Add(person3);
            info.Add(person4);
            info.Add(person5);
            fillLabels();
        }
    }
}
