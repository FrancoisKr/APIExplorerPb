using Acme.BookStore4.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore4.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BookStore4Controller : AbpController
    {
        protected BookStore4Controller()
        {
            LocalizationResource = typeof(BookStore4Resource);
        }
    }
}