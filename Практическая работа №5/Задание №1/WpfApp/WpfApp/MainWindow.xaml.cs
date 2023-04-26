using System;
using System.Linq;
using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var numbers = InputTextBox.Text.Split(' ').Select(int.Parse).ToList();
                int indexOfZero = numbers.IndexOf(0);
                if (indexOfZero != -1)
                {
                    numbers = numbers.Take(indexOfZero).ToList();
                }
                int minMultipleOfThree = numbers.Where(n => n % 3 == 0).Min();
                ResultTextBlock.Text = minMultipleOfThree.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void InputTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            ResultTextBlock.Text = string.Empty;
        }
    }
}
