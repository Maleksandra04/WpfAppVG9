using System;
using System.Data.Entity;
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
    /// Логика взаимодействия для Avtorizacia.xaml
    /// </summary>
    public partial class Avtorizacia : Window
    {

       public static ModelDB.Modelremont bd = new ModelDB.Modelremont();

        public Avtorizacia()
        {
            InitializeComponent();
            bd.User.Load();
            nameUserCB.ItemsSource = bd.User.Local;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
           if (bd.User.Where(x=> x.Users == nameUserCB.Text &&x.Password==passUserPB.Password).FirstOrDefault()!=null)
            {
                Spisoktovarov login = new Spisoktovarov();
                login.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Пользователь с такими данными не найден");
            }
           
        }
    }
}
