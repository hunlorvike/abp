using System.Threading.Tasks;

namespace Layered.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
