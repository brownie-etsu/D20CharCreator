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
    /// Interaction logic for BackgroundPage.xaml
    /// </summary>
    public partial class BackgroundPage : Page
    {
        public BackgroundPage()
        {
            InitializeComponent();
        }

        private void BackgroundListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
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
                    EquipmentTextBox.Text = "A holy symbol\nA prayer book or prayer wheel\n5 sticks of incense\nVestments\nA set of common clothes\nA belt pouch containing 15 gp";
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
                    EquipmentTextBox.Text = "A set of fine clothes\nA disguise kit\nTools of the con of your choice:\n  Ten stoppered bottles filled with colored liquid\n  A set of weighted dice\n  A deck of marked cards\n  A signet ring of an imaginary duke\nA belt pouch containing 15 gp";
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
                    break;
                case "Guild Artisan":
                    Proficiency1TextBlock.Text = "Insight";
                    Proficiency2TextBlock.Text = "Persuasion";
                    Proficiency3TextBlock.Text = "One type of artisan's tools";
                    Proficiency4TextBlock.Text = "";
                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;
                    break;
                case "Hermit":
                    Proficiency1TextBlock.Text = "Medicine";
                    Proficiency2TextBlock.Text = "Religion";
                    Proficiency3TextBlock.Text = "Herbalism kit";
                    Proficiency4TextBlock.Text = "";
                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;
                    break;
                case "Noble":
                    Proficiency1TextBlock.Text = "History";
                    Proficiency2TextBlock.Text = "Persuasion";
                    Proficiency3TextBlock.Text = "One type of gaming set";
                    Proficiency4TextBlock.Text = "";
                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;
                    break;
                case "Outlander":
                    Proficiency1TextBlock.Text = "Athletics";
                    Proficiency2TextBlock.Text = "Survival";
                    Proficiency3TextBlock.Text = "One type of musical instrument";
                    Proficiency4TextBlock.Text = "";
                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;
                    break;
                case "Sage":
                    Proficiency1TextBlock.Text = "Arcana";
                    Proficiency2TextBlock.Text = "History";
                    Proficiency3TextBlock.Text = "";
                    Proficiency4TextBlock.Text = "";
                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = true;
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
                    break;
                default:
                    Proficiency1TextBlock.Text = "";
                    Proficiency2TextBlock.Text = "";
                    Language1ComboBox.IsEnabled = false;
                    Language2ComboBox.IsEnabled = false;
                    Language1ComboBox.SelectedIndex = -1;
                    Language2ComboBox.SelectedIndex = -1;
                    break;
            }
        }
    }
}
