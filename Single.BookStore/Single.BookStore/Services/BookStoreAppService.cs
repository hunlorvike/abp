using Single.BookStore.Localization;

using Volo.Abp.Application.Services;

namespace Single.BookStore.Services;

/* Inherit your application services from this class. */
public abstract class BookStoreAppService : ApplicationService
{
    protected BookStoreAppService()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
