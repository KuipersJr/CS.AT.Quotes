using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS.AT.Quotes.Domain;

namespace CS.AT.Quotes.Repository.WebApi
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class QuoteRepository : IQuoteRepository
    {
        public QuoteRepository()
        {
        }

        public void Post(Quote quote)
        {
            
        }
    }
}
