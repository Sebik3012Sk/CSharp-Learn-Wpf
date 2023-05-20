using Learn_Wpf.PageOutput;
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

namespace Learn_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        WindowSettings windowsettings;

        public MainWindow()
        {
            InitializeComponent();
            windowsettings = new WindowSettings();
        }

        // login button click

        private void butttonLoginClick(object sender , RoutedEventArgs e)
        {

            string text_username_box = username_box.Text.ToString();
            string text_password_box = password_box.Password.ToString();

            if(username_box.GetLineLength(0) < 10)
            {
                MessageBox.Show("No Minimum Lenght in Username", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                username_box.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                username_box.BorderThickness = new Thickness(3);
                username_box.Opacity = 0.7;
                username_box.Background = new SolidColorBrush(Color.FromRgb(149, 0, 11));
            }
            else if(password_box.Password.Length < 10)
            {
                MessageBox.Show("No Minimum Lenght in Password", "Error" , MessageBoxButton.OKCancel, MessageBoxImage.Error);
                password_box.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                password_box.BorderThickness = new Thickness(3);
                password_box.Opacity = 0.7;
                password_box.Background = new SolidColorBrush(Color.FromRgb(149, 0, 11));
            }
            else
            {
                this.Content = new OutputOrderPage();
            }

            
        }
       
        private void fastGoToApp(object sender , KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                this.Content = new OutputOrderPage();
            }
        }

        // button hover effect

        private void hoverButtonLogin(object sender, MouseEventArgs e)
        {
            login_btn.Background = new SolidColorBrush(Color.FromRgb(213, 0, 25));
        }



        

    }
}
