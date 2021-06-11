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
    /// Логика взаимодействия для Dobavlenie.xaml
    /// </summary>
    public partial class Dobavlenie : Window
    {

        public static ModelDB.Ремонт emp = new ModelDB.Ремонт();
        
        public Dobavlenie()
        {
            InitializeComponent();
        }

        ModelDB.Товар per = new ModelDB.Товар();

        private void add_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                per.GoodsID = kod.Text;
                emp.CostRepair = Convert.ToDecimal(stoimost.Text);
                emp.StartDate = priemka.SelectedDate;
                emp.StopDate = polych.SelectedDate;
                Avtorizacia.bd.SaveChanges();
                Spisoktovarov lop = new Spisoktovarov();
                lop.Show();
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка в воде данных");
            }

        }
    }
}
