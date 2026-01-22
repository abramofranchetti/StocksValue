namespace StocksValue;

using System.Net.Http;
using System.Text.Json;

public class FinanceClient
{
    private static readonly HttpClient _http = new HttpClient();
    public string ApiKey { get; set; }

    /// <summary>
    /// ticker esempio:
    /// IE00B4L5Y983.XETR
    /// SGLD.XETR
    /// VOW3.XETR
    /// </summary>
    public async Task<decimal?> GetPriceAsync(string ticker)
    {
        var url =
            $"https://eodhd.com/api/real-time/{ticker}?api_token={ApiKey}&fmt=json";

        try
        {
            var json = await _http.GetStringAsync(url);

            using var doc = JsonDocument.Parse(json);

            // "close" = ultimo prezzo intraday disponibile
            if (!doc.RootElement.TryGetProperty("close", out var close))
                return null;

            return close.GetDecimal();
        }
        catch
        {
            return null;
        }
    }
}

