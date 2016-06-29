using CS.AT.Quotes.Domain.Quotes.Entities;

namespace CS.AT.Quotes.Domain.Quotes.Interfaces
{
    public interface IQuoteRepository
    {
        void Post(Quote quote);
    }
}