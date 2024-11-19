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
    public partial class Task4Window : Window
    {
        string correctPassword = "Ыүіөбөыұқхүұлы"; 

        public Task4Window()
        {
            InitializeComponent();
        }

        private void CheckPassword(object sender, RoutedEventArgs e)
        {
            string enteredPassword = txtPassword.Password;

            if (enteredPassword == correctPassword)
            {
                lblResult.Content = "Секретное сообщение: А ты как сюда попал? Ты что казах?";
            }
            else
            {
                lblResult.Content = "Неверный пароль. Попробуйте снова.";
            }
        }
    }
}
