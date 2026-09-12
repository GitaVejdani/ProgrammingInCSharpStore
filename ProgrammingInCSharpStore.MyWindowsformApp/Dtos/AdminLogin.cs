using Newtonsoft.Json;

namespace ProgrammingInCSharpStore.MyWindowsformApp.Dtos;

public class AdminLogin
{
    [JsonConstructor]
    public AdminLogin(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public string Username { get; private set; }
    public string Password { get; private set; }
}
