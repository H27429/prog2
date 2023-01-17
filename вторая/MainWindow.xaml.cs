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

namespace peremennie2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // ЗАДАНИЕ Н1
            //  bool working = true;
            //  var hello = "hello";
            // int age = 555;
            // decimal money = 100000;
            // long h = 0b101;
            // float b = -1045;
            // char e = 'e';
            // string str = "str";
            // float f = -1045;
            // double km = 35.6;

            // ЗАДАНИЕ Н3
            int photo = 52;
            int photoinrow = 3;
            int fullrow = photo / photoinrow;
            full.Content = fullrow;
            int overflow = photo % photoinrow;
            over.Content = overflow;

            // ЗАДАНИЕ Н4

            

        }

        // ЗАДАНИЕ Н4

        double gold = 0;
        int cristal = 0;

        private void shop_Click(object sender, RoutedEventArgs e)
        {
            int cristal = 0;
            double gold = Convert.ToInt32(gold1.Text);
            if(gold>100)
            {
                gold -= 109;
                cristal += 10;
                cristall.Content = $"Количество кристалов : {cristal}";
                cristall.Background = Brushes.Aqua;
                gold1.Text = $"{gold}";

            }
            else
            {
                gold1.Text = "Не хватает средств для покупки :(";
                gold1.Foreground = Brushes.BlueViolet;
            }
        }
        // ЗАДАНИЕ Н5

        private void yourTime_Click(object sender, RoutedEventArgs e)
        {
            int people = Convert.ToInt32(peoplee.Text);
            try
            {
                otvet.Content = $"Вы отстоите в очереди {people * 10 / 60 } часов {people * 10 % 60} минут";
                otvet.Foreground = Brushes.Chocolate;
            }
            catch
            {

            }
        }
        // ЗАДАНИЕ Н6
        private void otvet2_Click(object sender, RoutedEventArgs e)
        {
            L.Content = (name.Text, age.Text, zodiak.Text, work.Text);
        }






    }
}
