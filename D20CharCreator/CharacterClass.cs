using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace D20CharCreator
{
    public class CharacterClass
    {
        public ClassType Type { get; set; }

        public BitmapImage Image
        {
            get
            {
                switch(Type)
                {
                    case ClassType.BARBARIAN:
                        return new BitmapImage(new Uri(@"pack://application:,,,/Resources/CharacterProfileBarbarian.png"));

                    case ClassType.CLERIC:
                        return new BitmapImage(new Uri(@"pack://application:,,,/Resources/CharacterProfileCleric.png"));

                    case ClassType.ROGUE:
                        return new BitmapImage(new Uri(@"pack://application:,,,/Resources/CharacterProfileRogue.png"));

                    case ClassType.WIZARD:
                        return new BitmapImage(new Uri(@"pack://application:,,,/Resources/CharacterProfileWizard.png"));

                    default:
                        return new BitmapImage(new Uri(@"pack://application:,,,/Resources/CharacterProfileBarbarian.png"));
                }
            }
        }

        public int[] Skills { get; set; }

        public int Equipment { get; set; }
    }
}
