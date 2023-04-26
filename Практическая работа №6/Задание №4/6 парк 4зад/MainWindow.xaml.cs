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

namespace _6_парк_4зад
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class DataItem
        {
            public double x { get; set; }
            public double y { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
            double a = -2.0; // начало отрезка
            double b = 2.0; // конец отрезка
            double h = 0.5; // шаг

            List<DataItem> data = new List<DataItem>();

            for (double x = a; x <= b; x += h)
            {
                double y;
                if (x < 0)
                {
                    y = -4.0;
                }
                else if (x < 1)
                {
                    y = Math.Pow(x, 2);
                }
                else
                {
                    y = 2.0;
                }
                data.Add(new DataItem() { x = x, y = y });
            }

            table.ItemsSource = data;
        }
    }
}

    