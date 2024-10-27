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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a;
            int b;
            string textBox1 = numberOne.Text;
            string textBox2 = nubmerTwo.Text;
            a = Convert.ToInt32(textBox1);
            b = Convert.ToInt32(textBox2);
            int summ = 0;
            for (int i = a + 1; i < b; i++)
            {
                summ += i;
            }
            ResultL.Content = ("Сумма равна:  " + summ);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a;
            int b;
            string result = "";
            string textBox1 = numberOne.Text;
            string textBox2 = nubmerTwo.Text;
            a = Convert.ToInt32(textBox1);
            b = Convert.ToInt32(textBox2);
            if (a % 2 == 0)
                if (a > 0)
                    a++;
                else
                    a--;
            for (int i = a; i <= b; i += 2)
                result = result + i + " ";
            ResultL.Content = ("Нечётные числа:  " + result);
        }

        private void nubmerTwo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
