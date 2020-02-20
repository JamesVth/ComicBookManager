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
        #region Properties
        public string CharacterName { get; set; }
        public TypeOfCharacter CharacterType { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// New character with the selected values
        /// </summary>
        /// <param name="charactername">Name of the character</param>
        /// <param name="charactertype">Type of character</param>
        public Character(string charactername, TypeOfCharacter charactertype)
        {
            CharacterName = charactername;
            CharacterType = charactertype;
        }
        #endregion
    }
}
