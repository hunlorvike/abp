using Volo.Abp.Modularity;

namespace Layered.BookStore;

[DependsOn(
    typeof(BookStoreDomainModule),
    typeof(BookStoreTestBaseModule)
)]
public class BookStoreDomainTestModule : AbpModule
{

}
