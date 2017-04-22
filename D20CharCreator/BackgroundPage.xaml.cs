using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    /// Interaction logic for BackgroundPage.xaml
    /// </summary>
    public partial class BackgroundPage : Page
    {
        OrderedDictionary list = new OrderedDictionary();
        public BackgroundPage()
        {
            InitializeComponent();
        }

        private void BackgroundListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EquipmentComboBox.IsEnabled = true;

            ListBoxItem item = BackgroundListBox.SelectedValue as ListBoxItem;

            switch (item.Content as string)
            {
                case "Acolyte":
                    Proficiency1TextBlock.Text = "Insight";
                    Proficiency2TextBlock.Text = "Religion";
                    Proficiency3TextBlock.Text = "";
                    Proficiency4TextBlock.Text = "";

                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = true;

                    list.Clear();
                    list.Add("Pack A", "A holy symbol\nA prayer book or prayer wheel\n5 sticks of incense\nVestments\nA set of common clothes\nA belt pouch containing 15 gp");
                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Charlatan":
                    Proficiency1TextBlock.Text = "Deception";
                    Proficiency2TextBlock.Text = "Sleight of Hand";
                    Proficiency3TextBlock.Text = "Disguise Kit";
                    Proficiency4TextBlock.Text = "Forgery Kit";

                    Language1ComboBox.IsEnabled = false;
                    Language2ComboBox.IsEnabled = false;
                    Language1ComboBox.SelectedIndex = -1;
                    Language2ComboBox.SelectedIndex = -1;

                    list.Clear();
                    list.Add("Pack A", "A set of fine clothes\nA disguise kit\nTen stoppered bottles filled with colored liquid\nA belt pouch containing 15 gp");
                    list.Add("Pack B", "A set of fine clothes\nA disguise kit\nA set of weighted dice\nA belt pouch containing 15 gp");
                    list.Add("Pack C", "A set of fine clothes\nA disguise kit\nA deck of marked cards\nA belt pouch containing 15 gp");
                    list.Add("Pack D", "A set of fine clothes\nA disguise kit\nA signet ring of an imaginary duke\nA belt pouch containing 15 gp");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Criminal":
                    Proficiency1TextBlock.Text = "Deception";
                    Proficiency2TextBlock.Text = "Stealth";
                    Proficiency3TextBlock.Text = "One type of gaming set";
                    Proficiency4TextBlock.Text = "Thieves' Tools";

                    Language1ComboBox.IsEnabled = false;
                    Language2ComboBox.IsEnabled = false;
                    Language1ComboBox.SelectedIndex = -1;
                    Language2ComboBox.SelectedIndex = -1;

                    list.Clear();
                    list.Add("Pack A", "A crowbar\nA set of dark common clothes including a hood\nA belt pouch containing 15 GP");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Entertainer":
                    Proficiency1TextBlock.Text = "Acrobatics";
                    Proficiency2TextBlock.Text = "Performance";
                    Proficiency3TextBlock.Text = "Disguise Kit";
                    Proficiency4TextBlock.Text = "One type of musical instrument";

                    Language1ComboBox.IsEnabled = false;
                    Language2ComboBox.IsEnabled = false;
                    Language1ComboBox.SelectedIndex = -1;
                    Language2ComboBox.SelectedIndex = -1;

                    list.Clear();
                    list.Add("Pack A", "A musical instrument\nThe favor of an admirer -- Love letter\nA costume\nA belt pouch containing 15 gp");
                    list.Add("Pack B", "A musical instrument\nThe favor of an admirer -- Lock of hair\nA costume\nA belt pouch containing 15 gp");
                    list.Add("Pack C", "A musical instrument\nThe favor of an admirer -- Trinket\nA costume\nA belt pouch containing 15 gp");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Folk Hero":
                    Proficiency1TextBlock.Text = "Animal Handling";
                    Proficiency2TextBlock.Text = "Survival";
                    Proficiency3TextBlock.Text = "One type of artisan's tools";
                    Proficiency4TextBlock.Text = "Land Vehicles";
                    Language1ComboBox.IsEnabled = false;
                    Language2ComboBox.IsEnabled = false;
                    Language1ComboBox.SelectedIndex = -1;
                    Language2ComboBox.SelectedIndex = -1;

                    list.Clear();
                    list.Add("Pack A", "A set of artisan’s tools\nA shovel\nAn iron pot\nA set of common clothes\nA belt pouch containing 10 gp");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Guild Artisan":
                    Proficiency1TextBlock.Text = "Insight";
                    Proficiency2TextBlock.Text = "Persuasion";
                    Proficiency3TextBlock.Text = "One type of artisan's tools";
                    Proficiency4TextBlock.Text = "";
                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;

                    list.Clear();
                    list.Add("Pack A", "A set of artisan’s tools\nA letter of introduction from your guild\nA set of traveler’s clothes\nA belt pouch containing 15 gp");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Hermit":
                    Proficiency1TextBlock.Text = "Medicine";
                    Proficiency2TextBlock.Text = "Religion";
                    Proficiency3TextBlock.Text = "Herbalism kit";
                    Proficiency4TextBlock.Text = "";

                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;

                    list.Clear();
                    list.Add("Pack A", "A scroll case stuffed full of notes from your studies/prayers\nA winter blanket\nA set of common clothes\nAn herbalism kit\n5 gp");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Noble":
                    Proficiency1TextBlock.Text = "History";
                    Proficiency2TextBlock.Text = "Persuasion";
                    Proficiency3TextBlock.Text = "One type of gaming set";
                    Proficiency4TextBlock.Text = "";

                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;

                    list.Clear();
                    list.Add("Pack A", "A set of fine clothes\nA signet ring\nA scroll of pedigree\nA purse containing 25 gp");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Outlander":
                    Proficiency1TextBlock.Text = "Athletics";
                    Proficiency2TextBlock.Text = "Survival";
                    Proficiency3TextBlock.Text = "One type of musical instrument";
                    Proficiency4TextBlock.Text = "";

                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;

                    list.Clear();
                    list.Add("Pack A", "A staff\nA hunting trap\nA trophy from an animal you killed\nA set of traveler’s clothes\nA belt pouch containing 10 g");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Sage":
                    Proficiency1TextBlock.Text = "Arcana";
                    Proficiency2TextBlock.Text = "History";
                    Proficiency3TextBlock.Text = "";
                    Proficiency4TextBlock.Text = "";

                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = true;

                    list.Clear();
                    list.Add("Pack A", "A bottle of black ink\nA quill\nA small knife\nA letter from a dead colleague posing a question you have not yet been able to answer\nA set of common clothes\nA belt pouch containing 10 gp");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;
                case "Sailor":
                    Proficiency1TextBlock.Text = "Athletics";
                    Proficiency2TextBlock.Text = "Perception";
                    Proficiency3TextBlock.Text = "Navigator’s tools";
                    Proficiency4TextBlock.Text = "Water Vehicles";

                    Language1ComboBox.IsEnabled = false;
                    Language2ComboBox.IsEnabled = false;
                    Language1ComboBox.SelectedIndex = -1;
                    Language2ComboBox.SelectedIndex = -1;

                    list.Clear();
                    list.Add("Pack A", "A belaying pin (club)\n50 feet of silk rope\nA lucky charm \nA set of common clothes\nA belt pouch containing 10 gp");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;
                case "Soldier":
                    Proficiency1TextBlock.Text = "Athletics";
                    Proficiency2TextBlock.Text = "Intimidation";
                    Proficiency3TextBlock.Text = "One type of gaming set";
                    Proficiency4TextBlock.Text = "Land Vehicles";

                    Language1ComboBox.IsEnabled = false;
                    Language2ComboBox.IsEnabled = false;
                    Language1ComboBox.SelectedIndex = -1;
                    Language2ComboBox.SelectedIndex = -1;

                    list.Clear();
                    list.Add("Pack A", "An insignia of rank\nA trophy taken from a fallen enemy -- Dagger\nA set of bone dice\nA set of common clothes\nA belt pouch containing 10 gp");
                    list.Add("Pack B", "An insignia of rank\nA trophy taken from a fallen enemy -- Broken blade\nA set of bone dice\nA set of common clothes\nA belt pouch containing 10 gp");
                    list.Add("Pack C", "An insignia of rank\nA trophy taken from a fallen enemy -- Piece of a banner\nA set of bone dice\nA set of common clothes\nA belt pouch containing 10 gp");
                    list.Add("Pack D", "An insignia of rank\nA trophy taken from a fallen enemy -- Dagger\nA deck of cards\nA set of common clothes\nA belt pouch containing 10 gp");
                    list.Add("Pack E", "An insignia of rank\nA trophy taken from a fallen enemy -- Broken blade\nA deck of cards\nA set of common clothes\nA belt pouch containing 10 gp");
                    list.Add("Pack F", "An insignia of rank\nA trophy taken from a fallen enemy -- Piece of a banner\nA deck of cards\nA set of common clothes\nA belt pouch containing 10 gp");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;
                case "Urchin":
                    Proficiency1TextBlock.Text = "Sleight of Hand";
                    Proficiency2TextBlock.Text = "Stealth";
                    Proficiency3TextBlock.Text = "Disguise Kit";
                    Proficiency4TextBlock.Text = "Thieves' Tools";

                    Language1ComboBox.IsEnabled = false;
                    Language2ComboBox.IsEnabled = false;
                    Language1ComboBox.SelectedIndex = -1;
                    Language2ComboBox.SelectedIndex = -1;

                    list.Clear();
                    list.Add("Pack A", "A small knife\nA map of the city you grew up in\nA pet mouse\nA token to remember your parents by\nA set of common clothes\nA belt pouch containing 10 gp");

                    EquipmentComboBox.ItemsSource = list.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();

                    break;
            }
        }

        private void EquipmentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem item = BackgroundListBox.SelectedValue as ListBoxItem;
            EquipmentTextBox.Text = list[EquipmentComboBox.SelectedIndex].ToString();
        }
    }
}
