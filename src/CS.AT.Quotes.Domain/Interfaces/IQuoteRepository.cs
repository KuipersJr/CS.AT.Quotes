using CS.AT.Quotes.Domain.Entities;

namespace CS.AT.Quotes.Domain.Interfaces
{
    public interface IQuoteRepository
    {
        void Post(Quote quote);
    }
}