using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore4.Web
{
    [Dependency(ReplaceServices = true)]
    public class BookStore4BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "BookStore4";
    }
}
