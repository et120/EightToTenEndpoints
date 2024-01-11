using EightToTenEndpoints.Services.MagicBall;
using Microsoft.AspNetCore.Mvc;

namespace EightToTenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class MagicBallController : ControllerBase
{
    private readonly IMagicBallService _magicBallService;

    public MagicBallController(IMagicBallService magicBallService)
    {
        _magicBallService = magicBallService;
    }

    [HttpGet]
    [Route("Generate/")]
    public string Generate()
    {
        return _magicBallService.Generate();
    }
}
