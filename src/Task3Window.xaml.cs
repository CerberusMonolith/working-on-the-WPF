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

namespace Работа_на_платформе_WPF
{
    public partial class Task3Window : Window
    {
        public Task3Window()
        {
            InitializeComponent();
        }

        private void CheckNumber(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtNumber.Text, out int number))
            {
                lblResult.Content = "Ошибка: Введите целое число.";
                return;
            }

            if (number < 0 || number > 100)
            {
                lblResult.Content = "Ошибка: Число должно быть в диапазоне от 0 до 100.";
                return;
            }

            if (number >= 0 && number <= 14)
                lblResult.Content = $"Число {number} принадлежит промежутку [0-14]";
            else if (number >= 15 && number <= 35)
                lblResult.Content = $"Число {number} принадлежит промежутку [15-35]";
            else if (number >= 36 && number <= 50)
                lblResult.Content = $"Число {number} принадлежит промежутку [36-50]";
            else if (number >= 51 && number <= 100)
                lblResult.Content = $"Число {number} принадлежит промежутку [51-100]";
            else
                lblResult.Content = "Число не принадлежит ни одному из указанных промежутков.";
        }
    }
}