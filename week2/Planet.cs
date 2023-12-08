public class Planet
{
    public string Name { get; set; }
    public List<Moon> Moons { get; set; }
}

public class Moon
{
    public string Name { get; set; }
    public Weather Weather { get; set; }
}

public class Weather
{
    public int TemperatureCelsius { get; set; }
    public string Condition { get; set; }
}
