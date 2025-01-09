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
        [Route("guessNumber/{mode}/{guess}")]
        public string GetResponse(string mode, string guess)
        {
            return _guessItService.GetResponse(mode, guess);
        }
    }
}