using System.Collections.Generic;

public static class SolarSystemData
{
    public static readonly List<Planet> Planets = new List<Planet>
    {
        new Planet
    {
        Name = "Mercury",
        Moons = new List<Moon>
        {
            new Moon
            {
                Name = "Phobos",
                Weather = new Weather
                {
                    TemperatureCelsius = -50,
                    Condition = "Partly Cloudy"
                }
            },
            new Moon
            {
                Name = "Deimos",
                Weather = new Weather
                {
                    TemperatureCelsius = -60,
                    Condition = "Sunny"
                }
            }
        }
    },
    new Planet
    {
        Name = "Venus",
        Moons = new List<Moon>
        {
            new Moon
            {
                Name = "Io",
                Weather = new Weather
                {
                    TemperatureCelsius = 460,
                    Condition = "Hot and Cloudy"
                }
            },
            new Moon
            {
                Name = "Europa",
                Weather = new Weather
                {
                    TemperatureCelsius = -160,
                    Condition = "Icy"
                }
            }
        }
    },
    new Planet
    {
        Name = "Earth",
        Moons = new List<Moon>
        {
            new Moon
            {
                Name = "Luna",
                Weather = new Weather
                {
                    TemperatureCelsius = 20,
                    Condition = "Mostly Clear"
                }
            }
        }
    },
    };
}
