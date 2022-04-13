using Hospital.UserControls;
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

namespace Hospital.Pages
{
    /// <summary>
    /// Interaction logic for UserDatailsPage.xaml
    /// </summary>
    public partial class UserDatailsPage : Page
    {
        public UserDatailsPage()
        {
            InitializeComponent();

            /*var emp = new User();
            emp.Salary = 15000;

            // sets the Datacontext for the Page
            this.DataContext = emp;*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
