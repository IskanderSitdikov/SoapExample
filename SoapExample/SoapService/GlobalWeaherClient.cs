using System.ServiceModel;
using ExternalServices.GlobalWeather;

namespace SoapExample.SoapService;

public sealed class GlobalWeatherClient
{
    public async Task<string?> Test()
    {
        var endpointAddress = new EndpointAddress("http://localhost:8080/castlemock/mock/soap/project/bm3Lke/GlobalWeatherSoap");

        // Use basic HTTP binding (standard for old SOAP services)
        var binding = new BasicHttpBinding();

        // Instantiate the client
        var client = new GlobalWeatherSoapClient(binding, endpointAddress);

        try
        {
            // Call GetCitiesByCountryAsync
            var country = "Usa";
            var resultXml = await client.GetCitiesByCountryAsync(country);
            return resultXml;
        }
        catch (Exception ex)
        {
            //todo: logger
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            await client.CloseAsync();
        }

        return null;
    }
}