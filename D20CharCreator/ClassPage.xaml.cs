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
        //Lists for holding hit point related data
        OrderedDictionary hitDiceList = new OrderedDictionary();
        OrderedDictionary hitPoints1stLevelList = new OrderedDictionary();
        OrderedDictionary hitPointsHigherLevelList = new OrderedDictionary();

        //Lists for holding proficiency related data
        OrderedDictionary armorProficiencyList = new OrderedDictionary();
        OrderedDictionary weaponsProficiencyList = new OrderedDictionary();
        OrderedDictionary toolsProficiencyList = new OrderedDictionary();
        OrderedDictionary throwsProficiencyList = new OrderedDictionary();

        //List for holding equipment related data
        OrderedDictionary equipmentList = new OrderedDictionary();

        //List for holding feature related data
        OrderedDictionary featuresList = new OrderedDictionary();

        //Int for holding the number of skills that a class can have
        int numberOfSkills;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClassPage()
        {
            InitializeComponent();
            InitializeHitPoints();
            InitializeProficiencies();
            PopulateFeaturesList();
        }

        public ClassPage(Character charToEdit)
        {
            InitializeComponent();
            InitializeHitPoints();
            InitializeProficiencies();
            PopulateFeaturesList();

            ClassListBox.SelectedIndex = (int)charToEdit.Class.Type;

            AddSkills(charToEdit.Class.Skills);

            EquipmentComboBox.SelectedIndex = charToEdit.Class.Equipment;
        }

        /// <summary>
        /// Initializes the hit point lists.
        /// </summary>
        private void InitializeHitPoints()
        {
            PopulateHitDiceList();
            PopulateHitPoints1stLevelList();
            PopulateHitPointsHigherLevelList();
        }

        /// <summary>
        /// Initializes the proficiency lists.
        /// </summary>
        private void InitializeProficiencies()
        {
            PopulateArmorProficiencyList();
            PopulateWeaponsProficiencyList();
            PopulateToolsProficiencyList();
            PopulateThrowsProficiencyList();
        }

        /// <summary>
        /// Populates the hit dice list.
        /// </summary>
        private void PopulateHitDiceList()
        {
            hitDiceList.Add("Barbarian", "1d12 per Barbarian level");
            hitDiceList.Add("Cleric", "1d8 per Cleric level");
            hitDiceList.Add("Rogue", "1d8 per Rogue level");
            hitDiceList.Add("Wizard", "1d6 per Wizard level");
        }

        /// <summary>
        /// Populates the hit points -- 1st level list.
        /// </summary>
        private void PopulateHitPoints1stLevelList()
        {
            hitPoints1stLevelList.Add("Barbarian", "12 + your Constitution modifier");
            hitPoints1stLevelList.Add("Cleric", "8 + your Constitution modifier");
            hitPoints1stLevelList.Add("Rogue", "8 + your Constitution modifier");
            hitPoints1stLevelList.Add("Wizard", "6 + your Constitution modifier");
        }

        /// <summary>
        /// Populates the hit points -- higher level list.
        /// </summary>
        private void PopulateHitPointsHigherLevelList()
        {
            hitPointsHigherLevelList.Add("Barbarian", "1d12 (or 7) + your Constitution modifier per Barbarian level after 1st");
            hitPointsHigherLevelList.Add("Cleric", "1d8 (or 5) + your Constitution modifier per Cleric level after 1st");
            hitPointsHigherLevelList.Add("Rogue", "1d8 (or 5) + your Constitution modifier per Rogue level after 1st");
            hitPointsHigherLevelList.Add("Wizard", "1d6 (or 4) + your Constitution modifier per Wizard level after 1st");
        }

        /// <summary>
        /// Populates the armor proficiency list.
        /// </summary>
        private void PopulateArmorProficiencyList()
        {
            armorProficiencyList.Add("Barbarian", "Light armor, medium armor, shields");
            armorProficiencyList.Add("Cleric", "Light armor, medium armor, shields");
            armorProficiencyList.Add("Rogue", "Light armor, medium armor, shields");
            armorProficiencyList.Add("Wizard", "");
        }

        /// <summary>
        /// Populates the weapons proficiency list.
        /// </summary>
        private void PopulateWeaponsProficiencyList()
        {
            weaponsProficiencyList.Add("Barbarian", "Simple weapons, martial weapons");
            weaponsProficiencyList.Add("Cleric", "Simple weapons");
            weaponsProficiencyList.Add("Rogue", "Simple weapons, hand crossbows,  longswords, rapiers, shortswords");
            weaponsProficiencyList.Add("Wizard", "Daggers, darts, slings, quarterstaffs, light crossbows");
        }

        /// <summary>
        /// Populates the tools proficiency list.
        /// </summary>
        private void PopulateToolsProficiencyList()
        {
            toolsProficiencyList.Add("Barbarian", "");
            toolsProficiencyList.Add("Cleric", "");
            toolsProficiencyList.Add("Rogue", "Thieves' tools");
            toolsProficiencyList.Add("Wizard", "");
        }

        /// <summary>
        /// Populates the saving throws proficiency list.
        /// </summary>
        private void PopulateThrowsProficiencyList()
        {
            throwsProficiencyList.Add("Barbarian", "Strength, Constitution");
            throwsProficiencyList.Add("Cleric", "Wisdom, Charisma");
            throwsProficiencyList.Add("Rogue", "Dexterity, Intelligence");
            throwsProficiencyList.Add("Wizard", "Intelligence, Wisdom");
        }

        /// <summary>
        /// Populates the features list.
        /// </summary>
        private void PopulateFeaturesList()
        {
            featuresList.Add("Barbarian", "Rage\nUnarmored Defense\nReckless Attack");
            featuresList.Add("Cleric", "Spellcasting\nCantrips\nPreparing and Casting Spells\nSpellcasting Ability\nRitual Casting\nSpellcasting Focus\nDivine Domain\nDomain Spells");
            featuresList.Add("Rogue", "Expertise\nSneak Attack\nThieves' Cant");
            featuresList.Add("Wizard", "Spellcasting\nCantrips\nSpellbook\nPreparing and Casting Spells\nSpellcasting Ability\nRitual Casting\nSpellcasting Focus\nLearning Spells of 1st Level and Higher\nArcane Recovery");
        }

        /// <summary>
        /// Handles when the player selects a new class.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void ClassComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Update hit point related text boxes
            HitDiceTextBox.Text = hitDiceList[ClassListBox.SelectedIndex].ToString();
            HitPoints1stLevelTextBox.Text = hitPoints1stLevelList[ClassListBox.SelectedIndex].ToString();
            HitPointsHigherLevelTextBox.Text = hitPointsHigherLevelList[ClassListBox.SelectedIndex].ToString();

            //Update proficiency related text boxes
            ArmorProficiencyTextBox.Text =  armorProficiencyList[ClassListBox.SelectedIndex].ToString();
            WeaponsProficiencyTextBox.Text = weaponsProficiencyList[ClassListBox.SelectedIndex].ToString();
            ToolsProficiencyTextBox.Text = toolsProficiencyList[ClassListBox.SelectedIndex].ToString();
            ThrowsProficiencyTextBox.Text = throwsProficiencyList[ClassListBox.SelectedIndex].ToString();

            //Enable the equipment combo box
            EquipmentComboBox.IsEnabled = true;

            //Initialize the class skills list
            List<string> classSkillsList = new List<string>();

            //The skills list will be cleared, so enable the buttons
            AddButton.IsEnabled = true;
            RemoveButton.IsEnabled = true;
            SkillsComboBox.IsEnabled = true;
            FeaturesTextBox.Text = featuresList[ClassListBox.SelectedIndex].ToString();

            //Take a look at the selected item
            ListBoxItem item = ClassListBox.SelectedValue as ListBoxItem;
            switch (item.Content as string)
            {
                case "Barbarian":
                    //Set the skills
                    classSkillsList.Add("Animal Handling");
                    classSkillsList.Add("Athletics");
                    classSkillsList.Add("Intimidation");
                    classSkillsList.Add("Nature");
                    classSkillsList.Add("Perception");
                    classSkillsList.Add("Survival");

                    //Set the equipment
                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A greataxe\nTwo handaxes\nAn explorer's pack and four javelins");
                    equipmentList.Add("Pack B", "Any martial melee weapon\nTwo handaxes\nAn explorer's pack and four javelins");
                    equipmentList.Add("Pack C", "A greataxe\nAny simple weapon\nAn explorer's pack and four javelins");
                    equipmentList.Add("Pack D", "Any martial melee weapon\nAny simple weapon\nAn explorer's pack and four javelins");

                    //Set the number of skills that a player can choose
                    numberOfSkills = 2;

                    break;

                case "Cleric":
                    //Set the skills
                    classSkillsList.Add("History");
                    classSkillsList.Add("Insight");
                    classSkillsList.Add("Medicine");
                    classSkillsList.Add("Persuasion");
                    classSkillsList.Add("Religion");

                    //Set the equipment
                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A mace\nScale mail\nA light crossbow and 20 bolts\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack B", "A warhammer\nScale mail\nA light crossbow and 20 bolts\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack C", "A mace\nLeather armor\nA light crossbow and 20 bolts\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack D", "A warhammer\nLeather armor\nA light crossbow and 20 bolts\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack E", "A mace\nChain mail\nA light crossbow and 20 bolts\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack F", "A warhammer\nChain mail\nA light crossbow and 20 bolts\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack G", "A mace\nScale mail\nAny simple weapon\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack H", "A warhammer\nScale mail\nAny simple weapon\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack I", "A mace\nLeather armor\nAny simple weapon\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack J", "A warhammer\nLeather armor\nAny simple weapon\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack K", "A mace\nChain mail\nAny simple weapon\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack L", "A warhammer\nChain mail\nAny simple weapon\nA priest's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack M", "A mace\nScale mail\nA light crossbow and 20 bolts\nAn explorer's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack N", "A warhammer\nScale mail\nA light crossbow and 20 bolts\nAn explorer's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack O", "A mace\nLeather armor\nA light crossbow and 20 bolts\nAn explorer's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack P", "A warhammer\nLeather armor\nA light crossbow and 20 bolts\nAn explorer's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack Q", "A mace\nChain mail\nA light crossbow and 20 bolts\nAn explorer's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack R", "A warhammer\nChain mail\nA light crossbow and 20 bolts\nAn explorer's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack S", "A mace\nScale mail\nAny simple weapon\nAn explorer's pack\nA shield and a holy symbol");
                    equipmentList.Add("Pack T", "A warhammer\nScale mail\nAny simple weapon\nAn explorer's pack\nA shield and a holy symbol");

                    //Set the number of skills that a player can choose
                    numberOfSkills = 2;

                    break;

                case "Rogue":
                    //Set the skills
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

                    //Set the equipment
                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A rapier\nA shortbow and quiver of 20 arrows\nA burglar's pack\nLeather armor, two daggers, and thieves' tools");
                    equipmentList.Add("Pack B", "A shortsword\nA shortbow and quiver of 20 arrows\nA burglar's pack\nLeather armor, two daggers, and thieves' tools");
                    equipmentList.Add("Pack C", "A rapier\nA shortsword\nA burglar's pack\nLeather armor, two daggers, and thieves' tools");
                    equipmentList.Add("Pack D", "A rapier\nA shortbow and quiver of 20 arrows\nA dungeoneer's pack\nLeather armor, two daggers, and thieves' tools");
                    equipmentList.Add("Pack E", "A shortsword\nA shortbow and quiver of 20 arrows\nA dungeoneer's pack\nLeather armor, two daggers, and thieves' tools");
                    equipmentList.Add("Pack F", "A rapier\nA shortsword\nA dungeoneer's pack\nLeather armor, two daggers, and thieves' tools");
                    equipmentList.Add("Pack G", "A rapier\nA shortbow and quiver of 20 arrows\nA explorer's pack\nLeather armor, two daggers, and thieves' tools");
                    equipmentList.Add("Pack H", "A shortsword\nA shortbow and quiver of 20 arrows\nA explorer's pack\nLeather armor, two daggers, and thieves' tools");
                    equipmentList.Add("Pack I", "A rapier\nA shortsword\nA explorer's pack\nLeather armor, two daggers, and thieves' tools");

                    //Set the number of skills that a player can choose
                    numberOfSkills = 4;

                    break;

                case "Wizard":
                    //Set the skills
                    classSkillsList.Add("Arcana");
                    classSkillsList.Add("History");
                    classSkillsList.Add("Insight");
                    classSkillsList.Add("Investigation");
                    classSkillsList.Add("Medicine");
                    classSkillsList.Add("Religion");

                    //Set the equipment
                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A quarterstaff\nA component pouch\nA scholar's pack\nA spellbook");
                    equipmentList.Add("Pack B", "A dagger\nA component pouch\nA scholar's pack\nA spellbook");
                    equipmentList.Add("Pack C", "A quarterstaff\nAn arcane focus\nA scholar's pack\nA spellbook");
                    equipmentList.Add("Pack D", "A dagger\nAn arcane focus\nA scholar's pack\nA spellbook");
                    equipmentList.Add("Pack E", "A quarterstaff\nA component pouch\nA explorer's pack\nA spellbook");
                    equipmentList.Add("Pack F", "A dagger\nA component pouch\nA explorer's pack\nA spellbook");
                    equipmentList.Add("Pack G", "A quarterstaff\nAn arcane focus\nA explorer's pack\nA spellbook");
                    equipmentList.Add("Pack H", "A dagger\nAn arcane focus\nA explorer's pack\nA spellbook");

                    //Set the number of skills that a player can choose
                    numberOfSkills = 2;

                    break;
            }

            //Update equipment related fields
            EquipmentComboBox.ItemsSource = equipmentList.Keys;
            EquipmentComboBox.SelectedIndex = 0;
            EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

            //Update skills related fields
            SkillsComboBox.ItemsSource = classSkillsList;
            SkillsListBox.ItemsSource = new List<string>();
            SkillsComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles when the remove button is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            //If there was a selection
            if(SkillsListBox.SelectedIndex >= 0)
            {
                //Load the items of the combo box and list box as string lists
                List<string> list1 = SkillsComboBox.ItemsSource as List<string>;
                List<string> list2 = SkillsListBox.ItemsSource as List<string>;

                //Take the selected item out of the list box and into the combo box
                list1.Add(list2[SkillsListBox.SelectedIndex]);
                list1.Sort();
                list2.Remove((string)SkillsListBox.SelectedValue);
                SkillsComboBox.ItemsSource = list1;
                SkillsListBox.ItemsSource = list2;
                SkillsComboBox.Items.Refresh();
                SkillsListBox.Items.Refresh();

                //Reset the selected index of the list box to the first item
                SkillsListBox.SelectedIndex = 0;

                //If the add button was disabled, re-enable it
                if (SkillsListBox.Items.Count < numberOfSkills)
                    AddButton.IsEnabled = true;
            }
        }

        /// <summary>
        /// Handles when the add button is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //If there was a selection
            if (SkillsComboBox.SelectedIndex >= 0)
            {
                //Load the items of the combo box and list box as string lists
                List<string> list1 = SkillsComboBox.ItemsSource as List<string>;
                List<string> list2 = SkillsListBox.ItemsSource as List<string>;

                //Take the selected item out of the combo box and into the list box
                list2.Add(list1[SkillsComboBox.SelectedIndex]);
                list1.Remove((string)SkillsComboBox.SelectedValue);
                SkillsComboBox.ItemsSource = list1;
                SkillsListBox.ItemsSource = list2;
                SkillsComboBox.Items.Refresh();
                SkillsListBox.Items.Refresh();

                //Reset the selected index of the combo box to the first item
                SkillsComboBox.SelectedIndex = 0;

                //If the player has added the maximum number of skills, disable the add button
                if (SkillsListBox.Items.Count == numberOfSkills)
                    AddButton.IsEnabled = false;
            }
        }

        private void AddSkills(params int[] skills)
        {
            List<string> combo = SkillsComboBox.ItemsSource as List<string>;
            List<string> list = SkillsListBox.ItemsSource as List<string>;

            foreach (int i in skills)
            {
                list.Add(combo[i]);
            }

            for (int i = 0; i < skills.Length; i++)
            {
                combo.RemoveAt(skills[i]);

                for (int j = i + 1; j < skills.Length; j++)
                {
                    if (skills[j] > j)
                    {
                        skills[j]--;
                    }
                }
            }

            if (SkillsListBox.Items.Count >= numberOfSkills)
                AddButton.IsEnabled = false;
        }

        /// <summary>
        /// Handles when the player selects an equipment pack.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void EquipmentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //If there was a selection, update the equipment text box
            if(EquipmentComboBox.SelectedIndex >= 0)
                EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();
        }
    }
}
