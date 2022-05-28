﻿using business_layer.interfaces;
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
        private readonly IGameCharacterService gameCharacterService;
        public GameIdeasController(IGameIdeaService gameService, IGameCharacterService gameCharacterService)
        {
            this.gameService = gameService;
            this.gameCharacterService = gameCharacterService;
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

        //[HttpPost("api/creategame")]
        //public void CreateGameIdea(string gameName)
        //{
        //    this.gameService.CreateAndSaveGameIdea(gameName);
        //}

        //[HttpDelete("api/deletegameid/{gameID}")]
        //public void DeleteGameIdeaByName(Guid gameID)
        //{
        //    this.gameService.DeleteGameByID(gameID);
        //}

        [HttpPut("api/editgamebyid/{gameID}")]
        public JsonResult EditGameIdeaByName(Guid gameID, string newGameName)
        {
            this.gameService.EditGameIdeaByGameID(gameID, newGameName);
            return new JsonResult($"Game name changed to: {newGameName}");
        }

        [HttpDelete("api/deletegameid/{gameID}")]
        public JsonResult DeleteGameByID(Guid gameID)
        { 
            bool result = this.gameService.DeleteGameByID(gameID);
            if (result)
            {
                this.gameCharacterService.CreateAndSaveGameCharacterToGame(gameID);
                return new JsonResult($"Character was added to game: {this.gameService.GetGameIdeaById(gameID)}");
            }
            return new JsonResult($"No game was found with id: {gameID}");

        }

        [HttpPut("api/addcharactertogame")]
        public JsonResult AddCharactersToGame(Guid gameID)
        {
            if (this.gameService.GetGameIdeaById(gameID) != null)
            {
                this.gameCharacterService.CreateAndSaveGameCharacterToGame(gameID);
                return new JsonResult($"Character was added to game: {this.gameService.GetGameIdeaById(gameID)}");
            }
            return new JsonResult($"No game was found with id: {gameID}");

        }

        [HttpGet("api/getgamebyid/{gameID}")]
        public GameIdea GetGameIdeaByID(Guid gameID)
        {
            if (this.gameService.GetGameIdeaById(gameID) != null)
            {
                return this.gameService.GetGameIdeaById(gameID);
            }
            return null;
        }

        [HttpPut("api/getgamebyid/{gameID}")]
        public void TestMethod(Guid gameID)
        {
            if (this.gameService.GetGameIdeaById(gameID) != null)
            {
                this.gameService.TestMethod(gameID);
            }
            
        }

        [HttpGet("api/getgamebyidfromdb/{gameID}")]
        public GameIdea GetGameIdeaByIdFromDB(Guid gameID)
        {
            if (this.gameService.TestDatabase(gameID) != null)
            {
                return this.gameService.TestDatabase(gameID);
            }
            return null;
        }


        #region Different types of random games API's
        // Returning a random idea API (highest priority as of right now)
        [HttpGet("api/getrandomgameidea/{gameName}")]
        public GameIdea GetRandomGameIdea(string gameName)
        {
           GameIdea randomGame = this.gameService.CreateReturnableGameIdea(gameName);
           randomGame.GameCharacters = this.gameCharacterService.CreateAndReturnAddableCharacters();
           return randomGame;
        }

        [HttpGet("api/getrandomspacegame/{gameName}")]
        public GameIdea GetRandomSpaceGameIdea(string gameName)
        {
            GameIdea randomGame = this.gameService.CreateReturnableGameIdea(gameName);
            randomGame.GameCharacters = this.gameCharacterService.CreateSpaceCharacters();
            return randomGame;
        }

        [HttpGet("api/getrandomfantasygame/{gameName}")]
        public GameIdea GetRandomFantasyGameIdea(string gameName)
        {
            GameIdea randomGame = this.gameService.CreateReturnableGameIdea(gameName);
            randomGame.GameCharacters = this.gameCharacterService.CreateFantasyCharacters();
            return randomGame;
        }

        [HttpGet("api/getrandomscifigame/{gameName}")]
        public GameIdea GetRandomSciFiGameIdea(string gameName)
        {
            GameIdea randomGame = this.gameService.CreateReturnableGameIdea(gameName);
            randomGame.GameCharacters = this.gameCharacterService.CreateSciFiCharacters();
            return randomGame;
        }
        #endregion
    }

}
