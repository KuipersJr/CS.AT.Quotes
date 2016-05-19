using System.Collections.Generic;

namespace CS.AT.Quotes.WebApi.Controllers.ViewModel.Facebook
{
    public class FacebookMessage
    {
        public string Object { get; set; }
        public IList<EntryFacebook> Entry { get; set; }
    }
}