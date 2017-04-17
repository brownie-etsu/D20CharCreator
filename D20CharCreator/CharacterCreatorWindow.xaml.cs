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
    /// Interaction logic for CharacterCreatorWindow.xaml
    /// </summary>
    public partial class CharacterCreatorWindow : Window
    {
        public CharacterCreatorWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Show();
        }

        private void ClassButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("pack://application:,,,/ClassPage.xaml");
        }

        private void BackgroundButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("pack://application:,,,/BackgroundPage.xaml");
        }
    }
}
