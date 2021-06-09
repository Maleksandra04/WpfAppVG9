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
    /// Логика взаимодействия для Ydalenie1.xaml
    /// </summary>
    public partial class Ydalenie1 : Window
    {
        public Ydalenie1()
        {
            InitializeComponent();
        }

        private void cancelButton1_Click(object sender, RoutedEventArgs e)
        {
            Remont main = new Remont();
            main.Show();
            this.Close();
        }

        private void delButton1_Click(object sender, RoutedEventArgs e)
        {
            Avtorizacia.bd.Ремонт.Remove(Remont.selectEntites);
            Avtorizacia.bd.SaveChanges();
            Remont main = new Remont();
            main.Show();
            this.Close();
        }
    }
}
