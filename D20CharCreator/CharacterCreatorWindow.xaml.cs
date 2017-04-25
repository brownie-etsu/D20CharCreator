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
        BackgroundPage backgroundPage;
        ClassPage classPage;

        public CharacterCreatorWindow()
        {
            InitializeComponent();
            LoadPages();
        }

        public CharacterCreatorWindow(Character charToEdit)
        {
            InitializeComponent();
            LoadPages(charToEdit);
        }

        private void LoadPages()
        {
            backgroundPage = new BackgroundPage();
            classPage = new ClassPage();
            frame.Navigate(backgroundPage);
        }

        private void LoadPages(Character charToEdit)
        {
            backgroundPage = new BackgroundPage();
            classPage = new ClassPage();
            frame.Navigate(backgroundPage);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Show();
        }

        private void ClassButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(classPage);
        }

        private void BackgroundButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(backgroundPage);
        }
    }
}
