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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        Service service = new Service();
        public AddPage(Service curservice)
        {
            InitializeComponent();
            if (curservice != null)
                service = curservice;   
            DataContext = service;
        }

        private void txtSave_Click(object sender, RoutedEventArgs e)
        {
            if(service.ID == 0)
                DB.addService(service);
            DB.saveChanges();
            Manager.Frame.Navigate(new TestPage());
        }
    }
}
