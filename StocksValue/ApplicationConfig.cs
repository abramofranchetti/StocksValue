namespace StocksValue;

public class ApplicationConfig
{
    public int refreshMinutes { get; set; } = 60;
    public string apiKey { get; set; }
    public List<Stock> stocks { get; set; } = new();
}

public class Stock
{
    public string ticker { get; set; }
    public string nome { get; set; }
    public decimal referencePrice { get; set; }
}
