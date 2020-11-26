using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Acme.BookStore4.EntityFrameworkCore
{
    public static class BookStore4DbContextModelCreatingExtensions
    {
        public static void ConfigureBookStore4(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BookStore4Consts.DbTablePrefix + "YourEntities", BookStore4Consts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}