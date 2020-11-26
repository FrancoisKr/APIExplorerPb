using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Acme.BookStore4.EntityFrameworkCore
{
    [DependsOn(
        typeof(BookStore4EntityFrameworkCoreModule)
        )]
    public class BookStore4EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BookStore4MigrationsDbContext>();
        }
    }
}
