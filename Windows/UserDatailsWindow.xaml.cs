using Hospital.Models;
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

namespace Hospital.Windows
{
    /// <summary>
    /// Interaction logic for UserDatailsWindow.xaml
    /// </summary>
    public partial class UserDatailsWindow : Window
    {
        public UserDatailsWindow(User user)
        {
            InitializeComponent();
            this.DataContext = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
