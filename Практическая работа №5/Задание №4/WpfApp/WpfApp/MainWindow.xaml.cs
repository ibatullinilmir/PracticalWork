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
                if (double.TryParse(txtX.Text, out double x) && int.TryParse(txtN.Text, out int n))
                {
                    double sum = 0;
                    double term = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        term *= x / i;
                        sum += term;
                    }
                    txtResult.Text = sum.ToString();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите действительные целые значения для X и N.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
