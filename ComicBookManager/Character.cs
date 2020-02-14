using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBookManager
{
    enum TypeOfCharacter
    {
        Hero,
        Villian,
        Sidekick,
        Civilian,
        LoveInterest
    }

    class Character
    {
        public string CharacterName { get; set; }
        public TypeOfCharacter CharacterType { get; set; }
    }
}
