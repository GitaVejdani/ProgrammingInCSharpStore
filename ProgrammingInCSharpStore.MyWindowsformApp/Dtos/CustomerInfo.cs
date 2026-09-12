using Newtonsoft.Json;

namespace ProgrammingInCSharpStore.MyWindowsformApp.Dtos
{
    public class CustomerInfo
    {
        [JsonConstructor]
        public CustomerInfo(string username, string email)
        {
            Username = username;
            EmailAddress = email;
           
        }

        public string Username { get; private set; }
        public string EmailAddress { get; private set; }

        public string VerificationCode { get;  set; }
    }
}
