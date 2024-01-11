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
    [Route("EasyGuessANumberBetweenOneAndTen/{inputNumber}")]
    public string EasyGuess(string inputNumber)
    {
        return _guessItService.EasyGuess(inputNumber);
    }

    [HttpGet]
    [Route("MediumGuessANumberBetweenOneAndFifty/{inputNumber}")]
    public string MediumGuess(string inputNumber)
    {
        return _guessItService.MediumGuess(inputNumber);
    }

    [HttpGet]
    [Route("HardGuessANumberBetweenOneAndOneHundred/{inputNumber}")]
    public string HardGuess(string inputNumber)
    {
        return _guessItService.HardGuess(inputNumber);
    }

}
