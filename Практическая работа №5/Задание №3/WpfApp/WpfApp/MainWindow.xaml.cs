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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
                {
                    int sum = 0;
                    for (int i = a; i <= b; i++)
                    {
                        sum += i;
                    }
                    txtResult.Text = sum.ToString();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите действительные целые значения для A и B.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}