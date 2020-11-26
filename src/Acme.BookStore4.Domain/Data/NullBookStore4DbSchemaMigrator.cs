using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore4.Data
{
    /* This is used if database provider does't define
     * IBookStore4DbSchemaMigrator implementation.
     */
    public class NullBookStore4DbSchemaMigrator : IBookStore4DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}