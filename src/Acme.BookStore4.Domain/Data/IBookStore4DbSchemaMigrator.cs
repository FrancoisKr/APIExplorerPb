using System.Threading.Tasks;

namespace Acme.BookStore4.Data
{
    public interface IBookStore4DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
