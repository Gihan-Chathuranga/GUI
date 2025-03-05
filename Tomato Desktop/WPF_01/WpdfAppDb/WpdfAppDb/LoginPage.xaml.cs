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

namespace WpdfAppDb
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var username = Username.Text;
            var password = Password.Password;

            using (UserDataContext context = new UserDataContext())
            {
                bool userFound = context.User.Any(u => u.Name == username && u.Password == password);

                if (userFound)
                {
                    GrantAccess();
                    Close();
                }
                else
                {
                    MessageBox.Show("User Not Found", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public void GrantAccess()
        {
            Home homePage = new Home();
            homePage.Show();
        }

    }
}
