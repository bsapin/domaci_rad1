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

namespace domaci_rad1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void l_button_Click_1(object sender, RoutedEventArgs e)
        {
            Rectangle new_block = new Rectangle();
            new_block.Width = 80;
            new_block.Height = 60;
            Color my_color = (Color)ColorConverter.ConvertFromString("#ED7D31");
            new_block.Fill = new SolidColorBrush(my_color);
            new_block.Margin = new Thickness(5);
            l_panel.Children.Add(new_block);
        }

        private void r_button_Click_1(object sender, RoutedEventArgs e)
        {
            Rectangle new_block = new Rectangle();
            new_block.Width = 320;
            new_block.Height = 40;
            Color my_color = (Color)ColorConverter.ConvertFromString("#FF0000");
            new_block.Fill = new SolidColorBrush(my_color);
            new_block.Margin = new Thickness(5);
            r_panel.Children.Add(new_block);

        }
    }
}
