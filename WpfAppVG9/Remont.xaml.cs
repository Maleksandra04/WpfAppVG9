using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppVG9
{
    /// <summary>
    /// Логика взаимодействия для Remont.xaml
    /// </summary>
    public partial class Remont : Window
    {

        public static ModelDB.Modelremont bd = new ModelDB.Modelremont();

        public Remont()
        {
            InitializeComponent();
            Avtorizacia.bd.Ремонт.Load();
            Rem.ItemsSource = Avtorizacia.bd.Ремонт.Local;
        }

        private void printButton1_Click(object sender, RoutedEventArgs e)
        {
            Otchet print = new Otchet();
            print.Show();
        }

        private void findButton1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delButton1_Click(object sender, RoutedEventArgs e)
        {
            Ydalenie1 del = new Ydalenie1();
            del.Show();
            this.Close();
        }

        private void addButton1_Click(object sender, RoutedEventArgs e)
        {
            Dobavlenierem add = new Dobavlenierem();
            add.Show();
        }

        private void Rem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
