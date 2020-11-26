using Acme.BookStore4.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.BookStore4
{
    [DependsOn(
        typeof(BookStore4EntityFrameworkCoreTestModule)
        )]
    public class BookStore4DomainTestModule : AbpModule
    {

    }
}