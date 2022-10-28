using System;
using System.Net.Http;


namespace LacunaGenetics
{

    internal partial class LacunaGenetics
    {
    public static HttpClient Client = new HttpClient();
    public static string baseAdress = "https://gene.lacuna.cc/";

        public static async Task Main(string[] args)
        {
            await LacunaGenetics.CreateUser();
        }

    }
}
