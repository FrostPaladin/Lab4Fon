using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using System.Windows.Shapes;

namespace Lab_4
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void InputBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            int year;
            double money;
            string input = InputBox.Text;
            string input2 = MoneyBox.Text;
            year = int.Parse(input);
            money = int.Parse(input2);
            if (year < 5)
            {
                money = money * 0.1;
                ResultL.Content = ("Ваша премия составит 10% от зарплаты " + money);
            }
            else if (year >= 5 && year < 10)
            {
                money = money * 0.15;
                ResultL.Content = ("Ваша премия составит 15% от зарплаты " + money);
            }
            else if (year >= 10 && year < 15)
            {
                money = money * 0.25;
                ResultL.Content = ("Ваша премия составит 25% от зарплаты " + money);
            }
            else if (year >= 15 && year < 20)
            {
                money *= 0.35;
                ResultL.Content = ("Ваша премия составит 35% от зарплаты " + money);
            }
            else if (year >= 20 && year < 25)
            {
                money *= 0.45;
                ResultL.Content = ("Ваша премия составит 45% от зарплаты " + money);
            }
            else if ( year >= 25)
            {
                money *= 0.5;
                ResultL.Content = ("Ваша премия составит 50% от зарплаты " + money);
            }
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
