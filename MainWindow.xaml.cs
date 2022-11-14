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

namespace WPF_ZHITKOVA_PR4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Компьютер загадывает число случайным образом от 0 до N (N определяется в отдельном окне).Пользователь вводит число, пытаясь его угадать. Программа соответственно отвечает больше число, которое загадано, или меньше.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int n = 0;
            switch (n)
            {
                case 0:
                    if (n > 0) MessageBox.Show("Больше");
                    break;
                case 1:
                    if (n == 0) MessageBox.Show("Угадал!");
                    break;
                case 2:
                    if (n < 0) MessageBox.Show("Меньше");
                    break;
                default:
                    MessageBox.Show("Введено недопустимое значени или ничего не введено");
                    break;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            int A = rnd.Next(0, 5);
            chislo.Content = (A);
        }
    }
}
