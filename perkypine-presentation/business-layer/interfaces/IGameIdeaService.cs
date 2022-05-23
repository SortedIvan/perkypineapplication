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
        void DeleteGameIdeaByName(string gameIdeaName);
        void EditGameIdeaByName(string gameIdeaName, string newGameIdeaName);
        bool DeleteGameByID(Guid gameID);
        GameIdea GetGameIdeaById(Guid gameIdeaId);
    }
}
