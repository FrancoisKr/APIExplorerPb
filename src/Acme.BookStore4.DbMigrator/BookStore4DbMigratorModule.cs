using Acme.BookStore4.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.BookStore4.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BookStore4EntityFrameworkCoreDbMigrationsModule),
        typeof(BookStore4ApplicationContractsModule)
        )]
    public class BookStore4DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
