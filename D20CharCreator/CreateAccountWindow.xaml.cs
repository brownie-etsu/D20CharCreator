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

using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace D20CharCreator
{
    /// <summary>
    /// Interaction logic for CreateAccountWindow.xaml
    /// </summary>
    public partial class CreateAccountWindow : Window
    {
        public CreateAccountWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Show();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();

            if(IsValidInput())
            {
                if (Database.IsUsernameInUse(UsernameInputBox.Text))
                {
                    MessageBox.Show("The name \"" + UsernameInputBox.Text + "\" is already in use.", "Account Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    UsernameInputBox.Clear();
                    Show();
                    return;
                }

                if  (Database.IsEmailInUse(EmailInputBox.Text))
                {
                    MessageBox.Show("The email \"" + EmailInputBox.Text + "\" is already in use.", "Account Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    EmailInputBox.Clear();
                    Show();
                    return;    
                }

                bool created = Database.SignUp(UsernameInputBox.Text, FirstNameInputBox.Text, LastNameInputBox.Text, EmailInputBox.Text, PasswordInputBox1.Password);

                if (created)
                {
                    MessageBox.Show("\"" + UsernameInputBox.Text + "\", you have successfully created an account.", "Account Created", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("An unknown error has occurred.", "Account Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    UsernameInputBox.Clear();
                    Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill in every box.", "Account Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                Show();
            }
        }

        private bool IsValidInput()
        {
            return !(String.IsNullOrEmpty(FirstNameInputBox.Text) || String.IsNullOrEmpty(LastNameInputBox.Text) ||
                     String.IsNullOrEmpty(EmailInputBox.Text) || String.IsNullOrEmpty(FirstNameInputBox.Text) ||
                     String.IsNullOrEmpty(UsernameInputBox.Text) || String.IsNullOrEmpty(PasswordInputBox1.Password) ||
                     String.IsNullOrEmpty(PasswordInputBox2.Password));
        }
    }
}
