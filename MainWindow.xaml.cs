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

namespace practice_languages__29._09
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool is_ukr = true;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (is_ukr)
            {
                Lang_image.Source = new BitmapImage(new Uri("Images/eng.png", UriKind.Relative));
                Lang_label.Content = "English";
                Lang_label.Foreground = Brushes.DarkRed;

                button1.Content = "Previous";
                button2.Content = "Next";
                button3.Content = "Save";
                button4.Content = "Close";

                Text.Text = "Glory to Ukraine!";
                Text.Foreground = Brushes.PaleVioletRed;

                button1.Background = Brushes.PaleVioletRed;
                button2.Background = Brushes.PaleVioletRed;
                button3.Background = Brushes.PaleVioletRed;
                button4.Background = Brushes.PaleVioletRed;

                is_ukr = false;
            }
            else
            {
                Lang_image.Source = new BitmapImage(new Uri("Images/ukr.png", UriKind.Relative));
                Lang_label.Content = "Українська";
                Lang_label.Foreground = Brushes.DeepSkyBlue;

                button1.Content = "Назад";
                button2.Content = "Далі";
                button3.Content = "Зберегти";
                button4.Content = "Закрити";

                Text.Text = "Слава Україні!";
                Text.Foreground = Brushes.CornflowerBlue;

                button1.Background = Brushes.CornflowerBlue;
                button2.Background = Brushes.CornflowerBlue;
                button3.Background = Brushes.CornflowerBlue;
                button4.Background = Brushes.CornflowerBlue;

                is_ukr = true;
            }
        }
    }
}