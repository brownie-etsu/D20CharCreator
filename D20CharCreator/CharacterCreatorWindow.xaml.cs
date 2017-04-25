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

        private Character _editing;

        public CharacterCreatorWindow()
        {
            InitializeComponent();
            LoadPages();
            _editing = new Character();
        }

        public CharacterCreatorWindow(Character charToEdit)
        {
            InitializeComponent();
            LoadPages(charToEdit);
            _editing = charToEdit;
        }

        private void LoadPages()
        {
            backgroundPage = new BackgroundPage();
            classPage = new ClassPage();
            frame.Navigate(backgroundPage);
        }

        private void LoadPages(Character charToEdit)
        {
            backgroundPage = new BackgroundPage(charToEdit);
            classPage = new ClassPage(charToEdit);
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _editing.Background.Type = (BackgroundType)backgroundPage.BackgroundListBox.SelectedIndex;
            _editing.Background.LangOne = (Language)backgroundPage.Language1ComboBox.SelectedIndex;
            _editing.Background.LangTwo = (Language)backgroundPage.Language2ComboBox.SelectedIndex;
            _editing.Background.Equipment = backgroundPage.EquipmentComboBox.SelectedIndex;
            _editing.Background.Characteristics[0] = Array.IndexOf(((string[])backgroundPage.personalityTraitsList[(int)_editing.Background.Type]), backgroundPage.PersonalityTextBox.Text);
            _editing.Background.Characteristics[1] = Array.IndexOf(((string[])backgroundPage.idealTraitsList[(int)_editing.Background.Type]), backgroundPage.IdealTextBox.Text);
            _editing.Background.Characteristics[2] = Array.IndexOf(((string[])backgroundPage.bondTraitsList[(int)_editing.Background.Type]), backgroundPage.BondTextBox.Text);
            _editing.Background.Characteristics[3] = Array.IndexOf(((string[])backgroundPage.flawTraitsList[(int)_editing.Background.Type]), backgroundPage.FlawTextBox.Text);
            _editing.Background.Rerolls = backgroundPage._rollsLeft;
            _editing.Class.Type = (ClassType)classPage.ClassListBox.SelectedIndex;
            _editing.Class.Equipment = classPage.EquipmentComboBox.SelectedIndex;


            Database.SaveCharacter(_editing);
        }
    }
}
