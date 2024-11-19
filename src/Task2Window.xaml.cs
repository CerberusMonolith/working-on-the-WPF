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
    public partial class Task2Window : Window
    {
        double operand1 = 10;
        double operand2 = 5;

        public Task2Window()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            string sign = txtOperation.Text;
            double result = 0;
            bool error = false;

            try
            {
                switch (sign)
                {
                    case "+": result = operand1 + operand2; break;
                    case "-": result = operand1 - operand2; break;
                    case "*": result = operand1 * operand2; break;
                    case "/":
                        if (operand2 == 0)
                        {
                            lblResult.Content = "Ошибка: Деление на ноль!";
                            error = true;
                        }
                        else
                        {
                            result = operand1 / operand2;
                        }
                        break;
                    default:
                        lblResult.Content = "Ошибка: Неверный знак операции!";
                        error = true;
                        break;
                }
                if (!error) lblResult.Content = "Результат: " + result;
            }
            catch (Exception ex)
            {
                lblResult.Content = "Ошибка: " + ex.Message;
            }
        }
    }
}