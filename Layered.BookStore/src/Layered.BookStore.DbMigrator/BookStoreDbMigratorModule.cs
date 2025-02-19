using Layered.BookStore.EntityFrameworkCore;

using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Layered.BookStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookStoreEntityFrameworkCoreModule),
    typeof(BookStoreApplicationContractsModule)
)]
public class BookStoreDbMigratorModule : AbpModule
{
}
