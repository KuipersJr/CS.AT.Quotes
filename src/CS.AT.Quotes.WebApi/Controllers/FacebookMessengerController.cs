using CS.AT.Quotes.WebApi.Controllers.ViewModel.Facebook;
using CS.AT.Quotes.WebApi.FacebookService;
using Microsoft.AspNetCore.Mvc;

namespace CS.AT.Quotes.WebApi.Controllers
{
    [Route("api/facebookmessenger")]
    public class FacebookMessengerController : Controller
    {
        private readonly FacebookHttpClient _facebookCliente;

        public FacebookMessengerController(FacebookHttpClient facebookCliente)
        {
            _facebookCliente = facebookCliente;
        }

        [HttpGet]
        public string Get()
        {
            return _facebookCliente.VerificarToken(Request.Query["hub.verify_token"], Request.Query["hub.challenge"]);
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody] FacebookMessage message)
        {
            var messaging = message.Entry[0].Messaging[0];
            await _facebookCliente.EnviarMenssagem(messaging.Sender.Id, $"Você enviou -- {messaging.Message.Text}");
        }
    }
}
