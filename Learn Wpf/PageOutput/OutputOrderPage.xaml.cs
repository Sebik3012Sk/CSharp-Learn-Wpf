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

namespace Learn_Wpf.PageOutput
{
    /// <summary>
    /// Interakční logika pro OutputOrderPage.xaml
    /// </summary>
    public partial class OutputOrderPage : Page
    {

        public int width_sep_menu { get; set; } = 250;

        public OutputOrderPage()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
