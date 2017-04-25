using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20CharCreator
{
    public class CharacterBackground
    {
        public BackgroundType Type { get; set; }

        public Language LangOne { get; set; }

        public Language LangTwo { get; set; }

        public string Equipment { get; set; }

        public int[] Characteristics { get; set; }

        public int Rerolls { get; set; }

        public CharacterBackground()
        {

        }
    }
}
