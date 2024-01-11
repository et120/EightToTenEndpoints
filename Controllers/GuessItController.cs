using EightToTenEndpoints.Services.GuessIt;
using Microsoft.AspNetCore.Mvc;

namespace EightToTenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class GuessItController : ControllerBase
{
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }

    [HttpGet]
    [Route("EasyGuess/{input}")]
    public string EasyGuess(string input)
    {
        return _guessItService.EasyGuess(input);
    }

    [HttpGet]
    [Route("MediumGuess/{input}")]
    public string MediumGuess(string input)
    {
        return _guessItService.MediumGuess(input);
    }

    [HttpGet]
    [Route("HardGuess/{input}")]
    public string HardGuess(string input)
    {
        return _guessItService.HardGuess(input);
    }

}
