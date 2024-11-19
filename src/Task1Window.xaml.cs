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
    public partial class Task1Window : Window
    {
        public Task1Window()
        {
            InitializeComponent();
        }

        private void TranslateWord(object sender, RoutedEventArgs e)
        {
            string word = txtWord.Text.ToLower();
            string translation = "";

            switch (word)
            {
                case "солнце": translation = "sun"; break;
                case "дождь": translation = "rain"; break;
                case "туман": translation = "fog"; break;
                case "облако": translation = "cloud"; break;
                case "град": translation = "hail"; break;
                case "оползень": translation = "landslide"; break;
                case "камнепад": translation = "rockfall"; break;
                case "жимолость": translation = "honeysuckle"; break;
                case "яйцо": translation = "egg"; break;
                default: translation = "Такого слова нет в словаре."; break;
            }

            lblTranslation.Content = translation;
        }
    }
}