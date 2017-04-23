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
    /// Interaction logic for ClassPage.xaml
    /// </summary>
    public partial class ClassPage : Page
    {
        OrderedDictionary hitDiceList = new OrderedDictionary();
        OrderedDictionary hitPoints1stLevelList = new OrderedDictionary();
        OrderedDictionary hitPointsHigherLevelList = new OrderedDictionary();

        OrderedDictionary featuresList = new OrderedDictionary();

        int numberOfSkills;

        public ClassPage()
        {
            InitializeComponent();
            InitializeHitPoints();
            PopulateFeaturesList();
        }

        private void InitializeHitPoints()
        {
            PopulateHitDiceList();
            PopulateHitPoints1stLevelList();
            PopulateHitPointsHigherLevelList();
        }

        private void PopulateHitDiceList()
        {
            hitDiceList.Clear();

            hitDiceList.Add("Barbarian", "1d12 per Barbarian level");
            hitDiceList.Add("Cleric", "1d8 per Cleric level");
            hitDiceList.Add("Rogue", "1d8 per Rogue level");
            hitDiceList.Add("Wizard", "1d6 per Wizard level");
        }

        private void PopulateHitPoints1stLevelList()
        {
            hitPoints1stLevelList.Clear();

            hitPoints1stLevelList.Add("Barbarian", "12 + your Constitution modifier");
            hitPoints1stLevelList.Add("Cleric", "8 + your Constitution modifier");
            hitPoints1stLevelList.Add("Rogue", "8 + your Constitution modifier");
            hitPoints1stLevelList.Add("Wizard", "6 + your Constitution modifier");
        }

        private void PopulateHitPointsHigherLevelList()
        {
            hitPointsHigherLevelList.Clear();

            hitPointsHigherLevelList.Add("Barbarian", "1d12 (or 7) + your Constitution modifier per Barbarian level after 1st");
            hitPointsHigherLevelList.Add("Cleric", "1d8 (or 5) + your Constitution modifier per Cleric level after 1st");
            hitPointsHigherLevelList.Add("Rogue", "1d8 (or 5) + your Constitution modifier per Rogue level after 1st");
            hitPointsHigherLevelList.Add("Wizard", "1d6 (or 4) + your Constitution modifier per Wizard level after 1st");
        }

        private void PopulateFeaturesList()
        {
            featuresList.Add("Barbarian", "Rage\nUnarmored Defense\nReckless Attack");
            featuresList.Add("Cleric", "Spellcasting\nCantrips\nPreparing and Casting Spells\nSpellcasting Ability\nRitual Casting\nSpellcasting Focus\nDivine Domain\nDomain Spells");
            featuresList.Add("Rogue", "Expertise\nSneak Attack\nThieves' Cant");
            featuresList.Add("Wizard", "Spellcasting\nCantrips\nSpellbook\nPreparing and Casting Spells\nSpellcasting Ability\nRitual Casting\nSpellcasting Focus\nLearning Spells of 1st Level and Higher\nArcane Recovery");
        }

        private void ClassComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HitDiceTextBox.Text = hitDiceList[ClassListBox.SelectedIndex].ToString();
            HitPoints1stLevelTextBox.Text = hitPoints1stLevelList[ClassListBox.SelectedIndex].ToString();
            HitPointsHigherLevelTextBox.Text = hitPoints1stLevelList[ClassListBox.SelectedIndex].ToString();

            ListBoxItem item = ClassListBox.SelectedValue as ListBoxItem;
            List<string> classSkillsList = new List<string>();

            AddButton.IsEnabled = true;

            classSkillsList.Clear();

            FeaturesTextBox.Text = featuresList[ClassListBox.SelectedIndex].ToString();

            switch (item.Content as string)
            {
                case "Barbarian":
                    classSkillsList.Add("Animal Handling");
                    classSkillsList.Add("Athletics");
                    classSkillsList.Add("Intimidation");
                    classSkillsList.Add("Nature");
                    classSkillsList.Add("Perception");
                    classSkillsList.Add("Survival");
                    numberOfSkills = 2;
                    SkillsComboBox.ItemsSource = classSkillsList;
                    SkillsListBox.ItemsSource = new List<string>();
                    SkillsComboBox.SelectedIndex = 0;
                    break;
                case "Cleric":
                    classSkillsList.Add("History");
                    classSkillsList.Add("Insight");
                    classSkillsList.Add("Medicine");
                    classSkillsList.Add("Persuasion");
                    classSkillsList.Add("Religion");
                    numberOfSkills = 2;
                    SkillsComboBox.ItemsSource = classSkillsList;
                    SkillsListBox.ItemsSource = new List<string>();
                    SkillsComboBox.SelectedIndex = 0;
                    break;
                case "Rogue":
                    classSkillsList.Add("Acrobatics");
                    classSkillsList.Add("Athletics");
                    classSkillsList.Add("Deception");
                    classSkillsList.Add("Insight");
                    classSkillsList.Add("Intimidation");
                    classSkillsList.Add("Investigation");
                    classSkillsList.Add("Perception");
                    classSkillsList.Add("Performance");
                    classSkillsList.Add("Persuasion");
                    classSkillsList.Add("Sleight of Hand");
                    classSkillsList.Add("Stealth");
                    numberOfSkills = 4;
                    SkillsComboBox.ItemsSource = classSkillsList;
                    SkillsListBox.ItemsSource = new List<string>();
                    SkillsComboBox.SelectedIndex = 0;
                    break;
                case "Wizard":
                    classSkillsList.Add("Arcana");
                    classSkillsList.Add("History");
                    classSkillsList.Add("Insight");
                    classSkillsList.Add("Investigation");
                    classSkillsList.Add("Medicine");
                    classSkillsList.Add("Religion");
                    numberOfSkills = 2;
                    SkillsComboBox.ItemsSource = classSkillsList;
                    SkillsListBox.ItemsSource = new List<string>();
                    SkillsComboBox.SelectedIndex = 0;
                    break;
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if(SkillsListBox.SelectedIndex >= 0)
            {
                List<string> list1 = SkillsComboBox.ItemsSource as List<string>;
                List<string> list2 = SkillsListBox.ItemsSource as List<string>;

                list1.Add(list2[SkillsListBox.SelectedIndex]);
                list1.Sort();
                list2.Remove((string)SkillsListBox.SelectedValue);

                SkillsComboBox.ItemsSource = list1;
                SkillsListBox.ItemsSource = list2;
                SkillsComboBox.Items.Refresh();
                SkillsListBox.Items.Refresh();

                SkillsListBox.SelectedIndex = 0;

                if (SkillsListBox.Items.Count < numberOfSkills)
                {
                    AddButton.IsEnabled = true;
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (SkillsComboBox.SelectedIndex >= 0)
            {
                List<string> list1 = SkillsComboBox.ItemsSource as List<string>;
                List<string> list2 = SkillsListBox.ItemsSource as List<string>;

                list2.Add(list1[SkillsComboBox.SelectedIndex]);
                list1.Remove((string)SkillsComboBox.SelectedValue);

                SkillsComboBox.ItemsSource = list1;
                SkillsListBox.ItemsSource = list2;
                SkillsComboBox.Items.Refresh();
                SkillsListBox.Items.Refresh();

                SkillsComboBox.SelectedIndex = 0;

                if (SkillsListBox.Items.Count == numberOfSkills)
                {
                    AddButton.IsEnabled = false;
                }
                    
            }
        }
    }
}
