using Xunit;

namespace Layered.BookStore.EntityFrameworkCore;

[CollectionDefinition(BookStoreTestConsts.CollectionDefinitionName)]
public class BookStoreEntityFrameworkCoreCollection : ICollectionFixture<BookStoreEntityFrameworkCoreFixture>
{

}
