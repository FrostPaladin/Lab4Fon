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
using System.Windows.Shapes;

namespace Lab_4
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            string n = Count.Text;
            int enter = Convert.ToInt32(n);
            for (int i = 0; i <= enter; i++)
            {
                result = result + i;
            }
            ResultL.Content = ("Сумма: " + result);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            Close();
        }

        private void Count_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
