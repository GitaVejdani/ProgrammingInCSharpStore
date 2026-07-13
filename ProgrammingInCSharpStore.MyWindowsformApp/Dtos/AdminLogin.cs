using Newtonsoft.Json;

namespace ProgrammingInCSharpStore.MyWindowsformApp.Dtos;

public class AdminLogin
{
    [JsonProperty]
    public string Username { get; private set; }

    [JsonProperty]
    public string Password { get; private set; }
}
