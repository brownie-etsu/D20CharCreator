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

        bool isNewCharacter = true;


        OrderedDictionary equipmentList = new OrderedDictionary();
        int[,] characteristicsSave = new int[13, 4];
        Random rand = new Random();

        OrderedDictionary personalityTraitsList = new OrderedDictionary();
        OrderedDictionary idealTraitsList = new OrderedDictionary();
        OrderedDictionary bondTraitsList = new OrderedDictionary();
        OrderedDictionary flawTraitsList = new OrderedDictionary();

        public BackgroundPage()
        {
            InitializeComponent();
            InitializeCharacteristics();
        }

        private void InitializeCharacteristics()
        {
            if(isNewCharacter)
            {
                for (int a = 0; a < 13; a++)
                {
                    characteristicsSave[a, 0] = rand.Next(8);

                    for (int b = 1; b < 4; b++)
                        characteristicsSave[a, b] = rand.Next(6);
                }
            }
            
            PopulatePersonalityTraitsList();
        }

        private void PopulatePersonalityTraitsList()
        {
            personalityTraitsList.Add("Acolyte", new string[]
            {
                "I idolize a particular hero of my faith and constantly refer to that person's deeds and example.",
                "I can find common ground between the fiercest enemies, empathizing with them and always working toward peace.",
                "I see omens in every event and action. The gods try to speak to us, we just need to listen.",
                "Nothing can shake my optimistic attitude.",
                "I quote (or misquote) sacred texts and proverbs in almost every situation.",
                "I am tolerant (or intolerant) of other faiths and respect (or condemn) the worship of other gods.",
                "I've enjoyed fine food, drink, and high society among my temple’s elite. Rough living grates on me.",
                "I’ve spent so long in the temple that I have little practical experience dealing with people in the outside world."
            });
            personalityTraitsList.Add("Charlatan", new string[]
            {
                "I fall in and out of love easily, and am always pursuing someone.",
                "I have a joke for every occasion, especially occasions where humor is inappropriate.",
                "Flattery is my preferred trick for getting what I want.",
                "I’m a born gambler who can't resist taking a risk for a potential payoff.",
                "I lie about almost everything, even when there’s no good reason to.",
                "Sarcasm and insults are my weapons of choice.",
                "I keep multiple holy symbols on me and invoke whatever deity might come in useful at any given moment.",
                "I pocket anything I see that might have some value."
            });
            personalityTraitsList.Add("Criminal", new string[]
            {
                "I always have a plan for what to do when things go wrong.",
                "I am always calm, no matter what the situation. I never raise my voice or let my emotions control me.",
                "The first thing I do in a new place is note the locations of everything valuable-or where such things could be hidden.",
                "I would rather make a new friend than a new enemy.",
                "I am incredibly slow to trust. Those who seem the fairest often have the most to hide.",
                "I don't pay attention to the risks in a situation. Never tell me the odds.",
                "The best way to get me to do something is to tell me I can't do it.",
                "I blow up at the slightest insult."
            });
            personalityTraitsList.Add("Entertainer", new string[]
            {
                "I know a story relevant to almost every situation.",
                "Whenever I come to a new place, I collect local rumors and spread gossip.",
                "I’m a hopeless romantic, always searching for that \"special someone.\"",
                "Nobody stays angry at me or around me for long, since I can defuse any amount of tension.",
                "I love a good insult, even one directed at me.",
                "I get bitter if I’m not the center of attention.",
                "I’ll settle for nothing less than perfection.",
                "I change my mood or my mind as quickly as I change key in a song."
            });
            personalityTraitsList.Add("Folk Hero", new string[]
            {
                "I judge people by their actions, not their words",
                "If someone is in trouble, I’m always ready to lend help.",
                "When I set my mind to something, I follow through no matter what gets in my way.",
                "I have a strong sense of fair play and always try to find the most equitable solution to arguments.",
                "I’m confident in my own abilities and do what I can to instill confidence in others.",
                "Thinking is for other people. I prefer action.",
                "I misuse long words in an attempt to sound smarter.",
                "I get bored easily. When am I going to get on with my destiny?"
            });
            personalityTraitsList.Add("Guild Artisan", new string[]
            {
                "I believe that anything worth doing is worth doing right. I can’t help it— I’m a perfectionist.",
                "I’m a snob who looks down on those who can’t appreciate fine art.",
                "I always want to know how things work and what makes people tick",
                "I’m full of witty aphorisms and have a proverb for every occasion.",
                "I’m rude to people who lack my commitment to hard work and fair play.",
                "I like to talk at length about my profession.",
                "I don’t part with my money easily and will haggle tirelessly to get the best deal possible.",
                "I’m well known for my work, and I want to make sure everyone appreciates it. I'm always taken aback when people haven’t heard of me."
            });
            personalityTraitsList.Add("Hermit", new string[]
            {
                "I’ve been isolated for so long that I rarely speak, preferring gestures and the occasional grunt.",
                "I am utterly serene, even in the face of disaster.",
                "The leader of my community had something wise to say on every topic, and I am eager to share that wisdom.",
                "I feel tremendous empathy for all who suffer.",
                "I’m oblivious to etiquette and social expectations.",
                "I connect everything that happens to me to a grand, cosmic plan.",
                "I often get lost in my own thoughts and contemplation, becoming oblivious to my surroundings.",
                "I am working on a grand philosophical theory and love sharing my ideas."
            });
            personalityTraitsList.Add("Noble", new string[]
            {
                "My eloquent flattery makes everyone I talk to feel like the most wonderful and important person in the world.",
                "The common folk love me for my kindness and generosity.",
                "No one could doubt by looking at my regal bearing that I am a cut above the unwashed masses.",
                "I take great pains to always look my best and follow the latest fashions.",
                "I don’t like to get my hands dirty, and I won’t be caught dead in unsuitable accommodations.",
                "Despite my noble birth, I do not place myself above other folk. We all have the same blood.",
                "My favor, once lost, is lost forever.",
                "If you do me an injury, I will crush you, ruin your name, and salt your fields."
            });
            personalityTraitsList.Add("Outlander", new string[]
            {
                "I’m driven by a wanderlust that led me away from home.",
                "I watch over my friends as if they were a litter of newborn pups.",
                "I once ran twenty-five miles without stopping to warn to my clan of an approaching orc horde. I’d do it again if I had to.",
                "I have a lesson for every situation, drawn from observing nature.",
                "I place no stock in wealthy or well-mannered folk. Money and manners won’t save you from a hungry owlbear.",
                "I’m always picking things up, absently fiddling with them, and sometimes accidentally breaking them.",
                "I feel far more comfortable around animals than people.",
                "I was, in fact, raised by wolves."
            });
            personalityTraitsList.Add("Sage", new string[]
            {
                "I use polysyllabic words that convey the impression of great erudition.",
                "I've read every book in the world’s greatest libraries—or I like to boast that I have.",
                "I'm used to helping out those who aren’t as smart as I am, and I patiently explain anything and everything to others.",
                "There’s nothing I like more than a good mystery.",
                "I’m willing to listen to every side of an argument before I make my own judgment.",
                "I ... speak ... slowly ... when talking ... to idiots, ... which ... almost ... everyone ... is ... compared ... to me.",
                "I am horribly, horribly awkward in social situations.",
                "I’m convinced that people are always trying to steal my secrets."
            });
            personalityTraitsList.Add("Sailor", new string[]
            {
                "My friends know they can rely on me, no matter what.",
                "I work hard so that I can play hard when the work is done.",
                "I enjoy sailing into new ports and making new friends over a flagon of ale.",
                "I stretch the truth for the sake of a good story.",
                "To me, a tavern brawl is a nice way to get to know a new city.",
                "I never pass up a friendly wager.",
                "My language is as foul as an otyugh nest.",
                "I like a job well done, especially if I can convince someone else to do it."
            });
            personalityTraitsList.Add("Soldier", new string[]
            {
                "I'm always polite and respectful.",
                "I’m haunted by memories of war. I can’t get the images of violence out of my mind.",
                "I’ve lost too many friends, and I’m slow to make new ones.",
                "I’m full of inspiring and cautionary tales from my military experience relevant to almost every combat situation.",
                "I can stare down a hell hound without flinching.",
                "I enjoy being strong and like breaking things.",
                "I have a crude sense of humor.",
                "I face problems head-on. A simple, direct solution is the best path to success."
            });
            personalityTraitsList.Add("Urchin", new string[]
            {
                "I hide scraps of food and trinkets away in my pockets.",
                "I ask a lot of questions.",
                "I like to squeeze into small places where no one else can get to me.",
                "I sleep with my back to a wall or tree, with everything I own wrapped in a bundle in my arms.",
                "I eat like a pig and have bad manners.",
                "I think anyone who’s nice to me is hiding evil intent.",
                "I don’t like to bathe.",
                "I bluntly say what other people are hinting at or hiding."
            });
        }

        private void BackgroundListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EquipmentComboBox.IsEnabled = true;
            ListBoxItem item = BackgroundListBox.SelectedValue as ListBoxItem;
            string[] personalityListing = (string[])personalityTraitsList[BackgroundListBox.SelectedIndex];
            PersonalityTextBox.Text = personalityListing[characteristicsSave[BackgroundListBox.SelectedIndex, 0]];

            switch (item.Content as string)
            {
                case "Acolyte":
                    Proficiency1TextBlock.Text = "Insight";
                    Proficiency2TextBlock.Text = "Religion";
                    Proficiency3TextBlock.Text = "";
                    Proficiency4TextBlock.Text = "";

                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = true;

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A holy symbol\nA prayer book or prayer wheel\n5 sticks of incense\nVestments\nA set of common clothes\nA belt pouch containing 15 gp");
                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

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

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A set of fine clothes\nA disguise kit\nTen stoppered bottles filled with colored liquid\nA belt pouch containing 15 gp");
                    equipmentList.Add("Pack B", "A set of fine clothes\nA disguise kit\nA set of weighted dice\nA belt pouch containing 15 gp");
                    equipmentList.Add("Pack C", "A set of fine clothes\nA disguise kit\nA deck of marked cards\nA belt pouch containing 15 gp");
                    equipmentList.Add("Pack D", "A set of fine clothes\nA disguise kit\nA signet ring of an imaginary duke\nA belt pouch containing 15 gp");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

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

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A crowbar\nA set of dark common clothes including a hood\nA belt pouch containing 15 GP");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

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

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A musical instrument\nThe favor of an admirer -- Love letter\nA costume\nA belt pouch containing 15 gp");
                    equipmentList.Add("Pack B", "A musical instrument\nThe favor of an admirer -- Lock of hair\nA costume\nA belt pouch containing 15 gp");
                    equipmentList.Add("Pack C", "A musical instrument\nThe favor of an admirer -- Trinket\nA costume\nA belt pouch containing 15 gp");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

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

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A set of artisan’s tools\nA shovel\nAn iron pot\nA set of common clothes\nA belt pouch containing 10 gp");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Guild Artisan":
                    Proficiency1TextBlock.Text = "Insight";
                    Proficiency2TextBlock.Text = "Persuasion";
                    Proficiency3TextBlock.Text = "One type of artisan's tools";
                    Proficiency4TextBlock.Text = "";
                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A set of artisan’s tools\nA letter of introduction from your guild\nA set of traveler’s clothes\nA belt pouch containing 15 gp");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Hermit":
                    Proficiency1TextBlock.Text = "Medicine";
                    Proficiency2TextBlock.Text = "Religion";
                    Proficiency3TextBlock.Text = "Herbalism kit";
                    Proficiency4TextBlock.Text = "";

                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A scroll case stuffed full of notes from your studies/prayers\nA winter blanket\nA set of common clothes\nAn herbalism kit\n5 gp");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Noble":
                    Proficiency1TextBlock.Text = "History";
                    Proficiency2TextBlock.Text = "Persuasion";
                    Proficiency3TextBlock.Text = "One type of gaming set";
                    Proficiency4TextBlock.Text = "";

                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A set of fine clothes\nA signet ring\nA scroll of pedigree\nA purse containing 25 gp");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Outlander":
                    Proficiency1TextBlock.Text = "Athletics";
                    Proficiency2TextBlock.Text = "Survival";
                    Proficiency3TextBlock.Text = "One type of musical instrument";
                    Proficiency4TextBlock.Text = "";

                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = false;
                    Language2ComboBox.SelectedIndex = -1;

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A staff\nA hunting trap\nA trophy from an animal you killed\nA set of traveler’s clothes\nA belt pouch containing 10 g");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

                    break;

                case "Sage":
                    Proficiency1TextBlock.Text = "Arcana";
                    Proficiency2TextBlock.Text = "History";
                    Proficiency3TextBlock.Text = "";
                    Proficiency4TextBlock.Text = "";

                    Language1ComboBox.IsEnabled = true;
                    Language2ComboBox.IsEnabled = true;

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A bottle of black ink\nA quill\nA small knife\nA letter from a dead colleague posing a question you have not yet been able to answer\nA set of common clothes\nA belt pouch containing 10 gp");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

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

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A belaying pin (club)\n50 feet of silk rope\nA lucky charm \nA set of common clothes\nA belt pouch containing 10 gp");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

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

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "An insignia of rank\nA trophy taken from a fallen enemy -- Dagger\nA set of bone dice\nA set of common clothes\nA belt pouch containing 10 gp");
                    equipmentList.Add("Pack B", "An insignia of rank\nA trophy taken from a fallen enemy -- Broken blade\nA set of bone dice\nA set of common clothes\nA belt pouch containing 10 gp");
                    equipmentList.Add("Pack C", "An insignia of rank\nA trophy taken from a fallen enemy -- Piece of a banner\nA set of bone dice\nA set of common clothes\nA belt pouch containing 10 gp");
                    equipmentList.Add("Pack D", "An insignia of rank\nA trophy taken from a fallen enemy -- Dagger\nA deck of cards\nA set of common clothes\nA belt pouch containing 10 gp");
                    equipmentList.Add("Pack E", "An insignia of rank\nA trophy taken from a fallen enemy -- Broken blade\nA deck of cards\nA set of common clothes\nA belt pouch containing 10 gp");
                    equipmentList.Add("Pack F", "An insignia of rank\nA trophy taken from a fallen enemy -- Piece of a banner\nA deck of cards\nA set of common clothes\nA belt pouch containing 10 gp");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

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

                    equipmentList.Clear();
                    equipmentList.Add("Pack A", "A small knife\nA map of the city you grew up in\nA pet mouse\nA token to remember your parents by\nA set of common clothes\nA belt pouch containing 10 gp");

                    EquipmentComboBox.ItemsSource = equipmentList.Keys;
                    EquipmentComboBox.SelectedIndex = 0;
                    EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();

                    break;
            }
        }

        private void EquipmentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem item = BackgroundListBox.SelectedValue as ListBoxItem;
            EquipmentTextBox.Text = equipmentList[EquipmentComboBox.SelectedIndex].ToString();
        }
    }
}
