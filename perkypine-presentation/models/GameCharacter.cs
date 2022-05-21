using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class GameCharacter
    {
        public string CharacterName { get; set; }
        public string CharacterType { get; set; }

        public GameCharacter(string characterName, string characterType)
        {
            this.CharacterType = characterType;
            this.CharacterName = characterName;
        }
    }
}
