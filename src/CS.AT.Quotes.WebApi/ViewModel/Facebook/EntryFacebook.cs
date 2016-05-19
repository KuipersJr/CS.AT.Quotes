using System.Collections.Generic;

namespace CS.AT.Quotes.WebApi.Controllers.ViewModel.Facebook
{
    public class EntryFacebook
    {
        public string Id { get; set; }
        public string Time { get; set; }
        public IList<MessagingFacebook> Messaging { get; set; }
    }
}