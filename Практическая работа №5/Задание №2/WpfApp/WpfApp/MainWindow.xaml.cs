using System;
using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int CountEvenNumbers(int a, int b)
        {
            if (a % 2 != 0)
            {
                a += 1;
            }
            if (b % 2 != 0)
            {
                b -= 1;
            }
            return (b - a) / 2 + 1;
        }

        private void CountButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var numbers = InputTextBox.Text.Split(' ');
                int a = int.Parse(numbers[0]);
                int b = int.Parse(numbers[1]);
                int result = CountEvenNumbers(a, b);
                ResultTextBlock.Text = result.ToString();
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
