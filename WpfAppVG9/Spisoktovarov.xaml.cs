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
using WpfAppVG9.ModelDB;

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
            Avtorizacia.bd.Товар.Load();
            Tovar.ItemsSource = Avtorizacia.bd.Товар.Local;

            

        }

        public static Товар selectEntites = new Товар();


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

            selectEntites = (Товар)Tovar.SelectedItem;
            
            Ydalit del = new Ydalit();
            del.Show();
            this.Close();
        }

        private void findButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void printButton_Click(object sender, RoutedEventArgs e)
        {
            Remont print = new Remont();
            print.Show();
            
        }
    }
}
