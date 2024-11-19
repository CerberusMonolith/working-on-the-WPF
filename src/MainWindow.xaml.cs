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

namespace Работа_на_платформе_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenTask1(object sender, RoutedEventArgs e) { new Task1Window().ShowDialog(); }
        private void OpenTask2(object sender, RoutedEventArgs e) { new Task2Window().ShowDialog(); }
        private void OpenTask3(object sender, RoutedEventArgs e) { new Task3Window().ShowDialog(); }
        private void OpenTask4(object sender, RoutedEventArgs e) { new Task4Window().ShowDialog(); }
    }
}