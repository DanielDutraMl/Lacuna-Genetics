namespace LacunaGenetics
{
    public class RegisterUser
    {
       public string username { get; set; } = "";
       public string email { get; set; } = "";
       public string password { get; set; } = "";
    }

    public class RegisterUserResponse
    {
        public string code { get; set; } = "";
        public string? message { get; set; } = "";
    }
    public class Login
    {
        public string username { get; set; } = "";
        public string password { get; set; } = "";
    }

    public class LoginResponse
    {
        public string? accessToken { get; set; } = "";
        public string code { get; set; } = "";
        public string? message { get; set; } = "";
    }
}
