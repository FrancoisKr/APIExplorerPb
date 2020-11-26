using Acme.BookStore4.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.BookStore4.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class BookStore4PageModel : AbpPageModel
    {
        protected BookStore4PageModel()
        {
            LocalizationResourceType = typeof(BookStore4Resource);
        }
    }
}