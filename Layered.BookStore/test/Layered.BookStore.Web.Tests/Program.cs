using Layered.BookStore;

using Microsoft.AspNetCore.Builder;

using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Layered.BookStore.Web.csproj");
await builder.RunAbpModuleAsync<BookStoreWebTestModule>(applicationName: "Layered.BookStore.Web");

public partial class Program
{
}
