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
            this.Owner.Show();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            if(CheckInputBoxes())
            {
                if (UsernameInputBox.Text == "username")
                {
                    MessageBox.Show("\"" + UsernameInputBox.Text + "\", you have successfully created an account.", "Account Created", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("\"" + UsernameInputBox.Text + "\" is already taken.", "Account Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    UsernameInputBox.Clear();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill in every box.", "Account Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Show();
            }
        }

        private bool CheckInputBoxes()
        {
            if(String.IsNullOrEmpty(FirstNameInputBox.Text) || String.IsNullOrEmpty(LastNameInputBox.Text) || String.IsNullOrEmpty(EmailInputBox.Text) || String.IsNullOrEmpty(FirstNameInputBox.Text) || String.IsNullOrEmpty(UsernameInputBox.Text) || String.IsNullOrEmpty(PasswordInputBox1.Password) || String.IsNullOrEmpty(PasswordInputBox2.Password))
                return false;

            return true;
        }
    }
}
