using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Acme.BookStore4.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(BookStore4HttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class BookStore4ConsoleApiClientModule : AbpModule
    {
        
    }
}
