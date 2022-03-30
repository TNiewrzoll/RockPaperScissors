using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RockPaperSciccors.Model;
using RockPaperSciccors.Service;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RockPaperSciccors.Controllers
{
    [Route("api/gamecontroller")]
    [ApiController]
    public class GameController : ControllerBase
    {
        // GET api/<GameController>/5
        [HttpGet("PlayRockPaperScissors")]
        public object PlayRockPaperScissors(HandGesture player,  AILevel aILevel)
        {
            var services = this.HttpContext.RequestServices;
            
            //Get new instances from IOC container
            var gameService = (IGameService)services.GetService(typeof(IGameService));

            //Set the player values
            gameService.SetValues(player, aILevel);

            return Ok(gameService.StartGame());
        }
    }
}
