using Hospital.Models;
using Hospital.Windows;
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
    /// Interaction logic for UserListPage.xaml
    /// </summary>
    public partial class UserListPage : Page
    {
        public UserListPage()
        {
            InitializeComponent();

            List<User> users = new List<User>
            {
                new User { Id = 1, FirstName = "Sohib", LastName = "Jaynarov", PhoneNumber = "+998973298282", Analize = Analize.Qon },
                new User { Id = 2, FirstName = "Azamat", LastName = "Xoliqov", PhoneNumber = "+998973298282", Analize = Analize.Covid },
                new User { Id = 3, FirstName = "Abror", LastName = "Tuymurodov", PhoneNumber = "+56465", Analize = Analize.Covid },
                new User { Id = 4, FirstName = "Fotima", LastName = "Jaynarova", PhoneNumber = "+99897368548282", Analize = Analize.Qon },
                new User { Id = 5, FirstName = "Sohib", LastName = "Jaynarov", PhoneNumber = "+545665464", Analize = Analize.Qon },
                new User { Id = 6, FirstName = "Akbar", LastName = "Ergashev", PhoneNumber = "+45354354", Analize = Analize.Covid },
            };

            lvUsers.ItemsSource = users;

        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                User user = item.DataContext as User;
                Window window = new UserDatailsWindow(user);
                window.ShowDialog();
            }
        }
    }
}
