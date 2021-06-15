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
    /// Логика взаимодействия для EntryPage.xaml
    /// </summary>
    public partial class EntryPage : Page
    {
        public EntryPage()
        {
            InitializeComponent();
        }

        private void clientMenu_Click(object sender, RoutedEventArgs e)
        {
            Manager.Frame.Navigate(new ServicePage());
        }

        private void adminMenu_Click(object sender, RoutedEventArgs e)
        {
            Manager.Frame.Navigate(new TestPage());
        }
    }
}
