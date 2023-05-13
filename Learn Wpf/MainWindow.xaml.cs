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
            this.Content = new OutputOrderPage();
        }

        // button hover effect

        private void hoverButtonLogin(object sender, MouseEventArgs e)
        {
            login_btn.Background = new SolidColorBrush(Color.FromRgb(213, 0, 25));
        }

        // convert text to password


        private void convertTextToPassword(object sender, TextChangedEventArgs e)
        {

            var tb = (TextBox)sender;
            using (tb.DeclareChangeBlock())
            {
                foreach (var c in e.Changes)
                {
                    if (c.AddedLength == 0) continue;
                    tb.Select(c.Offset, c.AddedLength);
                    if (tb.SelectedText.Contains(' '))
                    {
                        tb.SelectedText = tb.SelectedText.Replace(' ', '_');
                    }
                    tb.Select(c.Offset + c.AddedLength, 0);
                }
            }

        }

    }
}
