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

namespace _6_прак_1зад
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

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                int f(int x)
                {
                    if (x < 100)
                    {
                        throw new ArgumentException("Число должно состоять хотя бы из трех цифр");
                    }
                    return (x / 10) % 10;
                }


                int a = Convert.ToInt32(TbNumberA.Text);
                int b = Convert.ToInt32(TbNumberB.Text);
                int c = Convert.ToInt32(TbNumberC.Text);
                int z = f(a) + f(b) - f(c);
                MessageBox.Show($"Значение z = {z}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
    }
}
}