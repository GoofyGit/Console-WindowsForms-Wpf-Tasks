using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2WindowsForms
{
    public partial class Form1 : Form
    {
        List<people> info = new List<people>();

        public Form1()
        {
            InitializeComponent();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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
        }

        public void button1_Click(object sender, EventArgs e)
        {
            label6.Text = info[0].FirstName;
            label7.Text = info[0].LastName;
            label8.Text = info[0].Email;
            label9.Text = info[0].Phone;
            label10.Text = info[0].Address;

            label11.Text = info[1].FirstName;
            label12.Text = info[1].LastName;
            label13.Text = info[1].Email;
            label14.Text = info[1].Phone;
            label15.Text = info[1].Address;

            label16.Text = info[2].FirstName;
            label17.Text = info[2].LastName;
            label18.Text = info[2].Email;
            label19.Text = info[2].Phone;
            label20.Text = info[2].Address;

            label21.Text = info[3].FirstName;
            label22.Text = info[3].LastName;
            label23.Text = info[3].Email;
            label24.Text = info[3].Phone;
            label25.Text = info[3].Address;

            label26.Text = info[4].FirstName;
            label27.Text = info[4].LastName;
            label28.Text = info[4].Email;
            label29.Text = info[4].Phone;
            label20.Text = info[4].Address;
        }
    }
}
