using Volo.Abp.Modularity;

namespace Acme.BookStore4
{
    [DependsOn(
        typeof(BookStore4ApplicationModule),
        typeof(BookStore4DomainTestModule)
        )]
    public class BookStore4ApplicationTestModule : AbpModule
    {

    }
}