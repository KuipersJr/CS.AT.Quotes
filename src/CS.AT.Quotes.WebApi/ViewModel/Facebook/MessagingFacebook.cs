namespace CS.AT.Quotes.WebApi.Controllers.ViewModel.Facebook
{
    public class MessagingFacebook
    {
        public SenderFacebook Sender { get; set; }
        public RecipientFacebook Recipient { get; set; }
        public string Timestamp { get; set; }
        public MessageFacebook Message { get; set; }
    }
}