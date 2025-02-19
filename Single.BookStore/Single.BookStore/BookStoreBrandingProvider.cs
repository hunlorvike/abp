using Microsoft.Extensions.Localization;

using Single.BookStore.Localization;

using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Single.BookStore;

[Dependency(ReplaceServices = true)]
public class BookStoreBrandingProvider(IStringLocalizer<BookStoreResource> localizer) : DefaultBrandingProvider
{
    private readonly IStringLocalizer<BookStoreResource> _localizer = localizer;

    public override string AppName => _localizer["AppName"];
}
