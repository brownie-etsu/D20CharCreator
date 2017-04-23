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
        public bool isNewCharacter = true;
        int rollsLeft = 3;

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

        private void Randomize()
        {
            for (int a = 0; a < 13; a++)
            {
                characteristicsSave[a, 0] = rand.Next(8);

                for (int b = 1; b < 4; b++)
                    characteristicsSave[a, b] = rand.Next(6);
            }
        }

        private void InitializeCharacteristics()
        {
            if(isNewCharacter)
                Randomize();
            
            PopulatePersonalityTraitsList();
            PopulateIdealTraitsList();
            PopulateBondTraitsList();
            PopulateFlawTraitsList();

            RollsTextBlock.Text = "Rolls: " + rollsLeft;
        }

        private void PopulatePersonalityTraitsList()
        {
            personalityTraitsList.Clear();

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

        private void PopulateIdealTraitsList()
        {
            idealTraitsList.Clear();

            idealTraitsList.Add("Acolyte", new string[]
            {
                "Tradition. The ancient traditions of worship and sacrifice must be preserved and upheld. (Lawful)",
                "Charity. I always try to help those in need, no matter what the personal cost. (Good)",
                "Change. We must help bring about the changes the gods are constantly working in the world. (Chaotic)",
                "Power. I hope to one day rise to the top of my faith’s religious hierarchy. (Lawful)",
                "Faith. I trust that my deity will guide my actions, I have faith that if I work hard, things will go well. (Lawful)",
                "Aspiration. I seek to prove myself worthy of my god’s favor by matching my actions against his or her teachings. (Any)"
            });
            idealTraitsList.Add("Charlatan", new string[]
            {
                "Independence. I am a free spirit— no one tells me what to do. (Chaotic)",
                "Fairness. I never target people who can’t afford to lose a few coins. (Lawful)",
                "Charity. I distribute the money I acquire to the people who really need it. (Good)",
                "Creativity. I never run the same con twice. (Chaotic)",
                "Friendship. Material goods come and go. Bonds of friendship last forever. (Good)",
                "Aspiration. I’m determined to make something of myself. (Any)"
            });
            idealTraitsList.Add("Criminal", new string[]
            {
                "Honor. I don’t steal from others in the trade. (Lawful)",
                "Freedom. Chains are meant to be broken, as are those who would forge them. (Chaotic)",
                "Charity. I steal from the wealthy so that I can help people in need. (Good)",
                "Greed. I will do whatever it takes to become wealthy. (Evil)",
                "People. I’m loyal to my friends, not to any ideals, and everyone else can take a trip down the Styx for all I care. (Neutral)",
                "Redemption. There’s a spark of good in everyone. (Good)"
            });
            idealTraitsList.Add("Entertainer", new string[]
            {
                "Beauty. When I perform, I make the world better than it was. (Good)",
                "Tradition. The stories, legends, and songs of the past must never be forgotten, for they teach us who we are. (Lawful)",
                "Creativity. The world is in need of new ideas and bold action. (Chaotic)",
                "Greed. I’m only in it for the money and fame. (Evil)",
                "People. I like seeing the smiles on people’s faces when I perform. That’s all that matters. (Neutral)",
                "Honesty. Art should reflect the soul; it should come from within and reveal who we really are. (Any)"
            });
            idealTraitsList.Add("Folk Hero", new string[]
            {
                "Respect. People deserve to be treated with dignity and respect. (Good)",
                "Fairness. No one should get preferential treatment before the law, and no one is above the law. (Lawful)",
                "Freedom. Tyrants must not be allowed to oppress the people. (Chaotic)",
                "Might. If I become strong, I can take what I want—what I deserve. (Evil)",
                "Sincerity. There’s no good in pretending to be something I’m not. (Neutral)",
                "Destiny. Nothing and no one can steer me away from my higher calling. (Any)"
            });
            idealTraitsList.Add("Guild Artisan", new string[]
            {
                "Community. It is the duty of all civilized people to strengthen the bonds of community and the security of civilization. (Lawful)",
                "Generosity. My talents were given to me so that I could use them to benefit the world. (Good)",
                "Freedom. Everyone should be free to pursue his or her own livelihood. (Chaotic)",
                "Greed. I’m only in it for the money. (Evil)",
                "People. I’m committed to the people I care about, not to ideals. (Neutral)",
                "Aspiration. I work hard to be the best there is at my craft."
            });
            idealTraitsList.Add("Hermit", new string[]
            {
                "Greater Good. My gifts are meant to be shared with all, not used for my own benefit. (Good)",
                "Logic. Emotions must not cloud our sense of what is right and true, or our logical thinking. (Lawful)",
                "Free Thinking. Inquiry and curiosity are the pillars of progress. (Chaotic)",
                "Power. Solitude and contemplation are paths toward mystical or magical power. (Evil)",
                "Live and Let Live. Meddling in the affairs of others only causes trouble. (Neutral)",
                "Self-Knowledge. If you know yourself, there’s nothing left to know. (Any)"
            });
            idealTraitsList.Add("Noble", new string[]
            {
                "Respect. Respect is due to me because of my position, but all people regardless of station deserve to be treated with dignity. (Good)",
                "Responsibility. It is my duty to respect the authority of those above me, just as those below me must respect mine. (Lawful)",
                "Independence. I must prove that I can handle myself without the coddling of my family. (Chaotic)",
                "Power. If I can attain more power, no one will tell me what to do. (Evil)",
                "Family. Blood runs thicker than water. (Any)",
                "Noble Obligation. It is my duty to protect and care for the people beneath me. (Good)"
            });
            idealTraitsList.Add("Outlander", new string[]
            {
                "Change. Life is like the seasons, in constant change, and we must change with it. (Chaotic)",
                "Greater Good. It is each person’s responsibility to make the most happiness for the whole tribe. (Good)",
                "Honor. If I dishonor myself, I dishonor my whole clan. (Lawful)",
                "Might. The strongest are meant to rule. (Evil)",
                "Nature. The natural world is more important than all the constructs of civilization. (Neutral)",
                "Glory. I must earn glory in battle, for myself and my clan. (Any)"
            });
            idealTraitsList.Add("Sage", new string[]
            {
                "Knowledge. The path to power and self-improvement is through knowledge. (Neutral)",
                "Beauty. What is beautiful points us beyond itself toward what is true. (Good)",
                "Logic. Emotions must not cloud our logical thinking. (Lawful)",
                "No Limits. Nothing should fetter the infinite possibility inherent in all existence. (Chaotic)",
                "Power. Knowledge is the path to power and domination. (Evil)",
                "Self-Improvement. The goal of a life of study is the betterment of oneself. (Any)"
            });
            idealTraitsList.Add("Sailor", new string[]
            {
                "Respect. The thing that keeps a ship together is mutual respect between captain and crew. (Good)",
                "Fairness. We all do the work, so we all share in the rewards. (Lawful)",
                "Freedom. The sea is freedom—the freedom to go anywhere and do anything. (Chaotic)",
                "Mastery. I’m a predator, and the other ships on the sea are my prey. (Evil)",
                "People. I’m committed to my crewmates, not to ideals. (Neutral)",
                "Aspiration. Someday I’ll own my own ship and chart my own destiny. (Any)"
            });
            idealTraitsList.Add("Soldier", new string[]
            {
                "Greater Good. Our lot is to lay down our lives in defense of others. (Good)",
                "Responsibility. I do what I must and obey just authority. (Lawful)",
                "Independence. When people follow orders blindly, they embrace a kind of tyranny. (Chaotic)",
                "Might. In life as in war, the stronger force wins. (Evil)",
                "Live and Let Live. Ideals aren’t worth killing over or going to war for. (Neutral)",
                "Nation. My city, nation, or people are all that matter. (Any)"
            });
            idealTraitsList.Add("Urchin", new string[]
            {
                "Respect. All people, rich or poor, deserve respect. (Good)",
                "Community. We have to take care of each other, because no one else is going to do it. (Lawful)",
                "Change. The low are lifted up, and the high and mighty are brought down. Change is the nature of things. (Chaotic)",
                "Retribution. The rich need to be shown what life and death are like in the gutters. (Evil)",
                "People. I help the people who help me—that’s what keeps us alive. (Neutral)",
                "Aspiration. I'm going to prove that I'm worthy of a better life."
            });
        }

        private void PopulateBondTraitsList()
        {
            bondTraitsList.Clear();

            bondTraitsList.Add("Acolyte", new string[]
            {
                "I would die to recover an ancient relic of my faith that was lost long ago.",
                "I will someday get revenge on the corrupt temple hierarchy who branded me a heretic.",
                "I owe my life to the priest who took me in when my parents died.",
                "Everything I do is for the common people.",
                "I will do anything to protect the temple where I served.",
                "I seek to preserve a sacred text that my enemies consider heretical and seek to destroy."
            });
            bondTraitsList.Add("Charlatan", new string[]
            {
                "I fleeced the wrong person and must work to ensure that this individual never crosses paths with me or those I care about.",
                "I owe everything to my mentor—a horrible person who’s probably rotting in jail somewhere.",
                "Somewhere out there, I have a child who doesn’t know me. I’m making the world better for him or her.",
                "I come from a noble family, and one day I’ll reclaim my lands and title from those who stole them from me.",
                "A powerful person killed someone I love. Some day soon, I’ll have my revenge",
                "I swindled and ruined a person who didn’t deserve it. I seek to atone for my misdeeds but might never be able to forgive myself."
            });
            bondTraitsList.Add("Criminal", new string[]
            {
                "I’m trying to pay off an old debt I owe to a generous benefactor.",
                "My ill-gotten gains go to support my family.",
                "Something important was taken from me, and I aim to steal it back.",
                "I will become the greatest thief that ever lived.",
                "I’m guilty of a terrible crime. I hope I can redeem myself for it.",
                "Someone I loved died because of a mistake I made. That will never happen again."
            });
            bondTraitsList.Add("Entertainer", new string[]
            {
                "My instrument is my most treasured possession, and it reminds me of someone I love.",
                "Someone stole my precious instrument, and someday I’ll get it back.",
                "I want to be famous, whatever it takes.",
                "I idolize a hero of the old tales and measure my deeds against that person’s.",
                "I will do anything to prove myself superior to my hated rival.",
                "I would do anything for the other members of my old troupe."
            });
            bondTraitsList.Add("Folk Hero", new string[]
            {
                "I have a family, but I have no idea where they are. One day, I hope to see them again.",
                "I worked the land, I love the land, and I will protect the land.",
                "A proud noble once gave me a horrible beating, and I will take my revenge on any bully I encounter.",
                "My tools are symbols of my past life, and I carry them so that I will never forget my roots.",
                "I protect those who cannot protect themselves.",
                "I wish my childhood sweetheart had come with me to pursue my destiny."
            });
            bondTraitsList.Add("Guild Artisan", new string[]
            {
                "The workshop where I learned my trade is the most important place in the world to me.",
                "I created a great work for someone, and then found them unworthy to receive it. I’m still looking for someone worthy.",
                "I owe my guild a great debt for forging me into the person I am today.",
                "I pursue wealth to secure someone’s love.",
                "One day I will return to my guild and prove that I am the greatest artisan of them all.",
                "I will get revenge on the evil forces that destroyed my place of business and ruined my livelihood."
            });
            bondTraitsList.Add("Hermit", new string[]
            {
                "Nothing is more important than the other members of my hermitage, order, or association.",
                "I entered seclusion to hide from the ones who might still be hunting me. I must someday confront them.",
                "I’m still seeking the enlightenment I pursued in my seclusion, and it still eludes me.",
                "I entered seclusion because I loved someone I could not have.",
                "Should my discovery come to light, it could bring ruin to the world.",
                "My isolation gave me great insight into a great evil that only I can destroy."
            });
            bondTraitsList.Add("Noble", new string[]
            {
                "I will face any challenge to win the approval of my family.",
                "My house’s alliance with another noble family must be sustained at all costs.",
                "Nothing is more important than the other members of my family.",
                "I am in love with the heir of a family that my family despises.",
                "My loyalty to my sovereign is unwavering.",
                "The common folk must see me as a hero of the people."
            });
            bondTraitsList.Add("Outlander", new string[]
            {
                "My family, clan, or tribe is the most important thing in my life, even when they are far from me.",
                "An injury to the unspoiled wilderness of my home is an injury to me.",
                "I will bring terrible wrath down on the evildoers who destroyed my homeland.",
                "I am the last of my tribe, and it is up to me to ensure their names enter legend.",
                "I suffer awful visions of a coming disaster and will do anything to prevent it.",
                "It is my duty to provide children to sustain my tribe."
            });
            bondTraitsList.Add("Sage", new string[]
            {
                "It is my duty to protect my students.",
                "I have an ancient text that holds terrible secrets that must not fall into the wrong hands.",
                "I work to preserve a library, university, scriptorium, or monastery.",
                "My life’s work is a series of tomes related to a specific field of lore.",
                "I've been searching my whole life for the answer to a certain question.",
                "I sold my soul for knowledge. I hope to do great deeds and win it back."
            });
            bondTraitsList.Add("Sailor", new string[]
            {
                "I’m loyal to my captain first, everything else second.",
                "The ship is most important—crewmates and captains come and go.",
                "I’ll always remember my first ship.",
                "In a harbor town, I have a paramour whose eyes nearly stole me from the sea.",
                "I was cheated out of my fair share of the profits, and I want to get my due.",
                "Ruthless pirates murdered my captain and crewmates, plundered our ship, and left me to die. Vengeance will be mine."
            });
            bondTraitsList.Add("Soldier", new string[]
            {
                "I would still lay down my life for the people I served with.",
                "Someone saved my life on the battlefield. To this day, I will never leave a friend behind.",
                "My honor is my life.",
                "I’ll never forget the crushing defeat my company suffered or the enemies who dealt it.",
                "Those who fight beside me are those worth dying for.",
                "I fight for those who cannot fight for themselves."
            });
            bondTraitsList.Add("Urchin", new string[]
            {
                "My town or city is my home, and I’ll fight to defend it.",
                "I sponsor an orphanage to keep others from enduring what I was forced to endure.",
                "I owe my survival to another urchin who taught me to live on the streets.",
                "I owe a debt I can never repay to the person who took pity on me.",
                "I escaped my life of poverty by robbing an important person, and I’m wanted for it.",
                "No one else should have to endure the hardships I’ve been through."
            });
        }

        private void PopulateFlawTraitsList()
        {
            flawTraitsList.Clear();

            flawTraitsList.Add("Acolyte", new string[]
            {
                "I judge others harshly, and myself even more severely.",
                "I put too much trust in those who wield power within my temple’s hierarchy.",
                "My piety sometimes leads me to blindly trust those that profess faith in my god.",
                "I am inflexible in my thinking.",
                "I am suspicious of strangers and expect the worst of them.",
                "Once I pick a goal, I become obsessed with it to the detriment of everything else in my life."
            });
            flawTraitsList.Add("Charlatan", new string[]
            {
                "I can’t resist a pretty face.",
                "I'm always in debt. I spend my ill-gotten gains on decadent luxuries faster than I bring them in.",
                "I’m convinced that no one could ever fool me the way I fool others.",
                "I’m too greedy for my own good. I can’t resist taking a risk if there’s money involved.",
                "I can’t resist swindling people who are more powerful than me.",
                "I hate to admit it and will hate myself for it, but I'll run and preserve my own hide if the going gets tough."
            });
            flawTraitsList.Add("Criminal", new string[]
            {
                "When I see something valuable, I can’t think about anything but how to steal it.",
                "When faced with a choice between money and my friends, I usually choose the money.",
                "If there’s a plan, I’ll forget it. If I don’t forget it, I’ll ignore it.",
                "I have a “tell” that reveals when I'm lying.",
                "I turn tail and run when things look bad.",
                "An innocent person is in prison for a crime that I committed. I’m okay with that."
            });
            flawTraitsList.Add("Entertainer", new string[]
            {
                "I’ll do anything to win fame and renown.",
                "I’m a sucker for a pretty face.",
                "A scandal prevents me from ever going home again. That kind of trouble seems to follow me around.",
                "I once satirized a noble who still wants my head. It was a mistake that I will likely repeat.",
                "I have trouble keeping my true feelings hidden. My sharp tongue lands me in trouble.",
                "Despite my best efforts, I am unreliable to my friends."
            });
            flawTraitsList.Add("Folk Hero", new string[]
            {
                "The tyrant who rules my land will stop at nothing to see me killed.",
                "I’m convinced of the significance of my destiny, and blind to my shortcomings and the risk of failure.",
                "The people who knew me when I was young know my shameful secret, so I can never go home again.",
                "I have a weakness for the vices of the city, especially hard drink.",
                "Secretly, I believe that things would be better if I were a tyrant lording over the land.",
                "I have trouble trusting in my allies."
            });
            flawTraitsList.Add("Guild Artisan", new string[]
            {
                "I’ll do anything to get my hands on something rare or priceless.",
                "I’m quick to assume that someone is trying to cheat me.",
                "No one must ever learn that I once stole money from guild coffers.",
                "I’m never satisfied with what I have— I always want more.",
                "I would kill to acquire a noble title.",
                "I’m horribly jealous of anyone who can outshine my handiwork. Everywhere I go, I’m surrounded by rivals."
            });
            flawTraitsList.Add("Hermit", new string[]
            {
                "Now that I've returned to the world, I enjoy its delights a little too much.",
                "I harbor dark, bloodthirsty thoughts that my isolation and meditation failed to quell.",
                "I am dogmatic in my thoughts and philosophy.",
                "I let my need to win arguments overshadow friendships and harmony.",
                "I’d risk too much to uncover a lost bit of knowledge.",
                "I like keeping secrets and won’t share them with anyone."
            });
            flawTraitsList.Add("Noble", new string[]
            {
                "I secretly believe that everyone is beneath me.",
                "I hide a truly scandalous secret that could ruin my family forever.",
                "I too often hear veiled insults and threats in every word addressed to me, and I’m quick to anger.",
                "I have an insatiable desire for carnal pleasures.",
                "In fact, the world does revolve around me.",
                "By my words and actions, I often bring shame to my family."
            });
            flawTraitsList.Add("Outlander", new string[]
            {
                "I am too enamored of ale, wine, and other intoxicants.",
                "There’s no room for caution in a life lived to the fullest.",
                "I remember every insult I’ve received and nurse a silent resentment toward anyone who’s ever wronged me.",
                "I am slow to trust members of other races, tribes, and societies.",
                "Violence is my answer to almost any challenge.",
                "Don’t expect me to save those who can’t save themselves. It is nature’s way that the strong thrive and the weak perish."
            });
            flawTraitsList.Add("Sage", new string[]
            {
                "I am easily distracted by the promise of information.",
                "Most people scream and run when they see a demon. I stop and take notes on its anatomy.",
                "Unlocking an ancient mystery is worth the price of a civilization.",
                "I overlook obvious solutions in favor of complicated ones.",
                "I speak without really thinking through my words, invariably insulting others.",
                "I can’t keep a secret to save my life, or anyone else’s."
            });
            flawTraitsList.Add("Sailor", new string[]
            {
                "I follow orders, even if I think they’re wrong.",
                "I’ll say anything to avoid having to do extra work.",
                "Once someone questions my courage, I never back down no matter how dangerous the situation.",
                "Once I start drinking, it’s hard for me to stop.",
                "I can’t help but pocket loose coins and other trinkets I come across.",
                "My pride will probably lead to my destruction."
            });
            flawTraitsList.Add("Soldier", new string[]
            {
                "The monstrous enemy we faced in battle still leaves me quivering with fear.",
                "I have little respect for anyone who is not a proven warrior.",
                "I made a terrible mistake in battle that cost many lives—and I would do anything to keep that mistake secret.",
                "My hatred of my enemies is blind and unreasoning.",
                "I obey the law, even if the law causes misery.",
                "I’d rather eat my armor than admit when I’m wrong."
            });
            flawTraitsList.Add("Urchin", new string[]
            {
                "If I'm outnumbered, I will run away from a fight.",
                "Gold seems like a lot of money to me, and I’ll do just about anything for more of it.",
                "I will never fully trust anyone other than myself.",
                "I’d rather kill someone in their sleep than fight fair.",
                "It’s not stealing if I need it more than someone else.",
                "People who can't take care of themselves get what they deserve."
            });
        }

        private void BackgroundListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EquipmentComboBox.IsEnabled = true;
            ListBoxItem item = BackgroundListBox.SelectedValue as ListBoxItem;

            string[] personalityListing = (string[])personalityTraitsList[BackgroundListBox.SelectedIndex];
            string[] idealListing = (string[])idealTraitsList[BackgroundListBox.SelectedIndex];
            string[] bondListing = (string[])bondTraitsList[BackgroundListBox.SelectedIndex];
            string[] flawListing = (string[])flawTraitsList[BackgroundListBox.SelectedIndex];

            PersonalityTextBox.Text = personalityListing[characteristicsSave[BackgroundListBox.SelectedIndex, 0]];
            IdealTextBox.Text = idealListing[characteristicsSave[BackgroundListBox.SelectedIndex, 1]];
            BondTextBox.Text = bondListing[characteristicsSave[BackgroundListBox.SelectedIndex, 2]];
            FlawTextBox.Text = flawListing[characteristicsSave[BackgroundListBox.SelectedIndex, 3]];

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

        private void RollButton_Click(object sender, RoutedEventArgs e)
        {
            if(rollsLeft > 0)
            {
                Randomize();
                rollsLeft--;
                RollsTextBlock.Text = "Rolls: " + rollsLeft;

                string[] personalityListing = (string[])personalityTraitsList[BackgroundListBox.SelectedIndex];
                string[] idealListing = (string[])idealTraitsList[BackgroundListBox.SelectedIndex];
                string[] bondListing = (string[])bondTraitsList[BackgroundListBox.SelectedIndex];
                string[] flawListing = (string[])flawTraitsList[BackgroundListBox.SelectedIndex];

                PersonalityTextBox.Text = personalityListing[characteristicsSave[BackgroundListBox.SelectedIndex, 0]];
                IdealTextBox.Text = idealListing[characteristicsSave[BackgroundListBox.SelectedIndex, 1]];
                BondTextBox.Text = bondListing[characteristicsSave[BackgroundListBox.SelectedIndex, 2]];
                FlawTextBox.Text = flawListing[characteristicsSave[BackgroundListBox.SelectedIndex, 3]];
            }
        }
    }
}
