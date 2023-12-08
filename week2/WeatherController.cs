using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("api/solarsystem")]
public class WeatherController : ControllerBase
{
    [HttpGet("{planetName}")]
    public IActionResult GetPlanetWeather(string planetName)
    {
        var planet = SolarSystemData.Planets.Find(p => p.Name.Equals(planetName, StringComparison.OrdinalIgnoreCase));

        if (planet == null)
        {
            return NotFound();
        }

        return Ok(planet);
    }
}
