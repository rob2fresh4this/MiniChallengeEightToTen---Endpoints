using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen___Endpoints.Service;

namespace MiniChallengeEightToTen___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        readonly GuessItService _guessItService;
        public GuessItController(GuessItService guessItService)
        {
            _guessItService = guessItService;
        }

        [HttpGet]
        [Route("EasyMode")]
        public string EasyMode(string guess)
        {
            return _guessItService.EasyMode(guess);
        }

        [HttpGet]
        [Route("MediumMode")]
        public string MediumMode(string guess)
        {
            return _guessItService.MediumMode(guess);
        }

        [HttpGet]
        [Route("HardMode")]
        public string HardMode(string guess)
        {
            return _guessItService.HardMode(guess);
        }
    }
}