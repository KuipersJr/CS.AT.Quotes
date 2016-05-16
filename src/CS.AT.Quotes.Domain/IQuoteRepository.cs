namespace CS.AT.Quotes.Domain
{
    public interface IQuoteRepository
    {
        void Post(Quote quote);
    }
}