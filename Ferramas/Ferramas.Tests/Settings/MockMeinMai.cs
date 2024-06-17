using Ferramas.Model.DataTransfer;
using MaiSchatz.Abstracts;

namespace Ferramas.Tests.Settings;

public sealed class MockMeinMai : IMeinMai
{
    public async Task<T?> CallAsync<T>() where T : IResponse
    {
        Type type = typeof(T);
        if(type == typeof(ExchangeResponse))
        {
            Dictionary<string, float> rates = new()
            {
                { "CLP", 1f },
                { "USD", 0.0011f }
            };

            await Task.Delay(1);
            return new ExchangeResponse()
            {
                StatusDescription = "OK",
                StatusCode = 200,
                ReasonPhrase = null,
                Success = true,
                Timestamp = 4,
                Base = "USD",
                Date = DateTime.UtcNow,
                Rates = rates
            } as T;
        }

        return null;
    }
}

