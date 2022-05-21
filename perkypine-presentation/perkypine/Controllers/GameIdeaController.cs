using business_layer.interfaces;
using Microsoft.AspNetCore.Mvc;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace perkypine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameIdeasController : ControllerBase
    {
        private readonly IGameIdeaService gameService;
        public GameIdeasController(IGameIdeaService gameService)
        {
            this.gameService = gameService;
        }

        [HttpGet]
        public List<GameIdea> GetGameIdeas()
        {
            return this.gameService.GetGameIdeas();
        }

        [HttpGet("{gameName}")]
        public GameIdea GetGameIdeaByName(string gameName)
        {
            return this.gameService.GetGameIdeaByName(gameName);
        }


        [HttpPost]
        public void CreateGameIdea(string gameName)
        {
            this.gameService.CreateAndSaveGameIdea(gameName);
        }

        [HttpDelete("{gameName}")]
        public void DeleteGameIdeaByName(string gameName)
        {
            this.gameService.DeleteGameIdeaByName(gameName);
        }

        [HttpPut("{gameName}")]
        public void EditGameIdeaByName(string gameName, string newGameName)
        {
            this.gameService.EditGameIdeaByName(gameName, newGameName);
        }
    }

}
