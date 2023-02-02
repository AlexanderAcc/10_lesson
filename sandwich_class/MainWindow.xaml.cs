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

namespace sandwich_class
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bread bread = new Bread { Weight = Convert.ToInt32(text1.Text) }; // объект класса хлеб с текстом из textbox

            Butter butter = new Butter { Weight = Convert.ToInt32(text2.Text) }; // объект класса хлеб с текстом из textbox

            Sandwich sandwich = bread + butter; // создание объекта класса бутерброд складывая массу хлеба и масла

            lb.Content = sandwich.Weight + "г"; // передача в label
        }
    }
}
