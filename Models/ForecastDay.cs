namespace BlueShorts.Models;

public class ForecastDay
{
    public float MaxtempF { get; set; }
    public float MintempF { get; set; }
    public IEnumerable<ForecastHour> Hour { get; set; }
}