using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoardGamesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoardGamesController : ControllerBase
    {
        private readonly ILogger<BoardGamesController> _logger;
        private static List<BoardGame> _boardGames = new List<BoardGame>();

        public BoardGamesController(ILogger<BoardGamesController> logger)
        {
            _logger = logger;
        }

        [HttpPost("CreateNewBoardGame")]
        public IActionResult CreateNewBoardGame(BoardGame boardGame)
        {
            if (string.IsNullOrEmpty(boardGame.Name))
            {
                return BadRequest("Name is required");
            }

            if (boardGame.Played != "N" && boardGame.Played != "Y")
            {
                return BadRequest("Played can only be values 'N' or 'Y'");
            }

            _boardGames.Add(boardGame);
             //return CreatedAtAction("GetBoardGameById", new { id = boardGame.Id }, boardGame);
            return Ok();
        }

        [HttpGet("GetAllBoardGames")]
        public IActionResult GetAllBoardGames()
        {
            return Ok(_boardGames);
        }
    }
}