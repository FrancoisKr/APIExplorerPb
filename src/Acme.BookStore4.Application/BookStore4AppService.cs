using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookStore4.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStore4
{
    /* Inherit your application services from this class.
     */
    public abstract class BookStore4AppService : ApplicationService
    {
        protected BookStore4AppService()
        {
            LocalizationResource = typeof(BookStore4Resource);
        }
    }
}
