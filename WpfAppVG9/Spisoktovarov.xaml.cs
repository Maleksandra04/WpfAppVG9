using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace WpfAppVG9
{
    /// <summary>
    /// Логика взаимодействия для Spisoktovarov.xaml
    /// </summary>
    public partial class Spisoktovarov : Window
    {
        public Spisoktovarov()
        {
            InitializeComponent();
        }

        private void Tovar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Dobavlenie add = new Dobavlenie();
            add.Show();
        }

        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            Ydalit del = new Ydalit();
            del.Show();
            this.Close();
        }

        private void findButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void printButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
