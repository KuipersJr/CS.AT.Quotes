using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CS.AT.Quotes.WebApi.FacebookService
{
    public class FacebookHttpClient
    {
        private readonly IConfigurationRoot _configuration;

        public FacebookHttpClient(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }

        public string VerificarToken(string token, string desafio)
        {
            var verifytoken = _configuration["Facebook:EAASZBgNqfaL0BACU8yxSKhjcCnbxTZAGhFoXegc4BFVo9qZAJHZANnhixcU2rvZArUhpdP0bewqqu9kMt19w78PfZCMBzuzE5XyPtqbMKoc1CdgDqshE4ke2WxXBzgxDBg8wxtfgBTl6GCdANSwCWiXqSjewJCoODcZBbVwQ8FmWgZDZD"];
            return token != verifytoken ? "Teste" : desafio;
        }

        public async Task EnviarMenssagem(string beneficiario, string mensagem)
        {
            var token = _configuration["Facebook:Token"];
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://graph.facebook.com/v2.6/me/messages");
                var body = new
                {
                    recipient = new
                    {
                        id = beneficiario
                    },
                    message = new
                    {
                        text = mensagem,
                    }
                };
                await client.PostAsJsonAsync($"?access_token={token}", body);
            }

        }
    }
}