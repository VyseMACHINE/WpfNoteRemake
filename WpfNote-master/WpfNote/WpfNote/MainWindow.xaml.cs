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

namespace WpfNote
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void pasteClick(object sender, RoutedEventArgs e)
        {
            textBox1.Paste();
        }

        private void copyClick(object sender, RoutedEventArgs e)
        {
            textBox1.Copy();
        }

        private void cutClick(object sender, RoutedEventArgs e)
        {
            textBox1.Cut();
        }

        private void buttonClick1(object sender, RoutedEventArgs e)
        {
            textBox2.Background = Brushes.Red;
        }

        private void buttonClick2(object sender, RoutedEventArgs e)
        {
            textBox2.Background = Brushes.Blue;
        }

        private void buttonClick3(object sender, RoutedEventArgs e)
        {
            textBox2.Background = Brushes.Green;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            button4.Margin = new Thickness(rand.Next(0, 150), rand.Next(0, 150), 0, 0);


        }

        private void buttonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
