using Microsoft.AspNetCore.Mvc;
using SoapExample.SoapService;

namespace SoapExample.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(
    ILogger<WeatherForecastController> logger,
    GlobalWeatherClient globalWeatherClient)
    : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger = logger;

    [HttpGet("test")]
    public async Task<IActionResult> Test()
    {
        var result = await globalWeatherClient.Test();
        _logger.LogInformation("test");
        return Ok(result);
    }
}