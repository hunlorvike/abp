using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Single.BookStore.Data;

public class BookStoreDbContextFactory : IDesignTimeDbContextFactory<BookStoreDbContext>
{
    public BookStoreDbContext CreateDbContext(string[] args)
    {
        BookStoreEfCoreEntityExtensionMappings.Configure();
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BookStoreDbContext>()
            .UseMySql(configuration.GetConnectionString("Default"), MySqlServerVersion.LatestSupportedServerVersion);

        return new BookStoreDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}