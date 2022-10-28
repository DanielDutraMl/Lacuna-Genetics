using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LacunaGenetics

{
    internal partial class LacunaGenetics
    {
        private static async Task CreateUser()
        {

            var registerUserInfo = new RegisterUser { username = "daniel", email = "daniel@dutra.com", password = "password" };

            var requestUri = LacunaGenetics.baseAdress + "/api/users/create";
            var stringContent = new StringContent(registerUserInfo.ToString() ?? "", Encoding.UTF8, "application/json");

            var response = await LacunaGenetics.Client.PostAsync(requestUri, stringContent);
            var content = await response.Content.ReadAsStringAsync();

            var registerUserResponse = JsonSerializer.Deserialize<RegisterUserResponse>(content);
        }
    }
}
