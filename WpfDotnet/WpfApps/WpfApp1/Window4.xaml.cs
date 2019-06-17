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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            lstPlayers.Items.Add(new ListBoxItem { Content = "Rohit" });
            lstPlayers.Items.Add(new ListBoxItem { Content = "Shikhar" });
            lstPlayers.Items.Add(new ListBoxItem { Content = "Rahul" });

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(lstPlayers.SelectedIndex.ToString());
            MessageBox.Show(lstPlayers.SelectedItem.ToString());
            MessageBox.Show(((ListBoxItem)lstPlayers.SelectedItem).Content.ToString());
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            foreach (ListBoxItem item in lstPlayers.SelectedItems)
            {
                MessageBox.Show(item.Content.ToString());
            }
        }
    }
}
