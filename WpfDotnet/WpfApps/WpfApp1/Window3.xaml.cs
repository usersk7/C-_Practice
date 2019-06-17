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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            lblSample.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            lblSample.Foreground = new SolidColorBrush(Colors.Pink);

        }

        private void RadioButton3_Checked(object sender, RoutedEventArgs e)
        {
            lblSample.Background = new SolidColorBrush(Colors.Orange);
        }
    }
}
