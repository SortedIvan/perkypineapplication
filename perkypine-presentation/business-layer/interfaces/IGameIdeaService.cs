using System;
using System.Collections.Generic;
using models;
namespace business_layer.interfaces
{
    public interface IGameIdeaService
    {
        List<GameIdea> GetGameIdeas();
        GameIdea GetGameIdeaByName(string gameIdea);
        void CreateAndSaveGameIdea(string gameIdeaName);
        void DeleteGameIdeaByID(Guid gameID);
        void EditGameIdeaByGameID(Guid gameID, string newGameIdeaName);
        bool DeleteGameByID(Guid gameID);
        GameIdea GetGameIdeaById(Guid gameIdeaId);
        void TestMethod(Guid guid);
        GameIdea TestDatabase(Guid gameIdeaID);
    }
}
