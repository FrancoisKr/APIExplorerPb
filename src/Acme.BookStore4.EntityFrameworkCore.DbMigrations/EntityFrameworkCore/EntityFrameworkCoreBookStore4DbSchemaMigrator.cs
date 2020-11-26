using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.BookStore4.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore4.EntityFrameworkCore
{
    public class EntityFrameworkCoreBookStore4DbSchemaMigrator
        : IBookStore4DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBookStore4DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BookStore4MigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<BookStore4MigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}