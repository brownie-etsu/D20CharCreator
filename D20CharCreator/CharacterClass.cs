using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20CharCreator
{
    public class CharacterClass
    {
        public ClassType Type { get; set; }

        public int[] Skills { get; set; }

        public string Equipment { get; set; }
    }
}
