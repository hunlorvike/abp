using Layered.BookStore.Localization;

using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Layered.BookStore.Web.Pages;

public abstract class BookStorePageModel : AbpPageModel
{
    protected BookStorePageModel()
    {
        LocalizationResourceType = typeof(BookStoreResource);
    }
}
