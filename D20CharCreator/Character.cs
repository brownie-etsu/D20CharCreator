namespace D20CharCreator
{
    public class Character
    {
        public int CharacterId { get; set; }

        public CharacterClass Class { get; set; }

        public CharacterBackground Background { get; set; }

        public string Name { get; set; }

        public Character()
        {
            Class = new CharacterClass();
            Background = new CharacterBackground();
            Class.Equipment = 0;
            Class.Skills = new int[4];
            Class.Skills[0] = 0;
            Class.Skills[1] = 0;
            Class.Skills[2] = 0;
            Class.Skills[3] = 0;
            Class.Type = 0;
            Background.Equipment = 0;
            Background.LangOne = (Language)(-1);
            Background.LangTwo = (Language)(-1);
            Background.Rerolls = 3;
            Background.Type = 0;
            Background.Characteristics = new int[4];
            Background.Characteristics[0] = 0;
            Background.Characteristics[1] = 0;
            Background.Characteristics[2] = 0;
            Background.Characteristics[3] = 0;
        }
    }
}
