using Newtonsoft.Json;

namespace ProgrammingInCSharp___Store.Dtos;

public class AdminLogin
{
    [JsonProperty]
    public string Username { get; private set; }

    [JsonProperty]
    public string Password { get; private set; }
}
