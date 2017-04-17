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

namespace D20CharCreator
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            CreateAccountWindow accountWindow = new CreateAccountWindow();
            accountWindow.Owner = this;
            accountWindow.Show();
            Hide();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();

            if (UsernameInputBox.Text == "username" && PasswordInputBox.Password == "password")
            {
                CharacterListWindow charListWindow = new CharacterListWindow();
                charListWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username/password.\nPlease try again.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                Show();
            }
        }
    }
}
