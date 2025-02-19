using Layered.BookStore.Samples;

using Xunit;

namespace Layered.BookStore.EntityFrameworkCore.Applications;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookStoreEntityFrameworkCoreTestModule>
{

}
