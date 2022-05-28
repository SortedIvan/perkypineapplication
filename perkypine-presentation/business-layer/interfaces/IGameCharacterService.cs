using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_layer.interfaces
{
    public interface IGameCharacterService
    {
        List<GameCharacter> GetGameCharacters();
        GameCharacter GetGameCharacter();
        void CreateAndSaveGameCharacterToGame(Guid gameID);
        // Returnable characters, saving to be added
        List<GameCharacter> CreateAndReturnAddableCharacters();
        List<GameCharacter> CreateSpaceCharacters();
        List<GameCharacter> CreateSciFiCharacters();
        List<GameCharacter> CreateFantasyCharacters();
    }
}
