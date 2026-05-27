var baseAddress = "https://swapi.info/api/";
var requestUrl = "planets";

IApiDataReader reader = new ApiDataReader();

var data = await reader.Read(baseAddress, requestUrl);
Console.Write(data);

public interface IApiDataReader
{
    public Task<string> Read(string baseAddress, string requestUrl);
}

public class ApiDataReader : IApiDataReader
{
    public async Task<string> Read(string baseAddress, string requestUrl)
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseAddress);
        var response = await client.GetAsync(requestUrl);

        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}