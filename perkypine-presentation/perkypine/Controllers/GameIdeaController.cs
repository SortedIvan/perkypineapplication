using business_layer.interfaces;
using Microsoft.AspNetCore.Mvc;
using models;
using System;
using System.Collections.Generic;

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

        [HttpGet("api/gameideas")]
        public List<GameIdea> GetGameIdeas()
        {
            return this.gameService.GetGameIdeas();
        }

        [HttpGet("api/{gameName}")]
        public GameIdea GetGameIdeaByName(string gameName)
        {
            return this.gameService.GetGameIdeaByName(gameName);
        }

        [HttpPost("api/creategame")]
        public void CreateGameIdea(string gameName)
        {
            this.gameService.CreateAndSaveGameIdea(gameName);
        }

        [HttpDelete("api/deletegameid/{gameID}")]
        public void DeleteGameIdeaByName(Guid gameID)
        {
            this.gameService.DeleteGameByID(gameID);
        }

        [HttpPut("api/editgamebyid/{gameID}")]
        public JsonResult EditGameIdeaByName(Guid gameID, string newGameName)
        {
            this.gameService.EditGameIdeaByGameID(gameID, newGameName);
            return new JsonResult($"Game name changed to: {newGameName}");
        }

        [HttpDelete("deletegameid/{gameID}")]
        public JsonResult DeleteGameByID(Guid gameID)
        { 
            bool result = this.gameService.DeleteGameByID(gameID);
            if (result)
            {
                return new JsonResult("Game deleted successfully");
            }
            return new JsonResult("Game was not deleted");
        }
    }

}
