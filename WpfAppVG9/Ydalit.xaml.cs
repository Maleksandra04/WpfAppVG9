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
using System.Windows.Shapes;

namespace WpfAppVG9
{
    /// <summary>
    /// Логика взаимодействия для Ydalit.xaml
    /// </summary>
    public partial class Ydalit : Window
    {
        public Ydalit()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Spisoktovarov main = new Spisoktovarov();
            main.Show();
            this.Close();
        }

        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            
            
            Avtorizacia.bd.Ремонт.Remove(Spisoktovarov.SelectEnts);
            Avtorizacia.bd.SaveChanges();
            Spisoktovarov main = new Spisoktovarov();
            main.Show();
            this.Close();
        }
    }
}
