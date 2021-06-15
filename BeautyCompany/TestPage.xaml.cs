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

namespace BeautyCompany
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        public TestPage()
        {
            InitializeComponent();
            
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.Frame.Navigate(new AddPage((sender as Button).DataContext as Service));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DB.db.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            lvService.ItemsSource = DB.getServices();
        }

        private void btnDelte_Click(object sender, RoutedEventArgs e)
        {
            DB.deleteService((sender as Button).DataContext as Service);
            lvService.ItemsSource = DB.getServices();
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.Frame.Navigate(new AddPage(null));
        }
    }
}
