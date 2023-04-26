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
                if (int.TryParse(txtN.Text, out int n) && n >= 3)
                {
                    double[] u = new double[n];
                    double[] v = new double[n];
                    u[0] = u[1] = 0;
                    v[0] = v[1] = 1;
                    for (int i = 2; i < n; i++)
                    {
                        double u1 = u[i - 1];
                        double u2 = u[i - 2];
                        double v1 = v[i - 1];
                        double v2 = v[i - 2];
                        double u3 = (u1 - u2 * v1 - u2 * v2) / (1 + Math.Pow(u2, 2) + Math.Pow(v2, 2));
                        double v3 = (u1 - v1) / (Math.Abs(u2 + v1) + 2);
                        u[i] = u3;
                        v[i] = v3;
                    }
                    txtResult.Text = u[n - 1].ToString();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите действительное значение для n (n >= 3).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
