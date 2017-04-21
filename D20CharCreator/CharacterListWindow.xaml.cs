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
using D20CharCreator;

using System.Drawing;

namespace D20CharCreator
{
    /// <summary>
    /// Interaction logic for CharacterListWindow.xaml
    /// </summary>
    public partial class CharacterListWindow : Window
    {
        private int _userId;
        private List<Character> _characters;

        public CharacterListWindow()
        {
            InitializeComponent();
        }

        public CharacterListWindow(int userId)
        {
            _userId = userId;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            List<object> stuff = new List<object>();
            var a = new { Class = ClassType.BARBARIAN, Name = "Name 1" };
            var b = new { Class = ClassType.ROGUE, Name = "Name 2" };
            stuff.Add(a);
            stuff.Add(b);

            CharListTable.ItemsSource = stuff;

            Database.GetCharacterList(17);
            */

            _characters = new List<Character>(Database.GetCharacterList(_userId));

            CharListTable.ItemsSource = _characters;
        }

        private void DeleteCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            Character charToDelete = ((FrameworkElement)sender).DataContext as Character;

            Database.DeleteCharacter(charToDelete);

            _characters.Remove(charToDelete);

            CharListTable.Items.Refresh();
        }

        private void AddCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CharacterCreatorWindow charCreatorWin = new CharacterCreatorWindow();
            charCreatorWin.Owner = this;
            charCreatorWin.Show();
        }
    }
}
