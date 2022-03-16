using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController()
    {

    }

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] {"value1","value2"};
    }

    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "Hemant";
    }
}
