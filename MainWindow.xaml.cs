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

namespace Zadanie_3_Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string font = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox1 != null)
            {
                textBox1.FontFamily = new FontFamily(font);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBox1 != null)
            {
                textBox1.FontSize = fontSize;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.FontWeight == FontWeights.Normal)
            {
                textBox1.FontWeight = FontWeights.Bold;
                (sender as Button).BorderBrush = Brushes.Blue;
            }
            else
            {
                textBox1.FontWeight = FontWeights.Normal;
                (sender as Button).BorderBrush = Brushes.Transparent;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox1.FontStyle == FontStyles.Normal)
            {
                textBox1.FontStyle = FontStyles.Italic;
                (sender as Button).BorderBrush = Brushes.Blue;
            }
            else
            {
                textBox1.FontStyle = FontStyles.Normal;
                (sender as Button).BorderBrush = Brushes.Transparent;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox1.TextDecorations != TextDecorations.Underline)
            {
                textBox1.TextDecorations = TextDecorations.Underline;
                (sender as Button).BorderBrush = Brushes.Blue;
            }
            else
            {
                textBox1.TextDecorations = null;
                (sender as Button).BorderBrush = Brushes.Transparent;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox1 != null)
            {
                textBox1.Foreground = Brushes.Red;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox1 != null)
            {
                textBox1.Foreground = Brushes.Black;
            }
        }
    }
}
